Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR03100Back
Imports PNR03100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR03100StreamingService" in code, svc and config file together.
Public Class PNR03100StreamingService
    Implements IPNR03100StreamingService

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IPNR03100StreamingService.GetEmployeeList
        Dim loRtn As Message
        Dim loEx As New R_Exception
        Dim loCls As New PNR03100BackCLS
        Dim loRtnTemp As List(Of PNR03100BackStreamingDTO)
        Dim loParam As New PNR03100BackDTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cModId = R_Utility.R_GetStreamingContext("cModId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
            loParam.lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
            loParam.lActive = R_Utility.R_GetStreamingContext("lActive")

            loRtnTemp = loCls.GetEmployeeList(loParam)

            loList = R_Utility.R_GetChunkData(Of PNR03100BackStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR03100StreamingService.GetReportData
        Dim loRtn As Message
        Dim loEx As New R_Exception
        Dim loCls As New PNR03100BackCLS
        Dim loRtnTemp As List(Of PNR03100ReportDTO)
        Dim loParam As New PNR03100BackDTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cCutOfDate = R_Utility.R_GetStreamingContext("cCutOfDate")
            loParam.cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
            loParam.cReportOption = R_Utility.R_GetStreamingContext("cReportOption")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtnTemp = loCls.GetReportData(loParam)

            loList = R_Utility.R_GetChunkData(Of PNR03100ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As PNR03100Back.PNR03100BackDTO) Implements IPNR03100StreamingService.Dummy

    End Sub
End Class

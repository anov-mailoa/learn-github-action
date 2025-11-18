Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR03300Back
Imports PNR03300Common

Public Class PNR03300StreamingService
    Implements IPNR03300StreamingService

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IPNR03300StreamingService.GetEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New PNR03300Cls
        Dim loRtnTemp As List(Of PNR03300StreamingDto)
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        Dim loParam As New PNR03300GridDto

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cModId = R_Utility.R_GetStreamingContext("cModId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.lCheckInterfaceModule = R_Utility.R_GetStreamingContext("lCheckInterfaceModule")
            loParam.lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
            loParam.cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            loParam.cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")

            loRtnTemp = loCls.GetEmployeeList(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR03300StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR03300StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR03300Cls
        Dim loRtnTemp As List(Of PNR03300ReportDto)
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        Dim loParam As New PNR03300GridDto

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
            loParam.cCutOfDate = R_Utility.R_GetStreamingContext("cCutOfDate")

            loRtnTemp = loCls.GetReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR03300ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

End Class

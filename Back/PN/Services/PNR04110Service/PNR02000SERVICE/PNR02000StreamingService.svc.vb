Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR02000Back
Imports PNR02000Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR02000StreamingService" in code, svc and config file together.
Public Class PNR02000StreamingService
    Implements IPNR02000StreamingService

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IPNR02000StreamingService.GetEmployeeList
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNR02000BackCLS
        Dim loRtnTemp As List(Of PNR02000BackStreamingDTO)
        Dim loParam As New PNR02000BackDTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cToDate = R_Utility.R_GetStreamingContext("cToDate")

            loRtnTemp = loCls.GetEmployeeList(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR02000BackStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR02000StreamingService.GetReportData
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNR02000BackCLS
        Dim loRtnTemp As List(Of PNR02000ReportDTO)
        Dim loParam As New PNR02000BackDTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
            loParam.cToDate = R_Utility.R_GetStreamingContext("cToDate")
            loParam.cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
            loParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            loParam.lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtnTemp = loCls.GetReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR02000ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As PNR02000Back.PNR02000BackDTO) Implements IPNR02000StreamingService.Dummy

    End Sub
End Class

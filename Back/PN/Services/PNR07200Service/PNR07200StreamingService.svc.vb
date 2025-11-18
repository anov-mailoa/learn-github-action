Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR07200Back
Imports PNR07200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR07200StreamingService" in code, svc and config file together.
Public Class PNR07200StreamingService
    Implements IPNR07200StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR07200StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR07200BackCLS
        Dim loParam As New PNR07200BackDTO
        Dim loRtnTemp As List(Of PNR07200ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
            loParam.cToDate = R_Utility.R_GetStreamingContext("cToDate")
            loParam.cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")

            loRtnTemp = loCls.GetReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR07200ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As PNR07200Back.PNR07200BackDTO) Implements IPNR07200StreamingService.Dummy

    End Sub

End Class

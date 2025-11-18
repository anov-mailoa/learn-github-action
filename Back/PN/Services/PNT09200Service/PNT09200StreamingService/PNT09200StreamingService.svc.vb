Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09200Common
Imports PNT09200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT09200StreamingService" in code, svc and config file together.
Public Class PNT09200StreamingService
    Implements IPNT09200StreamingService

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNT09200StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNT09200Cls
        Dim loRtnTemp As List(Of PNT09200ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loParam As New PNT09200DTO

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            loParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtnTemp = loCls.getReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNT09200ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParPNT09201Grid As System.Collections.Generic.List(Of PNT09200Back.PNT09201GridDTO)) Implements IPNT09200StreamingService.Dummy

    End Sub
End Class

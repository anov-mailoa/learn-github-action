Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCB04000Back
Imports MCB04000Common

Public Class MCB04000StreamingService
    Implements IMCB04000StreamingService

    Public Function getOutstandingTransactionList() As System.ServiceModel.Channels.Message Implements IMCB04000StreamingService.getOutstandingTransactionList
        Dim loEx As New R_Exception
        Dim loParam As New MCB04000OutstandingTransactionDto
        Dim loCls As New MCB04000ClosePolicyCls
        Dim loRtn As List(Of MCB04000StreamingDto)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cTransactionCode = R_Utility.R_GetStreamingContext("cLangId")
            loParam.cYear = R_Utility.R_GetStreamingContext("cYear")

            loRtn = loCls.getOutstandingTransactionList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB04000StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getOutstandingTransactionList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg

    End Function

    Public Function getUntransferedClaimList() As System.ServiceModel.Channels.Message Implements IMCB04000StreamingService.getUntransferedClaimList
        Dim loEx As New R_Exception
        Dim loParam As New MCB04000UntransferedClaimDto
        Dim loCls As New MCB04000ClosePolicyCls
        Dim loRtn As List(Of MCB04000StreamingDto)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())

        Try
            loParam.cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            loParam.cYear = R_Utility.R_GetStreamingContext("cYear")

            loRtn = loCls.getUntransferedClaimList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB04000StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getUntransferedClaimList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg

    End Function

    Public Sub Dummy(poParGrid1 As System.Collections.Generic.List(Of MCB04000Back.MCB04000OutstandingTransactionDto), poReport As System.Collections.Generic.List(Of MCB04000Back.MCB04000UntransferedReportDto), poReport1 As System.Collections.Generic.List(Of MCB04000Back.MCB04000OutstandingReportDto)) Implements IMCB04000StreamingService.Dummy

    End Sub
End Class

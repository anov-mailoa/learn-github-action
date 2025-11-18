' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00050StreamingService" in code, svc and config file together.

Imports R_BackEnd
Imports R_Common
Imports ATT00050Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class ATT00050StreamingService
    Implements IATT00050StreamingService

    Public Function getTransaction() As System.ServiceModel.Channels.Message Implements IATT00050StreamingService.getTransaction

        Dim loRtn As New List(Of ATT00050GridStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00050CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATT00050GridDTO


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getTransaction(poParam)
            loRtnMessage = R_StreamUtility(Of ATT00050GridStreamingDTO).WriteToMessage(loRtn.AsEnumerable, "TransactionData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getTransactionHistory() As System.ServiceModel.Channels.Message Implements IATT00050StreamingService.getTransactionHistory

        Dim loRtn As New List(Of ATT00050GridStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00050CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATT00050GridDTO


        Try

            poParam.cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getTransactionHistory(poParam)
            loRtnMessage = R_StreamUtility(Of ATT00050GridStreamingDTO).WriteToMessage(loRtn.AsEnumerable, "TransactionHistoryData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getOutstandingReport() As System.ServiceModel.Channels.Message Implements IATT00050StreamingService.getOutstandingReport

        Dim loRtn As New List(Of ATT00050GridStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00050CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATT00050GridDTO


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getOutstandingReport(poParam)
            loRtnMessage = R_StreamUtility(Of ATT00050GridStreamingDTO).WriteToMessage(loRtn.AsEnumerable, "OutstandingReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Sub Dummy(ByVal poParATT00050 As System.Collections.Generic.List(Of ATT00050Back.ATT00050GridStreamingDTO), ByVal poParATT00051 As System.Collections.Generic.List(Of ATT00050Back.ATT00050GridDTO), ByVal poParATT00052 As System.Collections.Generic.List(Of ATT00050Back.COMBOBOXDTO)) Implements IATT00050StreamingService.Dummy

    End Sub

    Public Function getOutstandingReportView() As System.ServiceModel.Channels.Message Implements IATT00050StreamingService.getOutstandingReportView
        Dim loRtn As New List(Of ATT00050GridStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00050CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATT00050GridDTO


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            loRtn = loCls.getOutstandingReportView(poParam)
            loRtnMessage = R_StreamUtility(Of ATT00050GridStreamingDTO).WriteToMessage(loRtn.AsEnumerable, "getOutstandingReportView")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class

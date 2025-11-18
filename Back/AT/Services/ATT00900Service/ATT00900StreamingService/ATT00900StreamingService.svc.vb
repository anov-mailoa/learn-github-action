Imports R_BackEnd
Imports R_Common
Imports ATT00900Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00900StreamingService" in code, svc and config file together.
Public Class ATT00900StreamingService
    Implements IATT00900StreamingService

    Public Function getAnalysis() As System.ServiceModel.Channels.Message Implements IATT00900StreamingService.getAnalysis
        Dim loException As New R_Exception
        Dim loCls As New ATT00900Cls
        Dim loRtn As New List(Of ATT00900StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATT00900DTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getAnalysis(poParam)
            loRtnMessage = R_StreamUtility(Of ATT00900StreamingDTO).WriteToMessage(loRtn.AsEnumerable, "AnalysisData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getSummary() As System.ServiceModel.Channels.Message Implements IATT00900StreamingService.getSummary
        Dim loException As New R_Exception
        Dim loCls As New ATT00901Cls
        Dim loRtn As New List(Of ATT00901StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATT00901DTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            loRtn = loCls.getSummary(poParam)
            loRtnMessage = R_StreamUtility(Of ATT00901StreamingDTO).WriteToMessage(loRtn.AsEnumerable, "SummaryData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IATT00900StreamingService.getHistory
        Dim loException As New R_Exception
        Dim loCls As New ATT00900Cls
        Dim loRtn As New List(Of ATT00910StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATT00900DTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            poParam.lchkCanceled = R_Utility.R_GetStreamingContext("lchkCanceled")
            poParam.lchkClosed = R_Utility.R_GetStreamingContext("lchkClosed")
            poParam.lchkDeleted = R_Utility.R_GetStreamingContext("lchkDeleted")

            loRtn = loCls.getHistory(poParam)
            loRtnMessage = R_StreamUtility(Of ATT00910StreamingDTO).WriteToMessage(loRtn.AsEnumerable, "HistoryData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of ATT00900Back.ATT00900StreamingDTO), poParATT00901 As System.Collections.Generic.List(Of ATT00900Back.ATT00901StreamingDTO), poParATT00910 As System.Collections.Generic.List(Of ATT00900Back.ATT00910StreamingDTO)) Implements IATT00900StreamingService.Dummy

    End Sub
End Class

Imports R_Common
Imports R_BackEnd
Imports LNT00600Back
Imports System.ServiceModel.Channels
Imports LNT00600Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00600StreamingService" in code, svc and config file together.
Public Class LNT00600StreamingService
    Implements ILNT00600StreamingService

    Public Function getExpenseList() As System.ServiceModel.Channels.Message Implements ILNT00600StreamingService.getExpenseList
        Dim loRtn As New List(Of LNT00600Dto_Expense_S)
        Dim loRtnMessage As Message
        Dim loCls As New LNT00600Cls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00600Dto


        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cCurrencyCode = R_Utility.R_GetStreamingContext("cCurrencyCode")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
            End With
            loRtn = loCls.getExpenseList(poParam)
            loRtnMessage = R_StreamUtility(Of LNT00600Dto_Expense_S).WriteToMessage(loRtn.AsEnumerable, "getExpense")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getTransaction() As System.ServiceModel.Channels.Message Implements ILNT00600StreamingService.getTransaction
        Dim loRtn As New List(Of LNT00600Dto_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNT00600Cls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00600Dto
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmpID")
            poParam.cKey = R_Utility.R_GetStreamingContext("cKeyID")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            loRtn = loCls.getTransaction(poParam)
            loList = R_Utility.R_GetChunkData(Of LNT00600Dto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getTransacationDoc() As System.ServiceModel.Channels.Message Implements ILNT00600StreamingService.getTransacationDoc
        Dim loRtn As New List(Of LNT00600ListDocDto_S)
        Dim loRtnMessage As Message
        Dim loCls As New LNT00600Cls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00600Dto

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With
            loRtn = loCls.getTransacationDoc(poParam)
            loRtnMessage = R_StreamUtility(Of LNT00600ListDocDto_S).WriteToMessage(loRtn.AsEnumerable, "getTransacationDoc")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNT00600Back.LNT00600Dto_R), poListExpense As System.Collections.Generic.List(Of LNT00600Back.LNT00600Dto_Expense_R), poListExpense_S As System.Collections.Generic.List(Of LNT00600Back.LNT00600Dto_Expense_S), poSchedule As LNT00600Back.LNT00600ScheduleDto, poScheduleList As System.Collections.Generic.List(Of LNT00600Back.LNT00600ScheduleDto_S), poLisDocDto_R As System.Collections.Generic.List(Of LNT00600Back.LNT00600ListDocDto_R), poLisDocDto_S As System.Collections.Generic.List(Of LNT00600Back.LNT00600ListDocDto_S)) Implements ILNT00600StreamingService.Dummy

    End Sub
End Class

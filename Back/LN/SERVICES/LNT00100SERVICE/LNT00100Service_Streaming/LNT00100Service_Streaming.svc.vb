Imports R_Common
Imports R_BackEnd
Imports LNT00100Back
Imports System.ServiceModel.Channels
Imports LNT00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00100Service_Streaming" in code, svc and config file together.
Public Class LNT00100Service_Streaming
    Implements ILNT00100Service_Streaming

    Public Function getTransaction() As System.ServiceModel.Channels.Message Implements ILNT00100Service_Streaming.getTransaction
        Dim loRtn As New List(Of LNT00100Dto_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNT00100Cls
        Dim loEx As New R_Exception
        Dim poParam As String
        Dim pcEmpID As String
        Dim pcKeyID As String
        Dim pcUserId As String
        Dim pcLangId As String
        Dim pcReferenceNo As String
        Dim loList As List(Of Byte())

        Try
            poParam = R_Utility.R_GetStreamingContext("cCompanyId")
            pcEmpID = R_Utility.R_GetStreamingContext("cEmpID")
            pcKeyID = R_Utility.R_GetStreamingContext("cKeyID")
            pcUserId = R_Utility.R_GetStreamingContext("cUserId")
            pcLangId = R_Utility.R_GetStreamingContext("cLanguageId")
            pcReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")

            loRtn = loCls.getTransaction(poParam, pcEmpID, pcKeyID, pcUserId, pcLangId, pcReferenceNo)

            loList = R_Utility.R_GetChunkData(Of LNT00100Dto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransaction")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getExpenseList() As System.ServiceModel.Channels.Message Implements ILNT00100Service_Streaming.getExpenseList
        Dim loRtn As New List(Of LNT00100Dto_Expense_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNT00100Cls_Expense
        Dim loEx As New R_Exception
        Dim poParam As New LNT00100Dto
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
            End With
            loRtn = loCls.getExpenseList(poParam)
            loList = R_Utility.R_GetChunkData(Of LNT00100Dto_Expense_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExpense")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getTransacationDoc() As System.ServiceModel.Channels.Message Implements ILNT00100Service_Streaming.getTransacationDoc
        Dim loRtn As New List(Of LNT00100ListDocDto_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNT00100DocumentCls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00100DocDTO
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With
            loRtn = loCls.getTransacationDoc(poParam)
            loList = R_Utility.R_GetChunkData(Of LNT00100ListDocDto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransacationDoc")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function RSP_Installment_Schedule() As System.ServiceModel.Channels.Message Implements ILNT00100Service_Streaming.RSP_Installment_Schedule
        Dim loException As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtnTemp As List(Of RSP_Installment_ScheduleDTO)
        Dim loRtn As Message
        Dim loParam As New LNT00100Dto
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cRefNo")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKey = R_Utility.R_GetStreamingContext("cKeyId")
                .cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
                .nPrincipal = R_Utility.R_GetStreamingContext("nPrincipal")
                .iCalcInstallBy = R_Utility.R_GetStreamingContext("iCalcInstallBy")
                .iTenor = R_Utility.R_GetStreamingContext("iTenor")
                .nBasicInstallment = R_Utility.R_GetStreamingContext("nBasicInstallment")
                .iInterval = R_Utility.R_GetStreamingContext("iInterval")
                .nInterestRate = R_Utility.R_GetStreamingContext("nInterestRate")
                .nInterest = R_Utility.R_GetStreamingContext("nInterest")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cAction = R_Utility.R_GetStreamingContext("cAction")
                .cOriginalReference = R_Utility.R_GetStreamingContext("cOriginalReference")
                .cInterestType = R_Utility.R_GetStreamingContext("cInterestType")
            End With

            LNT00100LogCLS.Log.Info("Service 1")
            loRtnTemp = loCls.RSP_Installment_Schedule(loParam)
            LNT00100LogCLS.Log.Info("Service 2")
            loList = R_Utility.R_GetChunkData(Of RSP_Installment_ScheduleDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            LNT00100LogCLS.Log.Info("Service 3")
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_Installment_Schedule")
            LNT00100LogCLS.Log.Info("Service 4")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNT00100Back.LNT00100Dto_R), poListSchedule As System.Collections.Generic.List(Of LNT00100Back.LNT00100_ScheduleDTO), poLisDocDto_R As System.Collections.Generic.List(Of LNT00100Back.LNT00100ListDocDto_R)) Implements ILNT00100Service_Streaming.Dummy

    End Sub

    Public Function getErrorData() As System.ServiceModel.Channels.Message Implements ILNT00100Service_Streaming.getErrorData
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtnList As New List(Of LNT00100ErrorDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New LNT00100Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtnList = loCls.getErrorData(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LNT00100ErrorDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getErrorData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

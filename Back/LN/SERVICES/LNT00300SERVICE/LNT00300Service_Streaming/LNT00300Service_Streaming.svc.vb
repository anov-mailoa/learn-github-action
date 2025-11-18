Imports R_Common
Imports R_BackEnd
Imports LNT00300Back
Imports System.ServiceModel.Channels
Imports LNT00300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00300Service_Streaming" in code, svc and config file together.
Public Class LNT00300Service_Streaming
    Implements ILNT00300Service_Streaming

    Public Function getTransaction() As System.ServiceModel.Channels.Message Implements ILNT00300Service_Streaming.getTransaction
        Dim loRtn As New List(Of LNT00300Dto_S)
        Dim loRtnMessage As Message
        Dim loCls As New LNT00300Cls
        Dim poParam As New LNT00300Dto
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmpID")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cKey = R_Utility.R_GetStreamingContext("cKeyID")
            loRtn = loCls.getTransaction(poParam)
            loList = R_Utility.R_GetChunkData(Of LNT00300Dto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function RSP_Installment_Schedule() As System.ServiceModel.Channels.Message Implements ILNT00300Service_Streaming.RSP_Installment_Schedule
        Dim loException As New R_Exception
        Dim loCls As New LNT00300Cls
        Dim loRtnTemp As List(Of RSP_Installment_ScheduleDTO)
        Dim loRtn As Message
        Dim loParam As New LNT00300Dto
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

            loRtnTemp = loCls.RSP_Installment_Schedule(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_Installment_ScheduleDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_Installment_Schedule")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNT00300Back.LNT00300Dto_R), poListSchedule As System.Collections.Generic.List(Of LNT00300Back.LNT00300DtoSchedule_R)) Implements ILNT00300Service_Streaming.Dummy

    End Sub
End Class

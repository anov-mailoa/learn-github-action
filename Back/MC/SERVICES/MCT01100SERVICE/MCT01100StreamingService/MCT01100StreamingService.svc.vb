' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT01100StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCT01100Back
Imports MCT01100Common

Public Class MCT01100StreamingService
    Implements IMCT01100StreamingService

    Public Function getCashPaymentList() As System.ServiceModel.Channels.Message Implements IMCT01100StreamingService.getCashPaymentList
        Dim loCls As New MCT01100CLS
        Dim loRtnList As List(Of MCT01100CastPaymentListGridStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT01100DTO
        Dim loList As List(Of Byte())
        Dim loEx As New R_Exception

        Try
            With poParam
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnList = loCls.getCashPaymentList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCT01100CastPaymentListGridStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCashPaymentList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCashPaymentDetail() As System.ServiceModel.Channels.Message Implements IMCT01100StreamingService.getCashPaymentDetail
        Dim loCls As New MCT01100CLS
        Dim loRtnList As List(Of MCT01100CashPaymentDetailGridStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim poParam As New MCT01100DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnList = loCls.getCashPaymentDetail(poParam)
            loList = R_Utility.R_GetChunkData(Of MCT01100CashPaymentDetailGridStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCashPaymentDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCashPaymentSummary() As System.ServiceModel.Channels.Message Implements IMCT01100StreamingService.getCashPaymentSummary
        Dim loCls As New MCT01100CLS
        Dim loRtnList As List(Of MCT01100CashPaymentSummaryGridStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT01100DTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnList = loCls.getCashPaymentSummary(poParam)
            loList = R_Utility.R_GetChunkData(Of MCT01100CashPaymentSummaryGridStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCashPaymentSummary")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of MCT01100Back.MCT01100CastPaymentListGridDTO), poPar2 As System.Collections.Generic.List(Of MCT01100Back.MCT01100CashPaymentDetailGridDTO), poPar4 As System.Collections.Generic.List(Of MCT01100Back.MCT01100CashPaymentSummaryGridDTO)) Implements IMCT01100StreamingService.Dummy

    End Sub
End Class

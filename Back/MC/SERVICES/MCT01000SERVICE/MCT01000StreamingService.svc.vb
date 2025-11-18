Imports System.ServiceModel.Channels
Imports R_Common
Imports MCT01000Back
Imports MCT01000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT01000StreamingService" in code, svc and config file together.
Public Class MCT01000StreamingService
    Implements IMCT01000StreamingService

    Public Function getMctPaymentDt() As System.ServiceModel.Channels.Message Implements IMCT01000StreamingService.getMctPaymentDt
        Dim loCls As New MCT01000Cls
        Dim loRtnList As New List(Of MCT01000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT01000GridDtDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnList = loCls.getMctPaymentDt(poParam)

            loList = R_Utility.R_GetChunkData(Of MCT01000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getMctPaymentDt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMctPaymentSum() As System.ServiceModel.Channels.Message Implements IMCT01000StreamingService.getMctPaymentSum
        Dim loCls As New MCT01000Cls
        Dim loRtnList As New List(Of MCT01000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT01000GridSumDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnList = loCls.getMctPaymentSum(poParam)

            loList = R_Utility.R_GetChunkData(Of MCT01000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getMctPaymentSum")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMctPaymentHd() As System.ServiceModel.Channels.Message Implements IMCT01000StreamingService.getMctPaymentHd
        Dim loCls As New MCT01000Cls
        Dim loRtnList As New List(Of MCT01000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT01000GridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getMctPaymentHd(poParam)

            loList = R_Utility.R_GetChunkData(Of MCT01000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getMctPaymentHd")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of MCT01000Back.MCT01000GridDTO), poPar As System.Collections.Generic.List(Of MCT01000Back.MCT01000GridDtDTO), poPara As System.Collections.Generic.List(Of MCT01000Back.MCT01000GridSumDTO)) Implements IMCT01000StreamingService.Dummy

    End Sub
End Class

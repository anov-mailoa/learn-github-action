Imports System.ServiceModel
Imports R_Common
Imports LNI00200Back
Imports System.ServiceModel.Channels
Imports LNI00200Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNI00200StreamingService" in code, svc and config file together.
Public Class LNI00200StreamingService
    Implements ILNI00200StreamingService

    Public Function getRSP_LN_OUTSTANDING_TRANSACTION() As System.ServiceModel.Channels.Message Implements ILNI00200StreamingService.getRSP_LN_OUTSTANDING_TRANSACTION
        Dim loException As New R_Exception
        Dim loCls As New LNI00200Cls
        Dim loRtnTemp As List(Of RSP_LN_OUTSTANDING_TRANSACTION_DTO)
        Dim loRtn As Message
        Dim pcCoId, pcFilterBy, pcFilterValue, pcCultureUI As String
        Dim loList As List(Of Byte())

        Try
            pcCoId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcFilterBy = R_Utility.R_GetStreamingContext("cFilterBy")
            pcFilterValue = R_Utility.R_GetStreamingContext("cFilterValue")
            pcCultureUI = R_Utility.R_GetStreamingContext("cCultureUI")
            loRtnTemp = loCls.getRSP_LN_OUTSTANDING_TRANSACTION(pcCoId, pcFilterBy, pcFilterValue, pcCultureUI)
            loList = R_Utility.R_GetChunkData(Of RSP_LN_OUTSTANDING_TRANSACTION_DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRSP_LN_OUTSTANDING_TRANSACTION")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getTransactionCombo() As System.ServiceModel.Channels.Message Implements ILNI00200StreamingService.getTransactionCombo
        Dim loException As New R_Exception
        Dim loCls As New LNI00200Cls
        Dim loRtnTemp As List(Of ComboBoxDto)
        Dim loRtn As Message
        Dim pcCoId As String
        Dim loList As List(Of Byte())

        Try
            pcCoId = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtnTemp = loCls.getTransactionCombo(pcCoId)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransactionCombo")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

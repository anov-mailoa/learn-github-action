Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCB02000Back
Imports MCB02000Common

Public Class MCB02000StreamingService
    Implements IMCB02000StreamingService

    Public Function getTransferBankDocumentList() As System.ServiceModel.Channels.Message Implements IMCB02000StreamingService.getTransferBankDocumentList
        Dim loEx As New R_Exception
        Dim loParam As New MCB02000TransferBankDetailDto
        Dim loCls As New MCB02000GenerateTransferFileCls
        Dim loRtn As List(Of MCB02000StreamingDto)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            loParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            loParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")


            loRtn = loCls.getTransferBankDocumentList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB02000StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransferBankDocumentList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getGenerateFile() As System.ServiceModel.Channels.Message Implements IMCB02000StreamingService.getGenerateFile
        Dim loEx As New R_Exception
        Dim loParam As New MCB02000TransferBankDocumentDto
        Dim loCls As New MCB02000GenerateTransferFileCls
        Dim loRtn As List(Of GenerateTransferFileDto)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            loParam.cCutOffDate = R_Utility.R_GetStreamingContext("cCutOffDate")
            loParam.cBankCode = R_Utility.R_GetStreamingContext("cBankCode")
            loParam.cBankAccountNo = R_Utility.R_GetStreamingContext("cBankAccountNo")
            loParam.cTemplateCode = R_Utility.R_GetStreamingContext("cTemplateCode")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cEncKey = R_Utility.R_GetStreamingContext("cEncKey")

            loRtn = loCls.getGenerateFile(loParam)
            loList = R_Utility.R_GetChunkData(Of GenerateTransferFileDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGenerateFile")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getRSPBANKTRANSFERCLAIMTITLE() As System.ServiceModel.Channels.Message Implements IMCB02000StreamingService.getRSPBANKTRANSFERCLAIMTITLE
        Dim loEx As New R_Exception
        Dim loParam As New GenerateTransferFileTitleDto
        Dim loCls As New MCB02000GenerateTransferFileCls
        Dim loRtn As New List(Of GenerateTransferFileTitleDto)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cBankCode = R_Utility.R_GetStreamingContext("cBankCode")
            loParam.cBankAccountNo = R_Utility.R_GetStreamingContext("cBankAccountNo")

            loRtn = loCls.getRSPBANKTRANSFERCLAIMTITLE(loParam)
            loList = R_Utility.R_GetChunkData(Of GenerateTransferFileTitleDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRSPBANKTRANSFERCLAIMTITLE")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getFileExtension() As System.ServiceModel.Channels.Message Implements IMCB02000StreamingService.getFileExtension
        Dim loEx As New R_Exception
        Dim loParam As String
        Dim loCls As New MCB02000GenerateTransferFileCls
        Dim loRtn As New List(Of CmbFileTemplate)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())
        Try
            loParam = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.getFileExtension(loParam)
            loList = R_Utility.R_GetChunkData(Of CmbFileTemplate)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getFileExtension")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Sub Dummy(poParGrid As System.Collections.Generic.List(Of MCB02000Back.MCB02000TransferBankDetailDto)) Implements IMCB02000StreamingService.Dummy

    End Sub

End Class

Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCB01100Back
Imports MCB01100Common

Public Class MCB01100StreamingService
    Implements IMCB01100StreamingService

    Public Function getMainLimitList() As System.ServiceModel.Channels.Message Implements IMCB01100StreamingService.getMainLimitList
        Dim loEx As New R_Exception
        Dim loParam As New MCB01100MainLimitDto
        Dim loCls As New MCB01100MainLimitCls
        Dim loRtn As List(Of MCB01100StreamingDto)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())
        Try
            loParam.cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cYear = R_Utility.R_GetStreamingContext("cYear")

            loRtn = loCls.getMainLimitList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB01100StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMainLimitList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getMedicalItemLimitList() As System.ServiceModel.Channels.Message Implements IMCB01100StreamingService.getMedicalItemLimitList
        Dim loEx As New R_Exception
        Dim loParam As New MCB01100MedicalItemLimitDto
        Dim loCls As New MCB01100MedicalItemLimitCls
        Dim loRtn As List(Of MCB01100StreamingDto)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())

        Try
            loParam.cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")

            loRtn = loCls.getMedicalItemLimitList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB01100StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMedicalItemLimitList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getRemainingLimit() As System.ServiceModel.Channels.Message Implements IMCB01100StreamingService.getRemainingLimit
        Dim loCls As New MCB01100MainLimitCls
        Dim loRtnList As New List(Of MCB01100StreamingDto)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCB01100MainLimitDto
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncryptKey")
            End With

            loRtnList = loCls.getRemainingLimit(poParam)
            loList = R_Utility.R_GetChunkData(Of MCB01100StreamingDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getRemainingLimit")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getRemainingLimitItem() As System.ServiceModel.Channels.Message Implements IMCB01100StreamingService.getRemainingLimitItem
        Dim loCls As New MCB01100MedicalItemLimitCls
        Dim loRtnList As New List(Of MCB01100StreamingDto)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCB01100MedicalItemLimitDto
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncryptKey")
            End With

            loRtnList = loCls.getRemainingLimitItem(poParam)
            loList = R_Utility.R_GetChunkData(Of MCB01100StreamingDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getRemainingLimitItem")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getErrorData() As System.ServiceModel.Channels.Message Implements IMCB01100StreamingService.getErrorData
        Dim loEx As New R_Exception
        Dim loCls As New MCB01100UploadCls
        Dim loRtnList As New List(Of MCB01100MainLimitExcelDto)
        Dim loRtn As Message = Nothing
        Dim loParam As New MCB01100MainLimitDto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtnList = loCls.getErrorData(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of MCB01100MainLimitExcelDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getErrorData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

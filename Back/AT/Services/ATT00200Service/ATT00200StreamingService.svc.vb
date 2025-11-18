Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00200Back
Imports ATT00200Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00200StreamingService" in code, svc and config file together.
Public Class ATT00200StreamingService
    Implements IATT00200StreamingService

    Public Function getPermission() As System.ServiceModel.Channels.Message Implements IATT00200StreamingService.getPermission
        Dim loRtn As New List(Of ATT00200StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00200Cls
        Dim loEx As New R_Exception
        Dim pcCompId, pcUserId, pcLangId As String
        Dim loChunk As New List(Of Byte())


        Try

            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcUserId = R_Utility.R_GetStreamingContext("cUserId")
            pcLangId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getPermission(pcCompId, pcUserId, pcLangId)
            loChunk = R_Utility.R_GetChunkData(Of ATT00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getPermission")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage


    End Function

    Public Function getReason() As System.ServiceModel.Channels.Message Implements IATT00200StreamingService.getReason
        Dim loRtn As New List(Of CmbDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00200Cls
        Dim loEx As New R_Exception
        Dim pcCompId, pcUserId, pcLangId As String
        Dim loChunk As New List(Of Byte())


        Try

            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtn = loCls.getReason(pcCompId)
            loChunk = R_Utility.R_GetChunkData(Of CmbDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getReason")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IATT00200StreamingService.getHistory
        Dim loRtn As New List(Of ATT00200StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00200Cls
        Dim loEx As New R_Exception
        Dim loParam As New ATT00200DTO
        Dim loChunk As New List(Of Byte())


        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loParam.cReferencePeriod = R_Utility.R_GetStreamingContext("cReferencePeriod")
            loRtn = loCls.getHistory(loParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class

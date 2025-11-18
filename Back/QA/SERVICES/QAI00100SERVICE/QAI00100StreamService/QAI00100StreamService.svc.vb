Imports R_BackEnd
Imports R_Common
Imports QAI00100Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports QAI00100Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAI00100StreamService" in code, svc and config file together.
Public Class QAI00100StreamService
    Implements IQAI00100StreamService

    Public Function getListGridDocument() As System.ServiceModel.Channels.Message Implements IQAI00100StreamService.getListGridDocument
        Dim loException As New R_Exception
        Dim loCls As New QAI00100CLS
        Dim loRtn As New List(Of QAI00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAI00100DTO
        Dim loChunk As New List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cDocLevel = R_Utility.R_GetStreamingContext("cDocLevel")
            poParam.cDocStatus = R_Utility.R_GetStreamingContext("cDocStatus")

            loRtn = loCls.getListGridDocument(poParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getListGridDocument")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListRelatedDocument() As System.ServiceModel.Channels.Message Implements IQAI00100StreamService.getListRelatedDocument
        Dim loException As New R_Exception
        Dim loCls As New QAI00100CLS
        Dim loRtn As New List(Of QAI00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAI00100DTO
        Dim loChunk As New List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            poParam.cDocNo = R_Utility.R_GetStreamingContext("cDocNo")

            loRtn = loCls.getListRelatedDocument(poParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getListRelatedDocument")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class

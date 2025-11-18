Imports R_BackEnd
Imports R_Common
Imports QAM00300Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports QAM00300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00300StreamingService" in code, svc and config file together.
Public Class QAM00300StreamingService
    Implements IQAM00300StreamingService

    Public Function getListGrid() As System.ServiceModel.Channels.Message Implements IQAM00300StreamingService.getListGrid
        Dim loException As New R_Exception
        Dim loCls As New QAM00300CLS
        Dim loRtn As New List(Of QAM00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAM00300DTO
        Dim loChunk As New List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")

            loRtn = loCls.getListGrid(poParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getListGrid")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class

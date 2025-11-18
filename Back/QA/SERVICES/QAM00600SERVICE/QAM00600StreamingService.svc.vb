Imports R_BackEnd
Imports R_Common
Imports QAM00600Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports QAM00600Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00600StreamingService" in code, svc and config file together.
Public Class QAM00600StreamingService
    Implements IQAM00600StreamingService

    Public Function getLoadGrid() As System.ServiceModel.Channels.Message Implements IQAM00600StreamingService.getLoadGrid
        Dim loException As New R_Exception
        Dim loCls As New QAM00600CLS
        Dim loRtn As New List(Of QAM00600StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAM00600DTO
        Dim loChunk As New List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")

            loRtn = loCls.getLoadGrid(poParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM00600StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getLoadGrid")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class

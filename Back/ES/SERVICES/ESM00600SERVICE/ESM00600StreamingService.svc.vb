Imports System.ServiceModel
Imports R_Common
Imports ESM00600Back
Imports ESM00600Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00600StreamingService" in code, svc and config file together.
Public Class ESM00600StreamingService
    Implements IESM00600StreamingService

    Public Function getList() As System.ServiceModel.Channels.Message Implements IESM00600StreamingService.getList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00600CLS
        Dim loRtn As New List(Of ESM00600StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ESM00600DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtn = loCls.getList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM00600StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class

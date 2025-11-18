Imports R_Common
Imports ESM00500Back
Imports ESM00500Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00500StreamingService" in code, svc and config file together.
Public Class ESM00500StreamingService
    Implements IESM00500StreamingService

    Public Function getListNews() As System.ServiceModel.Channels.Message Implements IESM00500StreamingService.getListNews
        Dim loEx As New R_Exception
        Dim loCls As New ESM00500Cls
        Dim loRtnTemp As List(Of ESM00500StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM00500ParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam

                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            End With

            loRtnTemp = loCls.getListNews(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM00500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListNews")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function


    Public Function getListAttachment() As System.ServiceModel.Channels.Message Implements IESM00500StreamingService.getListAttachment
        Dim loEx As New R_Exception
        Dim loCls As New ESM00500Cls
        Dim loRtnTemp As New List(Of ESM00500AttachmentDTO)
        Dim loRtn As Message
        Dim loParam As New ESM00500ParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CNEWS_ID = R_Utility.R_GetStreamingContext("CNEWS_ID")
            End With

            loRtnTemp = loCls.getListAttachment(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM00500AttachmentDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListAttachment")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

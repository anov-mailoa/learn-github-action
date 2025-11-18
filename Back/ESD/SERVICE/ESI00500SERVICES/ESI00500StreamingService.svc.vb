Imports R_Common
Imports ESI00500Back
Imports ESI00500Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESI00500StreamingService" in code, svc and config file together.
Public Class ESI00500StreamingService
    Implements IESI00500StreamingService

    Public Function getNewsList() As System.ServiceModel.Channels.Message Implements IESI00500StreamingService.getNewsList
        Dim loEx As New R_Exception
        Dim loCls As New ESI00500CLS
        Dim loRtnTemp As List(Of ESI00500StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.getNewsList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESI00500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getNewsList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getNewsDetail() As System.ServiceModel.Channels.Message Implements IESI00500StreamingService.getNewsDetail
        Dim loEx As New R_Exception
        Dim loCls As New ESI00500CLS
        Dim loRtnTemp As List(Of ESI00500StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CNEWS_ID = R_Utility.R_GetStreamingContext("CNEWS_ID")
            End With

            loRtnTemp = loCls.getNewsDetail(loParam)

            loList = R_Utility.R_GetChunkData(Of ESI00500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getNewsDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListAttachment() As System.ServiceModel.Channels.Message Implements IESI00500StreamingService.getListAttachment
        Dim loEx As New R_Exception
        Dim loCls As New ESI00500CLS
        Dim loRtnTemp As List(Of ESI00500StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CNEWS_ID = R_Utility.R_GetStreamingContext("CNEWS_ID")
            End With

            loRtnTemp = loCls.getListAttachment(loParam)

            loList = R_Utility.R_GetChunkData(Of ESI00500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListAttachment")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

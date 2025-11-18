Imports R_Common
Imports ESI00100Back
Imports ESI00100Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESI00100StreamingService" in code, svc and config file together.
Public Class ESI00100StreamingService
    Implements IESI00100StreamingService

    Public Function getListNotification() As System.ServiceModel.Channels.Message Implements IESI00100StreamingService.getListNotification
        Dim loEx As New R_Exception
        Dim loCls As New ESI00100CLS
        Dim loRtnTemp As List(Of ESI00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESI00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnTemp = loCls.getListNotification(loParam)

            loList = R_Utility.R_GetChunkData(Of ESI00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListNotification")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getNewsList() As System.ServiceModel.Channels.Message Implements IESI00100StreamingService.getNewsList
        Dim loEx As New R_Exception
        Dim loCls As New ESI00100CLS
        Dim loRtnTemp As List(Of ESI00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESI00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.getNewsList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESI00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getNewsList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

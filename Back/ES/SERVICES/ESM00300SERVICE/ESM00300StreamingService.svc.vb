Imports System.ServiceModel
Imports R_Common
Imports ESM00300Back
Imports ESM00300Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00300StreamingService" in code, svc and config file together.
Public Class ESM00300StreamingService
    Implements IESM00300StreamingService

    Public Function getChkCmbData() As System.ServiceModel.Channels.Message Implements IESM00300StreamingService.getChkCmbData
        Dim loEx As New R_Exception
        Dim loCls As New ESM00300CLS
        Dim loRtn As New List(Of ESM00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ESM00300DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CTYPE_LIST = R_Utility.R_GetStreamingContext("CTYPE_LIST")
            End With

            loRtn = loCls.getChkCmbData(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getChkCmbData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getList() As System.ServiceModel.Channels.Message Implements IESM00300StreamingService.getList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00300CLS
        Dim loRtn As New List(Of ESM00300StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ESM00300DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CTYPE_LIST = R_Utility.R_GetStreamingContext("CTYPE_LIST")
                .CORG_LEVEL_LIST = R_Utility.R_GetStreamingContext("CORG_LEVEL_LIST")
                .CDEPT_LIST = R_Utility.R_GetStreamingContext("CDEPT_LIST")
                .CJOB_TITLE_LIST = R_Utility.R_GetStreamingContext("CJOB_TITLE_LIST")
                .CROLE_CODE = R_Utility.R_GetStreamingContext("CROLE_CODE")
            End With

            loRtn = loCls.getList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class

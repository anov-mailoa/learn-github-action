Imports System.ServiceModel
Imports R_Common
Imports ESM00400Back
Imports ESM00400Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00400StreamingService" in code, svc and config file together.
Public Class ESM00400StreamingService
    Implements IESM00400StreamingService

    Public Function getChkCmbData() As System.ServiceModel.Channels.Message Implements IESM00400StreamingService.getChkCmbData
        Dim loEx As New R_Exception
        Dim loCls As New ESM00400CLS
        Dim loRtn As New List(Of ESM00400StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ESM00400DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CTYPE_LIST = R_Utility.R_GetStreamingContext("CTYPE_LIST")
            End With

            loRtn = loCls.getChkCmbData(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM00400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getChkCmbData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getList() As System.ServiceModel.Channels.Message Implements IESM00400StreamingService.getList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00400CLS
        Dim loRtn As New List(Of ESM00400StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ESM00400DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CTYPE_LIST = R_Utility.R_GetStreamingContext("CTYPE_LIST")
                .CLOC_LIST = R_Utility.R_GetStreamingContext("CLOC_LIST")
                .CDEPT_LIST = R_Utility.R_GetStreamingContext("CDEPT_LIST")
                .CJOB_LIST = R_Utility.R_GetStreamingContext("CJOB_LIST")
                .CPOS_LIST = R_Utility.R_GetStreamingContext("CPOS_LIST")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtn = loCls.getList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM00400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListEmpAttLocation() As System.ServiceModel.Channels.Message Implements IESM00400StreamingService.getListEmpAttLocation
        Dim loEx As New R_Exception
        Dim loCls As New ESM00400CLS
        Dim loRtn As New List(Of ESM00400StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ESM00400DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtn = loCls.getListEmpAttLocation(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM00400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListEmpAttLocation")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListESSAttLocation() As System.ServiceModel.Channels.Message Implements IESM00400StreamingService.getListESSAttLocation
         Dim loEx As New R_Exception
        Dim loCls As New ESM00400CLS
        Dim loRtn As New List(Of ESM00400StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ESM00400DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtn = loCls.getListESSAttLocation(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM00400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListESSAttLocation")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class

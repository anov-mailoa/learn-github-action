Imports System.ServiceModel
Imports R_Common
Imports ESM00200Back
Imports ESM00200Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00200StreamingService" in code, svc and config file together.
Public Class ESM00200StreamingService
    Implements IESM00200StreamingService

    Public Function getProgramList() As System.ServiceModel.Channels.Message Implements IESM00200StreamingService.getProgramList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00200CLS
        Dim loRtn As New List(Of ESM00200StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ESM00200DTO

        Try
            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CPARENT_PROGRAM_CODE = R_Utility.R_GetStreamingContext("CPARENT_PROGRAM_CODE")

            loRtn = loCls.getProgramList(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProgramList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getReasonCodeList() As System.ServiceModel.Channels.Message Implements IESM00200StreamingService.getReasonCodeList
        Dim loEx As New R_Exception
        Dim loCls As New ESM00200ParamCLS
        Dim loRtn As New List(Of ESM00200StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ESM00200DTO

        Try
            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtn = loCls.getReasonCodeList(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReasonCodeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class

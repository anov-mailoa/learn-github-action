Imports R_BackEnd
Imports R_Common
Imports QAR01400Back
Imports QAR01400Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01400StreamingService" in code, svc and config file together.
Public Class QAR01400StreamingService
    Implements IQAR01400StreamingService

    Public Function getRetainDocument() As System.ServiceModel.Channels.Message Implements IQAR01400StreamingService.getRetainDocument
        Dim loException As New R_Exception
        Dim loCls As New QAR01400CLS
        Dim loRtn As New List(Of QAR01400StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim poParam As New QAR01400DTO
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtn = loCls.getRetainDocument(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRetainDocument")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getPrintReportTAB1() As System.ServiceModel.Channels.Message Implements IQAR01400StreamingService.getPrintReportTAB1
        Dim loException As New R_Exception
        Dim loCls As New QAR01400CLS
        Dim loRtn As New List(Of QAR01400StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR01400DTO
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            poParam.cPositionList = R_Utility.R_GetStreamingContext("cPositionList")
            poParam.cIncludeBelowpos = R_Utility.R_GetStreamingContext("cIncludeBelowpos")
            poParam.cIncludeObseletedoc = R_Utility.R_GetStreamingContext("cIncludeObseletedoc")

            loRtn = loCls.getPrintReportTAB1(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPrintReportTAB1")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class

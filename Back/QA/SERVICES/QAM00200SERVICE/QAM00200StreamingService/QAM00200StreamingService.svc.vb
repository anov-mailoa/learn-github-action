' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00200StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports R_Common
Imports QAM00200Back
Imports R_BackEnd
Imports QAM00200Common

Public Class QAM00200StreamingService
    Implements IQAM00200StreamingService

    Public Function getCmbDocumentTypeList() As System.ServiceModel.Channels.Message Implements IQAM00200StreamingService.getCmbDocumentTypeList
        Dim loCls As New QAM00200CLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAM00200DTO
        Dim loEx As New R_Exception
        Dim loChunk As New List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getCmbDocumentTypeList(poParam)

            loChunk = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(lochunk.AsEnumerable(), "getCmbDocumentTypeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDocumentTypeList() As System.ServiceModel.Channels.Message Implements IQAM00200StreamingService.getDocumentTypeList
        Dim loCls As New QAM00200CLS
        Dim loRtnList As New List(Of QAM00200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAM00200DTO
        Dim loEx As New R_Exception
        Dim loChunk As New List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .lShowInactive = R_Utility.R_GetStreamingContext("lShowInactive")
            End With

            loRtnList = loCls.getDocumentTypeList(poParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable(), "getDocumentTypeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function outstandingValidationReturn() As System.ServiceModel.Channels.Message Implements IQAM00200StreamingService.outstandingValidationReturn
        Dim loCls As New QAM00200CLS
        Dim loRtnList As New List(Of QAM00200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAM00200DTO
        Dim loEx As New R_Exception
        Dim loChunk As New List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cDocTypeCode = R_Utility.R_GetStreamingContext("cDocTypeCode")
            End With

            loRtnList = loCls.outstandingValidationReturn(poParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loRtnList.AsEnumerable(), "outstandingValidationReturn")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of QAM00200Back.QAM00200TreeDTO)) Implements IQAM00200StreamingService.Dummy

    End Sub
End Class

Imports R_BackEnd
Imports R_Common
Imports QAR01600Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports QAR01600Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01600StreamingService" in code, svc and config file together.
Public Class QAR01600StreamingService
    Implements IQAR01600StreamingService

    Public Function getComboDocOwner() As System.ServiceModel.Channels.Message Implements IQAR01600StreamingService.getComboDocOwner
        Dim loEx As New R_Exception
        Dim loCls As New QAR01600CLS
        Dim loRtn As New List(Of QAR01600StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR01600DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtn = loCls.getComboDocOwner(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01600StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(lolist.AsEnumerable, "getComboDocOwner")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getComboDocType() As System.ServiceModel.Channels.Message Implements IQAR01600StreamingService.getComboDocType
        Dim loEx As New R_Exception
        Dim loCls As New QAR01600CLS
        Dim loRtn As New List(Of QAR01600StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR01600DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")

            loRtn = loCls.getComboDocType(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01600StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getComboDocType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getPrintReport() As System.ServiceModel.Channels.Message Implements IQAR01600StreamingService.getPrintReport
        Dim loEx As New R_Exception
        Dim loCls As New QAR01600CLS
        Dim loRtn As New List(Of QAR01600StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR01600DTO
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cDocOwner = R_Utility.R_GetStreamingContext("cDocOwner")
                .iPrintBy = R_Utility.R_GetStreamingContext("iPrintBy")
                .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
                .cFilterByeEfDate = R_Utility.R_GetStreamingContext("cFilterByeEfDate")
                .cEffDateFrom = R_Utility.R_GetStreamingContext("cEffDateFrom")
                .cEffDateTo = R_Utility.R_GetStreamingContext("cEffDateTo")
                .cFilteByDocType = R_Utility.R_GetStreamingContext("cFilteByDocType")
                .cDocType = R_Utility.R_GetStreamingContext("cDocType")
                .iFilterByeEfDate = R_Utility.R_GetStreamingContext("iFilterByeEfDate")
                .iFilteByDocType = R_Utility.R_GetStreamingContext("iFilteByDocType")
                .lPrint = R_Utility.R_GetStreamingContext("lPrint")
            End With

            loRtn = loCls.getPrintReport(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01600StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPrintReport")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function


End Class

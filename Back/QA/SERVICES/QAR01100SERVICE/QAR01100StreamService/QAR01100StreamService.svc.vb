Imports R_BackEnd
Imports QAR01100Common
Imports R_Common
Imports QAR01100Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01100StreamService" in code, svc and config file together.
Public Class QAR01100StreamService
    Implements IQAR01100StreamService

    Public Function getListGrid() As System.ServiceModel.Channels.Message Implements IQAR01100StreamService.getListGrid
        Dim loException As New R_Exception
        Dim loCls As New QAR01100CLS
        Dim loRtnTemp As List(Of QAR01100StreamingDTO)
        Dim loParam As New QAR01100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
        End With

        Try
            loRtnTemp = loCls.getListGrid(loParam)
            loList = R_Utility.R_GetChunkData(Of QAR01100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGrid")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IQAR01100StreamService.getReport
        Dim loException As New R_Exception
        Dim loCls As New QAR01100CLS
        Dim loRtnTemp As List(Of RSP_QAR01100DTO)
        Dim loParam As New QAR01100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cBelowPos = R_Utility.R_GetStreamingContext("cBelowPos")
            .cPositionList = R_Utility.R_GetStreamingContext("cPositionList")
            .cIncludeAboslute = R_Utility.R_GetStreamingContext("cIncludeAboslute")
        End With

        Try
            loRtnTemp = loCls.getReport(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_QAR01100DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

 

    '===== MT20170905 ====='
    Public Function getSubReport() As System.ServiceModel.Channels.Message Implements IQAR01100StreamService.getSubReport
        Dim loException As New R_Exception
        Dim loCls As New QAR01100CLS
        Dim poParam As New QAR01100DTO
        Dim loRtnList As New List(Of QAR01100SubReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cIncludeAboslute = R_Utility.R_GetStreamingContext("cIncludeAboslute")
            End With

            loRtnList = loCls.getSubReport(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01100SubReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSubReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
    '======================'
End Class

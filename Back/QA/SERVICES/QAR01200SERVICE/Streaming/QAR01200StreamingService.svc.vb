Imports R_Common
Imports System.ServiceModel.Channels
Imports QAR01200Back
Imports R_BackEnd
Imports QAR01200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01200StreamingService" in code, svc and config file together.
Public Class QAR01200StreamingService
    Implements IQAR01200StreamingService

    Public Function getISOTypeList() As System.ServiceModel.Channels.Message Implements IQAR01200StreamingService.getISOTypeList
        Dim loException As New R_Exception
        Dim loCls As New QAR01200CLS
        Dim poParam As New QAR01200DTO
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getISOTypeList(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getISOTypeList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getISOTypeVersionList() As System.ServiceModel.Channels.Message Implements IQAR01200StreamingService.getISOTypeVersionList
        Dim loException As New R_Exception
        Dim loCls As New QAR01200CLS
        Dim poParam As New QAR01200DTO
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cISOType = R_Utility.R_GetStreamingContext("cISOType")
            End With

            loRtnList = loCls.getISOTypeVersionList(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getISOTypeVersionList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportClauseList() As System.ServiceModel.Channels.Message Implements IQAR01200StreamingService.getReportClauseList
        Dim loException As New R_Exception
        Dim loCls As New QAR01200CLS
        Dim poParam As New QAR01200DTO
        Dim loRtnList As New List(Of QAR01200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cISOType = R_Utility.R_GetStreamingContext("cISOType")
                .cISOVersion = R_Utility.R_GetStreamingContext("cISOVersion")
                .cClauseNo = R_Utility.R_GetStreamingContext("cClauseNo")
                .lIncludeDocLevel2 = R_Utility.R_GetStreamingContext("lIncludeDocLevel2")
                .lIncludeObsoleteDoc = R_Utility.R_GetStreamingContext("lIncludeObsoleteDoc")
            End With

            loRtnList = loCls.getReportClauseList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportClauseList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportDocumentList() As System.ServiceModel.Channels.Message Implements IQAR01200StreamingService.getReportDocumentList
        Dim loException As New R_Exception
        Dim loCls As New QAR01200CLS
        Dim poParam As New QAR01200DTO
        Dim loRtnList As New List(Of QAR01200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
                .lIncludeDocLevel2 = R_Utility.R_GetStreamingContext("lIncludeDocLevel2")
            End With

            loRtnList = loCls.getReportDocumentList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportDocumentList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridClauseList() As System.ServiceModel.Channels.Message Implements IQAR01200StreamingService.getGridClauseList
        Dim loException As New R_Exception
        Dim loCls As New QAR01200CLS
        Dim poParam As New QAR01200DTO
        Dim loRtnList As New List(Of QAR01200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cISOType = R_Utility.R_GetStreamingContext("cISOType")
                .cISOVersion = R_Utility.R_GetStreamingContext("cISOVersion")
            End With

            loRtnList = loCls.getGridClauseList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridClauseList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridDocumentList() As System.ServiceModel.Channels.Message Implements IQAR01200StreamingService.getGridDocumentList
        Dim loException As New R_Exception
        Dim loCls As New QAR01200CLS
        Dim poParam As New QAR01200DTO
        Dim loRtnList As New List(Of QAR01200StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lIncludeObsoleteDoc = R_Utility.R_GetStreamingContext("lIncludeObsoleteDoc")
            End With

            loRtnList = loCls.getGridDocumentList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridDocumentList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function



    Public Function getSubReportClauseList() As System.ServiceModel.Channels.Message Implements IQAR01200StreamingService.getSubReportClauseList
        Dim loException As New R_Exception
        Dim loCls As New QAR01200CLS
        Dim poParam As New QAR01200DTO
        Dim loRtnList As New List(Of QAR01200SubReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lIncludeObsoleteDoc = R_Utility.R_GetStreamingContext("lIncludeObsoleteDoc")
            End With

            loRtnList = loCls.getSubReportClauseList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01200SubReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSubReportClauseList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
        'Dim loException As New R_Exception
        'Dim loCls As New QAR01200CLS
        'Dim poParam As New QAR01200DTO
        'Dim loRtnList As New List(Of QAR01200SubReportDTO)
        'Dim loRtn As Message = Nothing

        'Try

        '    With poParam
        '        .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
        '        .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
        '        .cISOType = R_Utility.R_GetStreamingContext("cISOType")
        '        .cISOVersion = R_Utility.R_GetStreamingContext("cISOVersion")
        '        .cClauseNo = R_Utility.R_GetStreamingContext("cClauseNo")
        '        .lIncludeDocLevel2 = R_Utility.R_GetStreamingContext("lIncludeDocLevel2")
        '        .lIncludeObsoleteDoc = R_Utility.R_GetStreamingContext("lIncludeObsoleteDoc")
        '    End With

        '    loRtnList = loCls.getSubReportClauseList(poParam)

        '    loRtn = R_StreamUtility(Of QAR01200SubReportDTO).WriteToMessage(loList.AsEnumerable, "getSubReportClauseList")
        'Catch ex As Exception
        '    loException.Add(ex)
        'End Try
        'loException.ConvertAndThrowToServiceExceptionIfErrors()

        'Return loRtn
    End Function

    Public Function getSubReportDocumentList() As System.ServiceModel.Channels.Message Implements IQAR01200StreamingService.getSubReportDocumentList
        Dim loException As New R_Exception
        Dim loCls As New QAR01200CLS
        Dim poParam As New QAR01200DTO
        Dim loRtnList As New List(Of QAR01200SubReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lIncludeObsoleteDoc = R_Utility.R_GetStreamingContext("cIncludeAboslute")
            End With

            loRtnList = loCls.getSubReportDocumentList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01200SubReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSubReportDocumentList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSubReportDocumentClause() As System.ServiceModel.Channels.Message Implements IQAR01200StreamingService.getSubReportDocumentClause
        Dim loException As New R_Exception
        Dim loCls As New QAR01200CLS
        Dim poParam As New QAR01200DTO
        Dim loRtnList As New List(Of QAR01200SubReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getSubReportDocumentClause(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01200SubReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSubReportDocumentClause")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports QAR01300Back
Imports QAR01300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01300StreamingService" in code, svc and config file together.
Public Class QAR01300StreamingService
    Implements IQAR01300StreamingService

    Public Function getDocOwnerList() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getDocOwnerList
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getDocOwnerList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDocOwnerList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDocTypeList() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getDocTypeList
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getDocTypeList(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDocTypeList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportSumDocumentList() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getReportSumDocumentList
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cDocOwner = R_Utility.R_GetStreamingContext("cDocOwner")
                .lIncludeObsoleteDoc = R_Utility.R_GetStreamingContext("lIncludeObsoleteDoc")
                .lIncludeDocLevel2 = R_Utility.R_GetStreamingContext("lIncludeDocLevel2")
                .lFilterDocLevel1 = R_Utility.R_GetStreamingContext("lFilterDocLevel1")
                .cDocType = R_Utility.R_GetStreamingContext("cDocType")
                .lFilterByEffDate = R_Utility.R_GetStreamingContext("lFilterByEffDate")
                .cEffDateFrom = R_Utility.R_GetStreamingContext("cEffDateFrom")
                .cEffDateTo = R_Utility.R_GetStreamingContext("cEffDateTo")
            End With

            loRtnList = loCls.getReportSumDocumentList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportSumDocumentList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSubReportSumDocumentList() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getSubReportSumDocumentList
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300SubReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cDocOwner = R_Utility.R_GetStreamingContext("cDocOwner")
                .lIncludeObsoleteDoc = R_Utility.R_GetStreamingContext("lIncludeObsoleteDoc")
                .lIncludeDocLevel2 = R_Utility.R_GetStreamingContext("lIncludeDocLevel2")
                .lFilterDocLevel1 = R_Utility.R_GetStreamingContext("lFilterDocLevel1")
                .cDocType = R_Utility.R_GetStreamingContext("cDocType")
                .lFilterByEffDate = R_Utility.R_GetStreamingContext("lFilterByEffDate")
                .cEffDateFrom = R_Utility.R_GetStreamingContext("cEffDateFrom")
                .cEffDateTo = R_Utility.R_GetStreamingContext("cEffDateTo")
            End With

            loRtnList = loCls.getSubReportSumDocumentList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300SubReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSubReportSumDocumentList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport_CLAUSE() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getReport_CLAUSE
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300_CLAUSE_DTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
            End With

            loRtnList = loCls.getReport_CLAUSE(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300_CLAUSE_DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport_CLAUSE")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport_DOCINFO() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getReport_DOCINFO
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300_DOCINFO_DTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getReport_DOCINFO(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300_DOCINFO_DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport_DOCINFO")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport_FILING() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getReport_FILING
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300_FILING_DTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
            End With

            loRtnList = loCls.getReport_FILING(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300_FILING_DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport_FILING")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport_RELDOC() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getReport_RELDOC
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300_RELDOC_DTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getReport_RELDOC(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300_RELDOC_DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport_RELDOC")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport_RELDOCFILING() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getReport_RELDOCFILING
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300_RELDOCFILING_DTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
            End With

            loRtnList = loCls.getReport_RELDOCFILING(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300_RELDOCFILING_DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport_RELDOCFILING")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport_RELDOCRETAINER() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getReport_RELDOCRETAINER
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300_RELDOCRETAINER_DTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
            End With

            loRtnList = loCls.getReport_RELDOCRETAINER(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300_RELDOCRETAINER_DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport_RELDOCRETAINER")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport_RELPOS() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getReport_RELPOS
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300_RELPOS_DTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
            End With

            loRtnList = loCls.getReport_RELPOS(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300_RELPOS_DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport_RELPOS")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport_RETAINER() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getReport_RETAINER
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300_RETAINER_DTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
            End With

            loRtnList = loCls.getReport_RETAINER(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300_RETAINER_DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport_RETAINER")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDocList() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getDocList
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cDocOwner = R_Utility.R_GetStreamingContext("cDocOwner")
            End With

            loRtnList = loCls.getDocList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDocList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDocOwnerCombo() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getDocOwnerCombo
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getDocOwnerCombo(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()
                ).WriteToMessage(loList.AsEnumerable, "getDocOwnerCombo")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportTab2() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getReportTab2
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300Report2DTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getReportTab2(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300Report2DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportTab2")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSubReportTab2() As System.ServiceModel.Channels.Message Implements IQAR01300StreamingService.getSubReportTab2
        Dim loException As New R_Exception
        Dim loCls As New QAR01300CLS
        Dim poParam As New QAR01300DTO
        Dim loRtnList As New List(Of QAR01300SubReport2DTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cDocNoList = R_Utility.R_GetStreamingContext("cDocNoList")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getSubReportTab2(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01300SubReport2DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "QAR01300SubReport2DTO")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


End Class

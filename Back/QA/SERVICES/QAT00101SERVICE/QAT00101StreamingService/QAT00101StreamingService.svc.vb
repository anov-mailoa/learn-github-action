' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00101StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports QAT00101Back
Imports SIAPP_PUB_DTO
Imports QAT00101Common

Public Class QAT00101StreamingService
    Implements IQAT00101StreamingService

    Public Function getCmbDepartment() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getCmbDepartment
        Dim loCls As New QAT00101CLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101DTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .iDocOwnerlevel = R_Utility.R_GetStreamingContext("iDocOwnerlevel")
            End With

            loRtnList = loCls.getCmbDepartment(poParam)

            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbDepartment")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbDocType() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getCmbDocType
        Dim loCls As New QAT00101CLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101DTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getCmbDocType(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbDocType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getListDocument() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getListDocument
        Dim loCls As New QAT00101CLS
        Dim loRtnList As New List(Of QAT00101StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101DTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cProgramId = R_Utility.R_GetStreamingContext("cProgramId")
            End With

            loRtnList = loCls.getListDocument(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00101StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getListDocument")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListRelatedPosition() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getListRelatedPosition
        Dim loCls As New QAT00101RelatedPositionCLS
        Dim loRtnList As New List(Of QAT00101RelatedPositionStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101DTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnList = loCls.getListRelatedPosition(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00101RelatedPositionStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getListRelatedPosition")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbRetainersPosition() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getCmbRetainersPosition
        Dim loCls As New QAT00101RetainersCLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101RetainersGridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .iDocTypeLevel = R_Utility.R_GetStreamingContext("iDocTypeLevel")
                .cParentDocNo = R_Utility.R_GetStreamingContext("cParentDocNo")
            End With

            loRtnList = loCls.getCmbRetainersPosition(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbRetainersPosition")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getListRetainersPosition() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getListRetainersPosition
        Dim loCls As New QAT00101RetainersCLS
        Dim loRtnList As New List(Of QAT00101RetainersStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101RetainersGridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnList = loCls.getListRetainersPosition(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00101RetainersStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getListRetainersPosition")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbDocTypeRelatedDocuments() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getCmbDocTypeRelatedDocuments
        Dim loCls As New QAT00101RelatedDocumentsCLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101RelatedDocumentsDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cParentDocType = R_Utility.R_GetStreamingContext("cParentDocType")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getCmbDocTypeRelatedDocuments(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbDocTypeRelatedDocuments")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListRelatedDocuments() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getListRelatedDocuments
        Dim loCls As New QAT00101RelatedDocumentsCLS
        Dim loRtnList As New List(Of QAT00101RelatedDocumentsStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101RelatedDocumentsDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")

            End With

            loRtnList = loCls.getListRelatedDocuments(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00101RelatedDocumentsStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getListRelatedDocuments")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListRetainersRelated() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getListRetainersRelated
        Dim loCls As New QAT00101RelatedRetainerCLS
        Dim loRtnList As New List(Of QAT00101RelatedRetainerStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101RelatedRetainerGridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cDocGuid = R_Utility.R_GetStreamingContext("cDocGuid")

            End With

            loRtnList = loCls.getListRetainersRelated(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00101RelatedRetainerStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getListRetainersRelated")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbRelatedRetainer() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getCmbRelatedRetainer
        Dim loCls As New QAT00101RelatedRetainerCLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101RelatedRetainerGridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnList = loCls.getCmbRelatedRetainer(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbRelatedRetainer")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

  

    'TAB 5

    Public Function getCmbClause() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getCmbClause
        Dim loCls As New QAT00101ClauseCLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101ClauseGridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cIsoType = R_Utility.R_GetStreamingContext("cIsoType")
                .cIsoVersion = R_Utility.R_GetStreamingContext("cIsoVersion")
            End With

            loRtnList = loCls.getCmbClause(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbClause")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbIsoType() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getCmbIsoType
        Dim loCls As New QAT00101ClauseCLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101ClauseGridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getCmbIsoType(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbIsoType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListClause() As System.ServiceModel.Channels.Message Implements IQAT00101StreamingService.getListClause
        Dim loCls As New QAT00101ClauseCLS
        Dim loRtnList As New List(Of QAT00101ClauseStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAT00101ClauseGridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnList = loCls.getListClause(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00101ClauseStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getListClause")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of QAT00101Back.QAT00101GridDTO), poParam8 As System.Collections.Generic.List(Of QAT00101Back.QAT00101RelatedDocumentsGridDTO)) Implements IQAT00101StreamingService.Dummy

    End Sub
End Class

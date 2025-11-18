Imports R_Common
Imports QAR00100Back
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports QAR00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR00100StreamService" in code, svc and config file together.
Public Class QAR00100StreamService
    Implements IQAR00100StreamService

    Public Function getListGridDocument() As System.ServiceModel.Channels.Message Implements IQAR00100StreamService.getListGridDocument
        Dim loException As New R_Exception
        Dim loCls As New QAR00100CLS
        Dim loRtnTemp As List(Of QAR00100StreamingDTO)
        Dim loParam As New QAR00100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
        End With

        Try
            loRtnTemp = loCls.getListGridDocument(loParam)
            loList = R_Utility.R_GetChunkData(Of QAR00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGridDocument")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListGridTransactionList() As System.ServiceModel.Channels.Message Implements IQAR00100StreamService.getListGridTransactionList
        Dim loException As New R_Exception
        Dim loCls As New QAR00100CLS
        Dim loRtnTemp As List(Of QAR00100StreamingDTO)
        Dim loParam As New QAR00100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .cFromdate = R_Utility.R_GetStreamingContext("cFromdate")
            .cToDate = R_Utility.R_GetStreamingContext("cToDate")
        End With

        Try
            loRtnTemp = loCls.getListGridTransactionList(loParam)
            loList = R_Utility.R_GetChunkData(Of QAR00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGridTransactionList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportDocument() As System.ServiceModel.Channels.Message Implements IQAR00100StreamService.getReportDocument
        Dim loException As New R_Exception
        Dim loCls As New QAR00100CLS
        Dim loRtnTemp As List(Of RSP_QAR00100_01DTO)
        Dim loParam As New QAR00100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())


        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cTransactionStatus = R_Utility.R_GetStreamingContext("cTransactionStatus")
            .cDocumentOwner = R_Utility.R_GetStreamingContext("cDocumentOwner")
            .cFilter = R_Utility.R_GetStreamingContext("cFilter")
            .cFromdate = R_Utility.R_GetStreamingContext("cFromdate")
            .cToDate = R_Utility.R_GetStreamingContext("cToDate")
        End With

        Try
            loRtnTemp = loCls.getReportDocument(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_QAR00100_01DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportDocument")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function



    Public Function getReportTrackingDocument() As System.ServiceModel.Channels.Message Implements IQAR00100StreamService.getReportTrackingDocument
        Dim loException As New R_Exception
        Dim loCls As New QAR00100CLS
        Dim loRtnTemp As List(Of RSP00100_DOCUMENTDTO)
        Dim loParam As New QAR00100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())


        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .lolistTransaction = R_Utility.R_GetStreamingContext("lolistTransaction")
        End With

        Try
            loRtnTemp = loCls.getReportTrackingDocument(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP00100_DOCUMENTDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportTrackingDocument")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function getReportTrackingDocument_Clause() As System.ServiceModel.Channels.Message Implements IQAR00100StreamService.getReportTrackingDocument_Clause
        Dim loException As New R_Exception
        Dim loCls As New QAR00100CLS
        Dim loRtnTemp As List(Of RSP_QAR00100_CLAUSEDTO)
        Dim loParam As New QAR00100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .lolistTransaction = R_Utility.R_GetStreamingContext("lolistTransaction")
        End With

        Try
            loRtnTemp = loCls.getReportTrackingDocument_Clause(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_QAR00100_CLAUSEDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportTrackingDocument_Clause")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getReportTrackingDocument_RELDOC() As System.ServiceModel.Channels.Message Implements IQAR00100StreamService.getReportTrackingDocument_RELDOC
        Dim loException As New R_Exception
        Dim loCls As New QAR00100CLS
        Dim loRtnTemp As List(Of RSP_QAR00100_RELDOCDTO)
        Dim loParam As New QAR00100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .lolistTransaction = R_Utility.R_GetStreamingContext("lolistTransaction")
        End With

        Try
            loRtnTemp = loCls.getReportTrackingDocument_RELDOC(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_QAR00100_RELDOCDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportTrackingDocument_RELDOC")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getReportTrackingDocument_RELDOCRETAINER() As System.ServiceModel.Channels.Message Implements IQAR00100StreamService.getReportTrackingDocument_RELDOCRETAINER
        Dim loException As New R_Exception
        Dim loCls As New QAR00100CLS
        Dim loRtnTemp As List(Of RSP_QAR00100_RELDOCRETAINERDTO)
        Dim loParam As New QAR00100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .lolistTransaction = R_Utility.R_GetStreamingContext("lolistTransaction")
        End With

        Try
            loRtnTemp = loCls.getReportTrackingDocument_RELDOCRETAINER(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_QAR00100_RELDOCRETAINERDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportTrackingDocument_RELDOCRETAINER")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getReportTrackingDocument_RelPos() As System.ServiceModel.Channels.Message Implements IQAR00100StreamService.getReportTrackingDocument_RelPos
        Dim loException As New R_Exception
        Dim loCls As New QAR00100CLS
        Dim loRtnTemp As List(Of RSP_QAR00100_RELPOSDTO)
        Dim loParam As New QAR00100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .lolistTransaction = R_Utility.R_GetStreamingContext("lolistTransaction")
        End With

        Try
            loRtnTemp = loCls.getReportTrackingDocument_RelPos(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_QAR00100_RELPOSDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportTrackingDocument_RelPos")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getReportTrackingDocument_RETAINER() As System.ServiceModel.Channels.Message Implements IQAR00100StreamService.getReportTrackingDocument_RETAINER
        Dim loException As New R_Exception
        Dim loCls As New QAR00100CLS
        Dim loRtnTemp As List(Of RSP_QAR00100_RETAINERDTO)
        Dim loParam As New QAR00100DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .lolistTransaction = R_Utility.R_GetStreamingContext("lolistTransaction")
        End With

        Try
            loRtnTemp = loCls.getReportTrackingDocument_RETAINER(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_QAR00100_RETAINERDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportTrackingDocument_RETAINER")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCM00100Back
Imports MCM00100Common

Public Class MCM00100StreamingService
    Implements IMCM00100StreamingService

    Public Function getGridHdList() As System.ServiceModel.Channels.Message Implements IMCM00100StreamingService.getGridHdList
        Dim loEx As New R_Exception
        Dim loParam As New MCM00100GridHdDto
        Dim loCls As New MCM00100GridHdCls
        Dim loRtn As List(Of MCM00100StreamingDto)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtn = loCls.getGridHdList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCM00100StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridHdList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg

    End Function

    Public Function getGridPicList() As System.ServiceModel.Channels.Message Implements IMCM00100StreamingService.getGridPicList
        Dim loEx As New R_Exception
        Dim loParam As New MCM00100PICDto
        Dim loCls As New MCM00100PICCls
        Dim loRtn As List(Of MCM00100StreamingDto)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cPartnerId = R_Utility.R_GetStreamingContext("cPartnerId")
            loRtn = loCls.getGridPicList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCM00100StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridPicList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getGridMpdList() As System.ServiceModel.Channels.Message Implements IMCM00100StreamingService.getGridMpdList
        Dim loEx As New R_Exception
        Dim loParam As New MCM00100MPDDto
        Dim loCls As New MCM00100MPDCls
        Dim loRtn As List(Of MCM00100StreamingDto)
        Dim loRtnMsg As Message
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cPartnerId = R_Utility.R_GetStreamingContext("cPartnerId")
            loRtn = loCls.getGridMpdList(loParam)

            loList = R_Utility.R_GetChunkData(Of MCM00100StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridMpdList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getAttachment() As System.ServiceModel.Channels.Message Implements IMCM00100StreamingService.getAttachment
        Dim loEx As New R_Exception
        Dim loParam As New MCM00100MPDDto
        Dim loCls As New MCM00100MPDCls
        Dim loRtn As MCM00100StreamingDto
        Dim loRtnMsg As Message
        Dim loRtnTemp As New List(Of MCM00100StreamingDto)
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cPartnerId = R_Utility.R_GetStreamingContext("cPartnerId")
            loParam.cDocumentNo = R_Utility.R_GetStreamingContext("cDocumentNo")
            loRtn = loCls.getAttachment(loParam)
            loRtnTemp.Add(loRtn)
            loList = R_Utility.R_GetChunkData(Of MCM00100StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAttachment")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Sub Dummy(poParGrid1 As System.Collections.Generic.List(Of MCM00100Back.MCM00100GridHdDto)) Implements IMCM00100StreamingService.Dummy

    End Sub
End Class

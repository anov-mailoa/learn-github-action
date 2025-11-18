Imports R_Common
Imports System.ServiceModel.Channels
Imports MCM02000Back
Imports MCM02000Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM02000StreamingService" in code, svc and config file together.
Public Class MCM02000StreamingService
    Implements IMCM02000StreamingService

    Public Function getBankTransferTemplateList() As System.ServiceModel.Channels.Message Implements IMCM02000StreamingService.getBankTransferTemplateList
        Dim loCls As New MCM02000CLS
        Dim loParam As New MCM02000DTO
        Dim loRtnList As New List(Of MCM02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getBankTransferTemplateList(loParam)

            loList = R_Utility.R_GetChunkData(Of MCM02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getBankTransferTemplateList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTemplateHeader() As System.ServiceModel.Channels.Message Implements IMCM02000StreamingService.getTemplateHeader
        Dim loCls As New MCM02000CLS
        Dim loParam As New MCM02000DTO
        Dim loRtnList As New List(Of MCM02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTemplateCode = R_Utility.R_GetStreamingContext("cTemplateCode")
            End With

            loRtnList = loCls.getTemplateHeader(loParam)

            loList = R_Utility.R_GetChunkData(Of MCM02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getTemplateHeader")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTemplateHeaderDetail() As System.ServiceModel.Channels.Message Implements IMCM02000StreamingService.getTemplateHeaderDetail
        Dim loCls As New MCM02000CLS
        Dim loParam As New MCM02000DTO
        Dim loRtnList As New List(Of MCM02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTemplateCode = R_Utility.R_GetStreamingContext("cTemplateCode")
                .cHeaderCode = R_Utility.R_GetStreamingContext("cHeaderCode")
                .cEquation = R_Utility.R_GetStreamingContext("cEquation")
            End With

            loRtnList = loCls.getTemplateHeaderDetail(loParam)

            loList = R_Utility.R_GetChunkData(Of MCM02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getTemplateHeaderDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbBank() As System.ServiceModel.Channels.Message Implements IMCM02000StreamingService.getCmbBank
        Dim loCls As New MCM02000CLS
        Dim loRtnList As New List(Of MCM02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            loRtnList = loCls.getCmbBank(R_Utility.R_GetStreamingContext("cCompanyId"))

            loList = R_Utility.R_GetChunkData(Of MCM02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbBank")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of MCM02000Back.MCM02000UnboundDTO)) Implements IMCM02000StreamingService.Dummy

    End Sub
End Class

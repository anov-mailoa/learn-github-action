Imports R_Common
Imports System.ServiceModel.Channels
Imports PYM04500Back
Imports PYM04500Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM04500StreamingService" in code, svc and config file together.
Public Class PYM04500StreamingService
    Implements IPYM04500StreamingService

    Public Function getBankTransferTemplateList() As System.ServiceModel.Channels.Message Implements IPYM04500StreamingService.getBankTransferTemplateList
        Dim loCls As New PYM04500CLS
        Dim loParam As New PYM04500DTO
        Dim loRtnList As New List(Of PYM04500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getBankTransferTemplateList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM04500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBankTransferTemplateList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTemplateHeader() As System.ServiceModel.Channels.Message Implements IPYM04500StreamingService.getTemplateHeader
        Dim loCls As New PYM04500CLS
        Dim loParam As New PYM04500DTO
        Dim loRtnList As New List(Of PYM04500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTemplateCode = R_Utility.R_GetStreamingContext("cTemplateCode")
            End With

            loRtnList = loCls.getTemplateHeader(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM04500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTemplateHeader")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTemplateHeaderDetail() As System.ServiceModel.Channels.Message Implements IPYM04500StreamingService.getTemplateHeaderDetail
        Dim loCls As New PYM04500CLS
        Dim loParam As New PYM04500DTO
        Dim loRtnList As New List(Of PYM04500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTemplateCode = R_Utility.R_GetStreamingContext("cTemplateCode")
                .cHeaderCode = R_Utility.R_GetStreamingContext("cHeaderCode")
                .cEquation = R_Utility.R_GetStreamingContext("cEquation")
            End With

            loRtnList = loCls.getTemplateHeaderDetail(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM04500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTemplateHeaderDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbBank() As System.ServiceModel.Channels.Message Implements IPYM04500StreamingService.getCmbBank
        Dim loCls As New PYM04500CLS
        Dim loRtnList As New List(Of PYM04500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            loRtnList = loCls.getCmbBank(R_Utility.R_GetStreamingContext("cCompanyId"))

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM04500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbBank")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYM04500Back.PYM04500UnboundDTO)) Implements IPYM04500StreamingService.Dummy

    End Sub
End Class

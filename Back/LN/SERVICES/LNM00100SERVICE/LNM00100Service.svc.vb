Imports R_Common
Imports R_BackEnd
Imports LNM00100Back
Imports System.ServiceModel.Channels
Imports LNM00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00100Service" in code, svc and config file together.
Public Class LNM00100Service
    Implements ILNM00100Service

    Public Function getDataGrid() As System.ServiceModel.Channels.Message Implements ILNM00100Service.getDataGrid
        Dim loRtn As New List(Of LNM00100Dto_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNM00100_TenorCls
        Dim loEx As New R_Exception
        Dim pcComId As String, pcLoanType As String, pcKeyId As String
        Dim loList As List(Of Byte())

        Try
            pcComId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcLoanType = R_Utility.R_GetStreamingContext("cLoanType")
            pcKeyId = R_Utility.R_GetStreamingContext("cKeyId")

            loRtn = loCls.getDataGrid(pcComId, pcLoanType, pcKeyId)
            loList = R_Utility.R_GetChunkData(Of LNM00100Dto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTenor")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getUpdateDateList() As System.ServiceModel.Channels.Message Implements ILNM00100Service.getUpdateDateList
        Dim loRtn As New List(Of GridUpdateDateDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNM00100Cls
        Dim loEx As New R_Exception
        Dim pcComId As String
        Dim loList As List(Of Byte())

        Try
            pcComId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.getUpdateDateList(pcComId)
            loList = R_Utility.R_GetChunkData(Of GridUpdateDateDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getUpdateDateList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNM00100Back.LNM00100Dto_R), poParCombo As System.Collections.Generic.List(Of LNM00100Back.Cmb_Dto)) Implements ILNM00100Service.Dummy

    End Sub

    Public Function GetCMBCurrenyTaxRate() As System.ServiceModel.Channels.Message Implements ILNM00100Service.GetCMBCurrenyTaxRate
        Dim loRtn As New List(Of LNM00100Dto_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNM00100Cls
        Dim loEx As New R_Exception
        Dim pcCompId As String
        Dim loList As List(Of Byte())

        Try
            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.GetCMBCurrenyTaxRate(pcCompId)
            loList = R_Utility.R_GetChunkData(Of LNM00100Dto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCMBCurrenyTaxRate")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function
End Class

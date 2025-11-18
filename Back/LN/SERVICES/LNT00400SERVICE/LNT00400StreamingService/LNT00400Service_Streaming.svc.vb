Imports R_Common
Imports R_BackEnd
Imports LNT00400Back
Imports System.ServiceModel.Channels
Imports LNT00400Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00400Service_Streaming" in code, svc and config file together.
Public Class LNT00400Service_Streaming
    Implements ILNT00400Service_Streaming

    Public Function getTransaction() As System.ServiceModel.Channels.Message Implements ILNT00400Service_Streaming.getTransaction
        Dim loRtn As New List(Of LNT00400Dto_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNT00400Cls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00400Dto
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmpID")
            poParam.cKey = R_Utility.R_GetStreamingContext("cKeyID")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")

            loRtn = loCls.getTransaction(poParam)
            loList = R_Utility.R_GetChunkData(Of LNT00400Dto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getCombo() As System.ServiceModel.Channels.Message Implements ILNT00400Service_Streaming.getCombo
        Dim loRtn As New List(Of ComboDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNT00400Cls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00400Dto
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            loRtn = loCls.getDeptCombo(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCombo")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getCorrectableInstallment() As System.ServiceModel.Channels.Message Implements ILNT00400Service_Streaming.getCorrectableInstallment
        Dim loRtn As New List(Of LNT00400_InstallmentStreamingDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNT00400Cls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00400Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cKey = R_Utility.R_GetStreamingContext("cKey")
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")

            loRtn = loCls.getCorrectableInstallment(poParam)
            loList = R_Utility.R_GetChunkData(Of LNT00400_InstallmentStreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCorrectableInstallment")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Sub Dummy(poParStreaming As System.Collections.Generic.List(Of LNT00400Back.LNT00400Dto_R), poInstallmentS As System.Collections.Generic.List(Of LNT00400Back.LNT00400_InstallmentDto)) Implements ILNT00400Service_Streaming.Dummy

    End Sub
End Class

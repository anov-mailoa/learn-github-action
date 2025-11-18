Imports R_Common
Imports R_BackEnd
Imports LNT00200Back
Imports System.ServiceModel.Channels
Imports LNT00200Common

Public Class LNT00200Service_Streaming
    Implements ILNT00200Service_Streaming

    Public Function getListDisbursement() As System.ServiceModel.Channels.Message Implements ILNT00200Service_Streaming.getListDisbursement
        Dim loRtn As New List(Of LNT00200Dto_S)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New LNT00200Cls
        Dim loEx As New R_Exception
        Dim poParam As New LNT00200Dto
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLoanDept = R_Utility.R_GetStreamingContext("cLoanDept")
                .cReferenceDateFrom = R_Utility.R_GetStreamingContext("cReferenceDateFrom")
                .cReferenceDateTo = R_Utility.R_GetStreamingContext("cReferenceDateTo")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyID")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With
            loRtn = loCls.getListDisbursement(poParam)
            loList = R_Utility.R_GetChunkData(Of LNT00200Dto_S)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Sub Dummy(poParDisbursement As System.Collections.Generic.List(Of LNT00200Back.LNT00200Dto_R)) Implements ILNT00200Service_Streaming.Dummy

    End Sub
End Class

Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports MCT00200Back
Imports R_BackEnd
Imports R_Common
Imports MCT00200Common

Public Class MCT00200StreamingService
    Implements IMCT00200StreamingService

    Public Function getOverLimitClaimlist() As System.ServiceModel.Channels.Message Implements IMCT00200StreamingService.getOverLimitClaimlist
        Dim loCls As New MCT00200OverlimitClaimListCls
        Dim loRtnList As New List(Of MCT00200StreamingDto)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT00200OverlimitClaimListDto
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnList = loCls.getOverLimitClaimlist(poParam)

            loList = R_Utility.R_GetChunkData(Of MCT00200StreamingDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getOverLimitClaimlist")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParGrid1 As System.Collections.Generic.List(Of MCT00200Back.MCT00200OverlimitClaimListDto)) Implements IMCT00200StreamingService.Dummy

    End Sub

    Public Function getOverLimitTransactionList() As System.ServiceModel.Channels.Message Implements IMCT00200StreamingService.getOverLimitTransactionList
        Dim loCls As New MCT00200OverlimitClaimListCls
        Dim loRtnList As New List(Of MCT00200StreamingDto)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT00200OverlimitClaimListDto
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnList = loCls.getOverLimitTransactionList(poParam)

            loList = R_Utility.R_GetChunkData(Of MCT00200StreamingDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getOverLimitTransactionList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR00200Back
Imports PYR00200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR00200StreamingService" in code, svc and config file together.
Public Class PYR00200StreamingService
    Implements IPYR00200StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR00200StreamingService.getGrupGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYR00200Cls
        Dim poParam As New PYR00200DTO
        Dim loRtnList As New List(Of PYR00200StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)

            loList = R_Utility.R_GetChunkData(Of PYR00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR00200StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYR00200Cls
        Dim poParam As New PYR00200DTO
        Dim loRtnList As New List(Of PYR00200ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCodeList = R_Utility.R_GetStreamingContext("cGroupCodeList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cStartPeriodIndex = R_Utility.R_GetStreamingContext("cStartPeriodIndex")
                .cEndPeriodIndex = R_Utility.R_GetStreamingContext("cEndPeriodIndex")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cShowResignMode = R_Utility.R_GetStreamingContext("cShowResignMode")
            End With

            loRtnList = loCls.getReportData(poParam)

            loList = R_Utility.R_GetChunkData(Of PYR00200ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PYR00200Back.PYR00200DTO)) Implements IPYR00200StreamingService.Dummy

    End Sub

End Class

Imports System.ServiceModel.Channels
Imports R_Common
Imports PYR00300Back
Imports PYR00300Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR00300StreamingService" in code, svc and config file together.
Public Class PYR00300StreamingService
    Implements IPYR00300StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR00300StreamingService.getGrupGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYR00300CLS
        Dim poParam As New PYR00300DTO
        Dim loRtnList As New List(Of PYR00300StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)

            loList = R_Utility.R_GetChunkData(Of PYR00300StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR00300StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYR00300CLS
        Dim poParam As New PYR00300DTO
        Dim loRtnList As New List(Of PYR00300StreamingDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cGroupCodeList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cReportType = R_Utility.R_GetStreamingContext("cReportType")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getReportData(poParam)

            loList = R_Utility.R_GetChunkData(Of PYR00300StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PYR00300Back.PYR00300DTO)) Implements IPYR00300StreamingService.Dummy

    End Sub

End Class

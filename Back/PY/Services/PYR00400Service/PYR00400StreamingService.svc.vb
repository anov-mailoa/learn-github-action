Imports System.ServiceModel.Channels
Imports R_Common
Imports PYR00400Back
Imports R_BackEnd
Imports PYR00400Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR00400StreamingService" in code, svc and config file together.
Public Class PYR00400StreamingService
    Implements IPYR00400StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR00400StreamingService.getGrupGaji
        Dim loException As New R_Exception
        Dim loCls As New PYR00400CLS
        Dim poParam As New PYR00400DTO
        Dim loRtnList As New List(Of PYR00400StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYR00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR00400StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PYR00400CLS
        Dim poParam As New PYR00400DTO
        Dim loRtnList As New List(Of PYR00400StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cCurrencyCode = R_Utility.R_GetStreamingContext("cCurrencyCode")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getReportData(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYR00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PYR00400Back.PYR00400DTO)) Implements IPYR00400StreamingService.Dummy

    End Sub

End Class

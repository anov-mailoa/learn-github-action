Imports System.ServiceModel.Channels
Imports R_Common
Imports PYR00100Back
Imports PYR00100Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR00100StreamingService" in code, svc and config file together.
Public Class PYR00100StreamingService
    Implements IPYR00100StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR00100StreamingService.getGrupGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYR00100CLS
        Dim poParam As New PYR00100DTO
        Dim loRtnList As New List(Of PYR00100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
            End With

            loRtnList = loCls.getGrupGaji(poParam)

            loList = R_Utility.R_GetChunkData(Of PYR00100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR00100StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYR00100CLS
        Dim poParam As New PYR00100DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR00100StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cPeriodStart = R_Utility.R_GetStreamingContext("cPeriodStart")
                .cPeriodEnd = R_Utility.R_GetStreamingContext("cPeriodEnd")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.getReportData(poParam)

            loList = R_Utility.R_GetChunkData(Of PYR00100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYR00100Back.PYR00100DTO)) Implements IPYR00100StreamingService.Dummy

    End Sub
End Class

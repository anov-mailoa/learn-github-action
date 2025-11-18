Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR00600Back
Imports PYR00600Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR00600StreamingService" in code, svc and config file together.
Public Class PYR00600StreamingService
    Implements IPYR00600StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR00600StreamingService.getGrupGaji
        Dim loException As New R_Exception
        Dim loCls As New PYR00600CLS
        Dim poParam As New PYR00600DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR00600StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR00600StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR00600StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PYR00600CLS
        Dim poParam As New PYR00600DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR00600StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                '.lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.getPivotData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR00600StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            loException.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PYR00600Back.PYR00600DTO), poParam2 As System.Collections.Generic.List(Of PYR00600Back.PYR00600PivotDTO)) Implements IPYR00600StreamingService.Dummy

    End Sub

End Class

Imports System.ServiceModel.Channels
Imports R_Common
Imports PYR00500Back
Imports R_BackEnd
Imports PYR00500Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR00500StreamingService" in code, svc and config file together.
Public Class PYR00500StreamingService
    Implements IPYR00500StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR00500StreamingService.getGrupGaji
        Dim loException As New R_Exception
        Dim loCls As New PYR00500CLS
        Dim poParam As New PYR00500DTO
        Dim loRtnList As New List(Of PYR00500StreamingDTO)
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
            loList = R_Utility.R_GetChunkData(Of PYR00500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPivotData() As System.ServiceModel.Channels.Message Implements IPYR00500StreamingService.getPivotData
        Dim loException As New R_Exception
        Dim loCls As New PYR00500CLS
        Dim poParam As New PYR00500DTO
        Dim loRtnList As New List(Of PYR00500StreamingDTO)
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

            loRtnList = loCls.getReportData(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYR00500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPivotData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYR00500Back.PYR00500DTO)) Implements IPYR00500StreamingService.Dummy

    End Sub
End Class

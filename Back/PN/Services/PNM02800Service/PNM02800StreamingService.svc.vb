Imports System.ServiceModel
Imports R_Common
Imports PNM02800Back
Imports PNM02800Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02800StreamingService" in code, svc and config file together.
Public Class PNM02800StreamingService
    Implements IPNM02800StreamingService

    Public Function getApprreciationList() As System.ServiceModel.Channels.Message Implements IPNM02800StreamingService.getApprreciationList
        Dim loException As New R_Exception
        Dim loCls As New PNM02800Cls
        Dim loRtnTemp As List(Of PNM02800StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM02800FormDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.getApprreciationList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02800StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getApprreciationList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNM02800StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PNM02800Cls
        Dim poParam As New PNM02800FormDTO
        Dim loRtnTemp As List(Of PNM02800ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02800ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poGrid As System.Collections.Generic.List(Of PNM02800Back.PNM02800GridDTO)) Implements IPNM02800StreamingService.Dummy

    End Sub
End Class

Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM02600Back
Imports PNM02600Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02600StreamingService" in code, svc and config file together.
Public Class PNM02600StreamingService
    Implements IPNM02600StreamingService

    Public Function getPnmCriteria() As System.ServiceModel.Channels.Message Implements IPNM02600StreamingService.getPnmCriteria
        Dim loException As New R_Exception
        Dim loCls As New PNM02600Cls
        Dim poParam As New PNM02600DTO
        Dim loRtnTemp As List(Of PNM02600StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            loRtnTemp = loCls.getPnmCriteria(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02600StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "PnmCriteria")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNM02600StreamingService.getReportData
        Dim loCls As New PNM02600Cls
        Dim loRtnTemp As List(Of PNM02600ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM02600DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02600ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

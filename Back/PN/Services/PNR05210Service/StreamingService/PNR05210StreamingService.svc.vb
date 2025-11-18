Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR05210Back
Imports PNR05210Common

Public Class PNR05210StreamingService
    Implements IPNR05210StreamingService

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IPNR05210StreamingService.GetEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New PNR05210Cls
        Dim loParam As New PNR05210GridDto
        Dim loRtnTemp As List(Of PNR05210StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cStartDate = R_Utility.R_GetStreamingContext("cStartDate")

            loRtnTemp = loCls.GetEmployeeList(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR05210StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR05210StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR05210Cls
        Dim loParam As New PNR05210GridDto
        Dim loRtnTemp As List(Of PNR05210ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
            loParam.cHistoryOf = R_Utility.R_GetStreamingContext("cHistoryOf")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.GetReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR05210ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

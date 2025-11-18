Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR05220Back
Imports PNR05220Common

Public Class PNR05220StreamingService
    Implements IPNR05220StreamingService

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IPNR05220StreamingService.GetEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New PNR05220BackCls
        Dim loParam As New PNR05220BackGridDto
        Dim loRtnTemp As List(Of PNR05220BackStreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtnTemp = loCls.GetEmployeeList(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR05220BackStreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR05220StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR05220BackCls
        Dim loParam As New PNR05220BackGridDto
        Dim loRtnTemp As List(Of PNR05220BackReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")

            loRtnTemp = loCls.GetReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR05220BackReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

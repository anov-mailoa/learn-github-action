' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR05240StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR05240Back
Imports PNR05240Common
Imports SIAPP_SERVICE_PN

Public Class PNR05240StreamingService
    Implements IPNR05240StreamingService

    Public Function GetTrainingList() As System.ServiceModel.Channels.Message Implements IPNR05240StreamingService.GetTrainingList
        Dim loEx As New R_Exception
        Dim loCls As New PNR05240BackCLS
        Dim loParam As New PNR05240BackDTO
        Dim loRtnTemp As List(Of PNR05240TreeStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.GetTrainingList(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR05240TreeStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTrainingList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR05240StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR05240BackCLS
        Dim loParam As New PNR05240BackDTO
        Dim loRtnTemp As List(Of PNR05240ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
                .cTrainingCodes = R_Utility.R_GetStreamingContext("cTrainingCodes")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.GetReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR05240ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poTraining As PNR05240Back.PNR05240TreeDTO, poParam As PNR05240Back.PNR05240BackDTO) Implements IPNR05240StreamingService.Dummy

    End Sub

    Public Function getExcelData() As Message Implements IPNR05240StreamingService.getExcelData
        Dim loEx As New R_Exception
        Dim loCls As New PNR05240BackCLS
        Dim loParam As New PNR05240BackDTO
        Dim loRtnTemp As New List(Of DataTable)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
                .cTrainingCodes = R_Utility.R_GetStreamingContext("cTrainingCodes")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getExcelData(loParam)
            loList = R_Utility.R_GetChunkData(Of DataTable)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExcelData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

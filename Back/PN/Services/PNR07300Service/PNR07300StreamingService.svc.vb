Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR07300Back
Imports PNR07300Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR07300StreamingService" in code, svc and config file together.
Public Class PNR07300StreamingService
    Implements IPNR07300StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNR07300StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New PNR07300Cls
        Dim poParam As New PNR07300Dto
        Dim loRtnTemp As List(Of PNR07300ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cCompanyList = R_Utility.R_GetStreamingContext("cCompanyList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR07300ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPnmOrgStructure() As System.ServiceModel.Channels.Message Implements IPNR07300StreamingService.getPnmOrgStructure
        Dim loCls As New PNR07300Cls
        Dim poParam As New PNR07300Dto
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNR07300StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getPnmOrgStructure(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR07300StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmOrgStructure")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSamCompanies() As System.ServiceModel.Channels.Message Implements IPNR07300StreamingService.getSamCompanies
        Dim loCls As New PNR07300Cls
        Dim poParam As New PNR07300Dto
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNR07300StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                '.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                '.cMonitoringBy = R_Utility.R_GetStreamingContext("cMonitoringBy")
            End With

            loRtnTemp = loCls.getSamCompanies(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR07300StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSamCompanies")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PNR07300Back.PNR07300Dto)) Implements IPNR07300StreamingService.Dummy

    End Sub
End Class

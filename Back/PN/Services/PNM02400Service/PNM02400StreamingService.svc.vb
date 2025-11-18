Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM02400Back
Imports PNM02400Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02400StreamingService" in code, svc and config file together.
Public Class PNM02400StreamingService
    Implements IPNM02400StreamingService

    Public Function getPnmGradeDt() As System.ServiceModel.Channels.Message Implements IPNM02400StreamingService.getPnmGradeDt
        Dim loException As New R_Exception
        Dim loCls As New PNM02400PnmGradeDtCls
        Dim poParam As New PNM02400PnmGradeDtDTO
        Dim loRtnTemp As List(Of PNM02400PnmGradeDtStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cGradeCode = R_Utility.R_GetStreamingContext("cGradeCode")

            loRtnTemp = loCls.getPnmGradeDt(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02400PnmGradeDtStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "PnmGradeDt")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPnmGradeHd() As System.ServiceModel.Channels.Message Implements IPNM02400StreamingService.getPnmGradeHd
        Dim loException As New R_Exception
        Dim loCls As New PNM02400PnmGradeHdCls
        Dim poParam As New PNM02400PnmGradeHdDTO
        Dim loRtnTemp As List(Of PNM02400PnmGradeHdStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.getPnmGradeHd(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02400PnmGradeHdStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "PnmGradeHd")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNM02400StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PNM02400PnmGradeHdCls
        Dim poParam As New PNM02400PnmGradeHdDTO
        Dim loRtnTemp As List(Of PNM02400PnmGradeHdStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02400PnmGradeHdStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of PNM02400Back.PNM02400ReportDTO)) Implements IPNM02400StreamingService.Dummy

    End Sub

End Class

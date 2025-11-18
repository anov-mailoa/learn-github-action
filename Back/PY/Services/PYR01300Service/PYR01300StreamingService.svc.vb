Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR01300Common
Imports PYR01300Back
Imports SIAPP_SERVICE_PY

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR01300StreamingService" in code, svc and config file together.
Public Class PYR01300StreamingService
    Implements IPYR01300StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR01300StreamingService.getGrupGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYR01300CLS
        Dim poParam As New PYR01300DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR01300StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01300StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR01300StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYR01300CLS
        Dim poParam As New PYR01300DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR01300ReportDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cCompCode = R_Utility.R_GetStreamingContext("cCompCode")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cGroupingBy = R_Utility.R_GetStreamingContext("cGroupingBy")
            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01300ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try


        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getExcelData() As Message Implements IPYR01300StreamingService.getExcelData
        Dim loEx As New R_Exception
        Dim loCls As New PYR01300CLS
        Dim loParam As New PYR01300DTO
        Dim loRtnTemp As New List(Of DataTable)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cCompCode = R_Utility.R_GetStreamingContext("cCompCode")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cGroupingBy = R_Utility.R_GetStreamingContext("cGroupingBy")
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

    Public Function getPeriod() As System.ServiceModel.Channels.Message Implements IPYR01300StreamingService.getPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYR01300CLS
        Dim poParam As New PYR01300DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR01300StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getPeriod(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01300StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriod")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYR01300Back.PYR01300DTO)) Implements IPYR01300StreamingService.Dummy

    End Sub

End Class

Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR20000Back
Imports PNR20000Common
Imports SIAPP_SERVICE_PN

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM20000StreamingService" in code, svc and config file together.
Public Class PNR20000StreamingService
    Implements IPNR20000StreamingService

    Public Sub dummy(poParam As PNR20000DTO) Implements IPNR20000StreamingService.dummy

    End Sub

    Public Function getListComboBox() As Message Implements IPNR20000StreamingService.getListComboBox
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNR20000CLS
        Dim loRtn As List(Of PNR20000ComboBoxDTO)
        Dim loParam As New PNR20000DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CFLAG = R_Utility.R_GetStreamingContext("CFLAG")
            End With

            loRtn = loCls.getListComboBox(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR20000ComboBoxDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListComboBox")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getReportData() As Message Implements IPNR20000StreamingService.getReportData
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNR20000CLS
        Dim loRtn As List(Of PNR20000ReportDTO)
        Dim loParam As New PNR20000DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CREPORT_TYPE = R_Utility.R_GetStreamingContext("CREPORT_TYPE")
                .CCANTEEN_CODE = R_Utility.R_GetStreamingContext("CCANTEEN_CODE")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CGROUP_BY = R_Utility.R_GetStreamingContext("CGROUP_BY")
                .LALL_DATA = R_Utility.R_GetStreamingContext("LALL_DATA")
                .CSELECTED_ITEMS = R_Utility.R_GetStreamingContext("CSELECTED_ITEMS")
                .LINCLUDE_GUEST = R_Utility.R_GetStreamingContext("LINCLUDE_GUEST")
                .LALL_LEVEL_BELOW = R_Utility.R_GetStreamingContext("LALL_LEVEL_BELOW")
            End With

            loRtn = loCls.getReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR20000ReportDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getReportHeaderData() As Message Implements IPNR20000StreamingService.getReportHeaderData
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNR20000CLS
        Dim loRtn As List(Of PNR20000ReportHeaderDTO)
        Dim loParam As New PNR20000DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CREPORT_TYPE = R_Utility.R_GetStreamingContext("CREPORT_TYPE")
                .CGROUP_BY = R_Utility.R_GetStreamingContext("CGROUP_BY")
            End With

            loRtn = loCls.getReportHeaderData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR20000ReportHeaderDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportHeaderData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class

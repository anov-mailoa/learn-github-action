Imports R_BackEnd
Imports R_Common
Imports ATR00130Back
Imports ATR00130Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00130StreamingService" in code, svc and config file together.
Public Class ATR00130StreamingService
    Implements IATR00130StreamingService

    Public Function GetReport() As System.ServiceModel.Channels.Message Implements IATR00130StreamingService.GetReport
        Dim loEx As New R_Exception
        Dim loCls As New ATR00130Cls
        Dim poParam As New ATR00130ParamDTO
        Dim loRtnList As New List(Of ATR00130ReportDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CPERIOD = R_Utility.R_GetStreamingContext("CPERIOD")
                .LALL_TRANSACTION_STATUS = R_Utility.R_GetStreamingContext("LALL_TRANSACTION_STATUS")
                .CTRANSACTION_LIST = R_Utility.R_GetStreamingContext("CTRANSACTION_LIST")
                .CDATE_TYPE_LIST = R_Utility.R_GetStreamingContext("CDATE_TYPE_LIST")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnList = loCls.GetReport(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR00130ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList, "GetReport")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
      
End Class

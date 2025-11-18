Imports R_BackEnd
Imports R_Common
Imports ATI00400Back
Imports ATI00400Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATI00400StreamingService" in code, svc and config file together.
Public Class ATI00400StreamingService
    Implements IATI00400StreamingService

    Public Function GetLogData() As System.ServiceModel.Channels.Message Implements IATI00400StreamingService.getLogData
        Dim loEx As New R_Exception
        Dim loCls As New ATI00400Cls
        Dim poParam As New ATI00400ParamDTO
        Dim loRtnList As New List(Of RSP_AT_ESS_EVENT_LOG_DTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam

                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFILE_TYPE = R_Utility.R_GetStreamingContext("CFILE_TYPE")
                .CDELIMETER = R_Utility.R_GetStreamingContext("CDELIMETER")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")

            End With

            loRtnList = loCls.GetLogData(poParam)
            loList = R_Utility.R_GetChunkData(Of RSP_AT_ESS_EVENT_LOG_DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList, "getLogData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
      
End Class

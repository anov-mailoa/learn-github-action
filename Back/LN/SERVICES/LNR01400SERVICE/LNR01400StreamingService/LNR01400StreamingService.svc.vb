Imports R_Common
Imports R_BackEnd
Imports LNR01400Back
Imports LNR01400Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR01400StreamingService" in code, svc and config file together.
Public Class LNR01400StreamingService
    Implements ILNR01400StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements ILNR01400StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New LNR01400CLS
        Dim loRtnTemp As List(Of LNR01400ReportDTO)
        Dim loRtn As Message
        Dim loParam As New LNR01400DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CTRANSACTION_STATUS_LIST = R_Utility.R_GetStreamingContext("CTRANSACTION_STATUS_LIST")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtnTemp = loCls.getReport(loParam)

            loList = R_Utility.R_GetChunkData(Of LNR01400ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

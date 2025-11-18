Imports R_Common
Imports R_BackEnd
Imports LNR01600Back
Imports LNR01600Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR01600StreamingService" in code, svc and config file together.
Public Class LNR01600StreamingService
    Implements ILNR01600StreamingService

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of LNR01600Back.LNR01600DTO), poPar2 As System.Collections.Generic.List(Of LNR01600Back.LNR01600GridDTO)) Implements ILNR01600StreamingService.Dummy

    End Sub

    Public Function getReport() As System.ServiceModel.Channels.Message Implements ILNR01600StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New LNR01600CLS
        Dim loRtnTemp As List(Of LNR01600ReportDTO)
        Dim loRtn As Message
        Dim loParam As New LNR01600DTO
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

            loList = R_Utility.R_GetChunkData(Of LNR01600ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

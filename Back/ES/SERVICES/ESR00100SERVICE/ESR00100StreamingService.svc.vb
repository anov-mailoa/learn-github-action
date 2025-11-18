Imports R_Common
Imports ESR00100Back
Imports ESR00100Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESR00100StreamingService" in code, svc and config file together.
Public Class ESR00100StreamingService
    Implements IESR00100StreamingService

    Public Sub Dummy(poParam As ESR00100Back.ParameterDTO) Implements IESR00100StreamingService.Dummy

    End Sub

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IESR00100StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New ESR00100CLS
        Dim loRtnTemp As List(Of ESR00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                .CTRANSACTION_TYPES = R_Utility.R_GetStreamingContext("CTRANSACTION_TYPES")
                .CTRANSACTION_STATUS = R_Utility.R_GetStreamingContext("CTRANSACTION_STATUS")
                .IAPPROVER_STATUS = R_Utility.R_GetStreamingContext("IAPPROVER_STATUS")
                .IEMPLOYEE_STATUS = R_Utility.R_GetStreamingContext("IEMPLOYEE_STATUS")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnTemp = loCls.getReportData(loParam)

            loList = R_Utility.R_GetChunkData(Of ESR00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

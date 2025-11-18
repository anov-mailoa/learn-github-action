' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR01100StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR03500Back
Imports PNR03500Common

Public Class PNR03500StreamingService
    Implements IPNR03500StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR03500StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR03500CLS
        Dim loParam As New PNR03500DTO
        Dim loRtnTemp As List(Of PNR03500ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing


        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .LALL_POSITION = R_Utility.R_GetStreamingContext("LALL_POSITION")
                .CSELECT_POSITIONS = R_Utility.R_GetStreamingContext("CSELECT_POSITIONS")
                .LALL_LEVEL_BELOW = R_Utility.R_GetStreamingContext("LALL_LEVEL_BELOW")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
            End With

            loRtnTemp = loCls.GetReportData(loParam)

            loList = R_Utility.R_GetChunkData(Of PNR03500ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As PNR03500Back.PNR03500DTO) Implements IPNR03500StreamingService.Dummy

    End Sub

End Class

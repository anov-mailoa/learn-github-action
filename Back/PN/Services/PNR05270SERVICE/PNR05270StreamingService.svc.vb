Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR05270Back
Imports PNR05270Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR05270StreamingService" in code, svc and config file together.
Public Class PNR05270StreamingService
    Implements IPNR05270StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR05270StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR05270CLS
        Dim loParam As New PNR05270DTO
        Dim loRtnTemp As List(Of PNR05270ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CRELATION_LIST = R_Utility.R_GetStreamingContext("CRELATION_LIST")
                .LALLEMPLOYEE = R_Utility.R_GetStreamingContext("LALLEMPLOYEE")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                .CGROUPBY = R_Utility.R_GetStreamingContext("CGROUPBY")
                .LEXPORTTOEXCEL = R_Utility.R_GetStreamingContext("LEXPORTTOEXCEL")
                .CLANGID = R_Utility.R_GetStreamingContext("CLANGID")
            End With

            loRtnTemp = loCls.GetReportData(loParam)
            loList = R_Utility.R_GetChunkData(Of PNR05270ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As PNR05270Back.PNR05270DTO) Implements IPNR05270StreamingService.Dummy

    End Sub

End Class

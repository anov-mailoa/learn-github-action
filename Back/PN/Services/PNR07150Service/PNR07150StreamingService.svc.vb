Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR07150Back
Imports PNR07150Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR07150StreamingService" in code, svc and config file together.
Public Class PNR07150StreamingService
    Implements IPNR07150StreamingService

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PNR07150Back.PNR07150Dto)) Implements IPNR07150StreamingService.Dummy

    End Sub

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR07150StreamingService.GetReportData
        Dim loException As New R_Exception
        Dim loCls As New PNR07150Cls
        Dim poParam As New PNR07150Dto
        Dim loRtnList As New List(Of PNR07150ReportDto)
        Dim loRtnTemp As List(Of PNR07150ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing


        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.GetReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNR07150ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

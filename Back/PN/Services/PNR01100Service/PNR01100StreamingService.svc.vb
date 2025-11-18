' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR01100StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR01100Back
Imports PNR01100Common

Public Class PNR01100StreamingService
    Implements IPNR01100StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR01100StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR01100BackCLS
        Dim loParam As New PNR01100BackDTO
        Dim loRtnTemp As List(Of PNR01100ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCutOfDate = R_Utility.R_GetStreamingContext("dCutOfDate")
                .cEmployeeIds = R_Utility.R_GetStreamingContext("cEmployeeIds")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.GetReportData(loParam)

            loList = R_Utility.R_GetChunkData(Of PNR01100ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As PNR01100Back.PNR01100BackDTO) Implements IPNR01100StreamingService.Dummy

    End Sub
End Class

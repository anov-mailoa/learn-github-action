Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR05110Back
Imports PNR05110Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR05110StreamingService" in code, svc and config file together.
Public Class PNR05110StreamingService
    Implements IPNR05110StreamingService

    Public Function getAllEmployee() As System.ServiceModel.Channels.Message Implements IPNR05110StreamingService.getAllEmployee
        Dim loException As New R_Exception
        Dim loCls As New PNR05110Cls
        Dim poParam As New PNR05110Dto
        Dim loRtnTemp As List(Of PNR05110StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                '.cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getAllEmployee(poParam)

            loList = R_Utility.R_GetChunkData(Of PNR05110StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAllEmployee")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNR05110StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New PNR05110Cls
        Dim poParam As New PNR05110Dto
        Dim loRtnTemp As List(Of PNR05110ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCutOfDate = R_Utility.R_GetStreamingContext("cCutOfDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .lExternal = R_Utility.R_GetStreamingContext("lExternal")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getReport(poParam)

            loList = R_Utility.R_GetChunkData(Of PNR05110ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PNR05110Back.PNR05110Dto)) Implements IPNR05110StreamingService.Dummy

    End Sub
End Class

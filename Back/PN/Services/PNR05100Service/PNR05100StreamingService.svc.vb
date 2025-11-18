Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR05100Back
Imports PNR05100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR05100StreamingService" in code, svc and config file together.
Public Class PNR05100StreamingService
    Implements IPNR05100StreamingService

    Public Function getAllEmployee() As System.ServiceModel.Channels.Message Implements IPNR05100StreamingService.getAllEmployee
        Dim loException As New R_Exception
        Dim loCls As New PNR05100Cls
        Dim poParam As New PNR05100Dto
        Dim loRtnTemp As List(Of PNR05100StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                '.cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getAllEmployee(poParam)

            loList = R_Utility.R_GetChunkData(Of PNR05100StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAllEmployee")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNR05100StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New PNR05100Cls
        Dim poParam As New PNR05100Dto
        Dim loRtnTemp As List(Of PNR05100ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCutOfDate = R_Utility.R_GetStreamingContext("cCutOfDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .lExternal = R_Utility.R_GetStreamingContext("lExternal")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                '.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getReport(poParam)

            loList = R_Utility.R_GetChunkData(Of PNR05100ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PNR05100Back.PNR05100Dto)) Implements IPNR05100StreamingService.Dummy

    End Sub
End Class

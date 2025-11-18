Imports R_Common
Imports R_BackEnd
Imports LNR10200Back
Imports LNR10200Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR10200StreamingService" in code, svc and config file together.
Public Class LNR10200StreamingService
    Implements ILNR10200StreamingService

    Public Function getGrid() As System.ServiceModel.Channels.Message Implements ILNR10200StreamingService.getGrid
        Dim loEx As New R_Exception
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        Dim loRtnList As List(Of LNR10200GridDTO)
        Dim loCls As New LNR10200CLS
        Dim loParam As New LNR10200DTO


        Try
            With loParam

                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            End With

            loRtnList = loCls.getGrid(loParam)

            loList = R_Utility.R_GetChunkData(Of LNR10200GridDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrid")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function getReport() As System.ServiceModel.Channels.Message Implements ILNR10200StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New LNR10200CLS
        Dim loRtnTemp As List(Of LNR10200ReportDTO)
        Dim loRtn As Message
        Dim loParam As New LNR10200DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_PERIOD = R_Utility.R_GetStreamingContext("CFROM_PERIOD")
                .CTO_PERIOD = R_Utility.R_GetStreamingContext("CTO_PERIOD")
                .CSALARY_GROUP_LIST = R_Utility.R_GetStreamingContext("CSALARY_GROUP_LIST")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtnTemp = loCls.getReport(loParam)

            loList = R_Utility.R_GetChunkData(Of LNR10200ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of LNR10200Back.LNR10200DTO), poPar2 As System.Collections.Generic.List(Of LNR10200Back.LNR10200GridEmpDTO)) Implements ILNR10200StreamingService.Dummy

    End Sub
End Class

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR01100StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR00100Back
Imports PNR00100Common

Public Class PNR00100StreamingService
    Implements IPNR00100StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPNR00100StreamingService.GetReportData
        Dim loEx As New R_Exception
        Dim loCls As New PNR00100BackCLS
        Dim loParam As New PNR00100DTO
        Dim loRtnTemp As List(Of PNR00100ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Dim lcPositions As String
        Dim loPositions As New List(Of PNR00100PositionDTO)

        Try
            With loParam
                .CCCOMPANY_ID = R_Utility.R_GetStreamingContext("CCCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .LSHOW_DIFFERENCE_ONLY = R_Utility.R_GetStreamingContext("LSHOW_DIFFERENCE_ONLY")
            End With

            lcPositions = R_Utility.R_GetStreamingContext("oPositions")
            loPositions = R_Utility.XMLToObject(Of List(Of PNR00100PositionDTO))(lcPositions)

            loRtnTemp = loCls.GetReportData(loParam, loPositions)

            loList = R_Utility.R_GetChunkData(Of PNR00100ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbBox() As System.ServiceModel.Channels.Message Implements IPNR00100StreamingService.GetCmbBox
        Dim loEx As New R_Exception
        Dim loCls As New PNR00100BackCLS
        Dim loParam As New PNR00100DTO
        Dim loRtnTemp As List(Of PNR00100CmbDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing


        Try
            With loParam
                .CCCOMPANY_ID = R_Utility.R_GetStreamingContext("CCCOMPANY_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.GetCmbBox(loParam)

            loList = R_Utility.R_GetChunkData(Of PNR00100CmbDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbBox")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetListPosition() As System.ServiceModel.Channels.Message Implements IPNR00100StreamingService.GetListPosition
        Dim loEx As New R_Exception
        Dim loCls As New PNR00100BackCLS
        Dim loParam As New PNR00100DTO
        Dim loRtnTemp As List(Of PNR00100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With loParam
                .CCCOMPANY_ID = R_Utility.R_GetStreamingContext("CCCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLOCATION_LIST = R_Utility.R_GetStreamingContext("CLOCATION_LIST")
                .CDEPARTMENT_LIST = R_Utility.R_GetStreamingContext("CDEPARTMENT_LIST")
                .CGRADE_LIST = R_Utility.R_GetStreamingContext("CGRADE_LIST")
                .CRANK_LIST = R_Utility.R_GetStreamingContext("CRANK_LIST")
                .CLEVEL_LIST = R_Utility.R_GetStreamingContext("CLEVEL_LIST")
            End With

            loRtnTemp = loCls.GetListPosition(loParam)

            loList = R_Utility.R_GetChunkData(Of PNR00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetListPosition")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As PNR00100Back.PNR00100DTO) Implements IPNR00100StreamingService.Dummy

    End Sub
End Class

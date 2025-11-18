Imports R_Common
Imports System.ServiceModel.Channels
Imports MCR09000Back
Imports MCR09000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR09000StreamingService" in code, svc and config file together.
Public Class MCR09000StreamingService
    Implements IMCR09000StreamingService


    Public Function getReport() As System.ServiceModel.Channels.Message Implements IMCR09000StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New MCR09000Cls
        Dim poParam As New MCR09000Dto
        Dim loRtnList As New List(Of MCR09000ReportDto)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEncrypt = R_Utility.R_GetStreamingContext("cEncrypt")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR09000ReportDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getYear() As System.ServiceModel.Channels.Message Implements IMCR09000StreamingService.getYear
        Dim loException As New R_Exception
        Dim loCls As New MCR09000Cls
        Dim poParam As New MCR09000Dto
        Dim loRtnList As New List(Of MCR09000StreamingDto)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStatus = R_Utility.R_GetStreamingContext("cStatus")
            End With

            loRtnList = loCls.getyear(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR09000StreamingDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loRtnList.AsEnumerable, "getYear")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of MCR09000Back.MCR09000Dto)) Implements IMCR09000StreamingService.Dummy

    End Sub
End Class

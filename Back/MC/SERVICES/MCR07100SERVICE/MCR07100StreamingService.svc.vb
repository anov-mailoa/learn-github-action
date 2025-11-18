Imports R_Common
Imports System.ServiceModel.Channels
Imports MCR07100Back
Imports MCR07100Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR07100StreamingService" in code, svc and config file together.
Public Class MCR07100StreamingService
    Implements IMCR07100StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IMCR07100StreamingService.getReport
        Dim loEx As New R_Exception
        Dim loCls As New MCR07100CLS
        Dim poParam As New MCR07100DTO
        Dim loRtnList As New List(Of MCR07100REPORTDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .LALL_PARTNER = R_Utility.R_GetStreamingContext("LALL_PARTNER")
                .CPARTNER_LIST = R_Utility.R_GetStreamingContext("CPARTNER_LIST")
                .CSORTING_BY = R_Utility.R_GetStreamingContext("CSORTING_BY")
                .CGROUP_BY = R_Utility.R_GetStreamingContext("CGROUP_BY")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR07100REPORTDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of MCR07100Back.MCR07100DTO)) Implements IMCR07100StreamingService.Dummy

    End Sub

    Public Function getYear() As System.ServiceModel.Channels.Message Implements IMCR07100StreamingService.getYear
        Dim loEx As New R_Exception
        Dim loCls As New MCR07100CLS
        Dim poParam As New MCR07100DTO
        Dim loRtnList As New List(Of MCR07100REPORTDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnList = loCls.getYear(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR07100REPORTDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getYear")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB00200Back
Imports MCB00200Common

Public Class MCB00200StreamingService
    Implements IMCB00200StreamingService

    Public Function getMCB00200List() As System.ServiceModel.Channels.Message Implements IMCB00200StreamingService.getMCB00200List
        Dim loEx As New R_Exception
        Dim loParam As New MCB00200DTO
        Dim loCls As New MCB00200Cls
        Dim loRtn As List(Of MCB00200StreamingDto)
        Dim loRtnMsg As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
            End With


            loRtn = loCls.getMCB00200List(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB00200StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMCB00200List")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

End Class

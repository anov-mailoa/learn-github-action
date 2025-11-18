Imports System.ServiceModel.Channels
Imports MCR10000BACK
Imports MCR10000COMMON
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR10000StreamingService" in code, svc and config file together.
Public Class MCR10000StreamingService
    Implements IMCR10000StreamingService

    Public Function GetReport() As System.ServiceModel.Channels.Message Implements IMCR10000StreamingService.GetReport
        Dim loException As New R_Exception
        Dim poParam As New MCR10000DTO
        Dim loCls As New MCR10000Cls
        Dim loRtnList As New List(Of MCR10000ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("CEMPLOYEE_LIST")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnList = loCls.GetReport(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR10000ReportDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetYear(pcCompId As String) As String Implements IMCR10000StreamingService.GetYear
        Dim loException As New R_Exception
        Dim loCls As New MCR10000Cls
        Dim lcRtn As String = ""

        Try

            lcRtn = loCls.GetYear(pcCompId)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of MCR10000BACK.MCR10000DTO)) Implements IMCR10000StreamingService.Dummy

    End Sub
End Class

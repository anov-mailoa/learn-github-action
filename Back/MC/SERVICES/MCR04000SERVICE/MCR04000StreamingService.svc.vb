Imports R_Common
Imports System.ServiceModel.Channels
Imports MCR04000Back
Imports MCR04000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR04000StreamingService" in code, svc and config file together.
Public Class MCR04000StreamingService
    Implements IMCR04000StreamingService


    Public Function getReport() As System.ServiceModel.Channels.Message Implements IMCR04000StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New MCR04000Cls
        Dim poParam As New MCR04000Dto
        Dim loRtnList As New List(Of MCR04000ReportDto)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cEncrypt = R_Utility.R_GetStreamingContext("cEncrypt")
                .cReport = R_Utility.R_GetStreamingContext("cReport")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .LWITH_SUBITEM = R_Utility.R_GetStreamingContext("LWITH_SUBITEM")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR04000ReportDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of MCR04000Back.MCR04000Dto)) Implements IMCR04000StreamingService.Dummy

    End Sub
End Class

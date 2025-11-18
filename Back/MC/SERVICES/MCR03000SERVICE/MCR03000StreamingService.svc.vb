Imports R_Common
Imports System.ServiceModel.Channels
Imports MCR03000Back
Imports MCR03000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR03000StreamingService" in code, svc and config file together.
Public Class MCR03000StreamingService
    Implements IMCR03000StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IMCR03000StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New MCR03000Cls
        Dim poParam As New MCR03000Dto
        Dim loRtnList As New List(Of MCR03000ReportDto)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cAllEmployee = R_Utility.R_GetStreamingContext("cAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cEncrypt = R_Utility.R_GetStreamingContext("cEncrypt")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR03000ReportDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

End Class

Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00550Back
Imports ATR00550Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00550StreamingService" in code, svc and config file together.
Public Class ATR00550StreamingService
    Implements IATR00550StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR00550StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR00550CLS
        Dim poParam As New ATR00550DTO
        Dim loRtnList As List(Of ATR00550ReportDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .lAllEmp = R_Utility.R_GetStreamingContext("lAllEmp")
                .cEmpList = R_Utility.R_GetStreamingContext("cEmpList")
                .lAllGrp = R_Utility.R_GetStreamingContext("lAllGrp")
                .cGrpList = R_Utility.R_GetStreamingContext("cGrpList")
                .lHaveOvt = R_Utility.R_GetStreamingContext("lHaveOvt")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR00550ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ATR00150Common
Imports ATR00150Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00150StreamingService" in code, svc and config file together.
Public Class ATR00150StreamingService
    Implements IATR00150StreamingService


    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR00150StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR00150Cls
        Dim poParam As New ATR00150DTO
        Dim loRtnList As New List(Of ATR00150NewReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("cEmployeeList")
            poParam.CFROM_YEAR = R_Utility.R_GetStreamingContext("cFromYear")
            poParam.CTO_YEAR = R_Utility.R_GetStreamingContext("cToYear")
            poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")

            loRtnList = loCls.GetReport(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR00150NewReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "Report")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAllEmployee() As System.ServiceModel.Channels.Message Implements IATR00150StreamingService.getAllEmployee
        Dim loException As New R_Exception
        Dim loCls As New ATR00150Cls
        Dim poParam As New ATR00150DTO
        Dim loRtnList As New List(Of ATR00150StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
            End With

            loRtnList = loCls.getAllEmployee(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR00150StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loRtnList.AsEnumerable, "getAllEmployee")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

  
    Public Sub Dummy(poPar As System.Collections.Generic.List(Of ATR00150Back.ATR00150ReportDTO), popar2 As System.Collections.Generic.List(Of ATR00150Back.ATR00150DTO)) Implements IATR00150StreamingService.Dummy

    End Sub
End Class

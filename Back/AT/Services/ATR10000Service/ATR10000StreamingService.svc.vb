Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ATR10000Common
Imports ATR10000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR10000StreamingService" in code, svc and config file together.
Public Class ATR10000StreamingService
    Implements IATR10000StreamingService


    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR10000StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR10000Cls
        Dim poParam As New ATR10000DTO
        Dim loRtnList As New List(Of ATR10000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("cCompanyId")
                .CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("cEmployeeList")
                .CFROM_YEAR = R_Utility.R_GetStreamingContext("cFromYear")
                .CTO_YEAR = R_Utility.R_GetStreamingContext("cToYear")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("cLanguageId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.GetReport(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR10000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "Report")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAllEmployee() As System.ServiceModel.Channels.Message Implements IATR10000StreamingService.getAllEmployee
        Dim loException As New R_Exception
        Dim loCls As New ATR10000Cls
        Dim poParam As New ATR10000DTO
        Dim loRtnList As New List(Of ATR10000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
            End With

            loRtnList = loCls.getAllEmployee(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR10000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loRtnList.AsEnumerable, "getAllEmployee")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

  
    Public Sub Dummy(poPar As System.Collections.Generic.List(Of ATR10000Back.ATR10000ReportDTO), popar2 As System.Collections.Generic.List(Of ATR10000Back.ATR10000DTO)) Implements IATR10000StreamingService.Dummy

    End Sub
End Class

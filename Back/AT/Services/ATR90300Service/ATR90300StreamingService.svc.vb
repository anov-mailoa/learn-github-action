Imports R_BackEnd
Imports R_Common
Imports ATR90300Back
Imports ATR90300Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR90300StreamingService" in code, svc and config file together.
Public Class ATR90300StreamingService
    Implements IATR90300StreamingService

    Public Function GetReport() As System.ServiceModel.Channels.Message Implements IATR90300StreamingService.GetReport
        Dim loEx As New R_Exception
        Dim loCls As New ATR90300Cls
        Dim poParam As New ATR90300ParamDTO
        Dim loRtnList As New List(Of ATR90300ReportDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                ._cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                ._cYear = R_Utility.R_GetStreamingContext("cYear")
                ._iAllTransStat = R_Utility.R_GetStreamingContext("iAllTransStat")
                ._cTransList = R_Utility.R_GetStreamingContext("cTransList")
                ._iAllEmployee = R_Utility.R_GetStreamingContext("iAllEmployee")
                ._cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                ._cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                ._cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.GetReport(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR90300ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList, "GetReport")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(popar2 As System.Collections.Generic.List(Of ATR90300Back.ATR90300ParamDTO)) Implements IATR90300StreamingService.Dummy

    End Sub

End Class

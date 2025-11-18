Imports R_BackEnd
Imports R_Common
Imports ATR90700Back
Imports ATR90700Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR90700StreamingService" in code, svc and config file together.
Public Class ATR90700StreamingService
    Implements IATR90700StreamingService

    Public Function GetReport() As System.ServiceModel.Channels.Message Implements IATR90700StreamingService.GetReport
        Dim loEx As New R_Exception
        Dim loCls As New ATR90700Cls
        Dim poParam As New ATR90700ParamDTO
        Dim loRtnList As New List(Of ATR90700ReportDTO)
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
            loList = R_Utility.R_GetChunkData(Of ATR90700ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList, "GetReport")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(popar2 As System.Collections.Generic.List(Of ATR90700Back.ATR90700ParamDTO)) Implements IATR90700StreamingService.Dummy

    End Sub

End Class

Imports R_BackEnd
Imports R_Common
Imports ATR91000Back
Imports ATR91000Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR91000StreamingService" in code, svc and config file together.
Public Class ATR91000StreamingService
    Implements IATR91000StreamingService

    Public Function GetReport() As System.ServiceModel.Channels.Message Implements IATR91000StreamingService.GetReport
        Dim loEx As New R_Exception
        Dim loCls As New ATR91000Cls
        Dim poParam As New ATR91000ParamDTO
        Dim loRtnList As New List(Of ATR91000ReportDTO)
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
            End With

            loRtnList = loCls.GetReport(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR91000ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList, "GetReport")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetLookUp() As System.ServiceModel.Channels.Message Implements IATR91000StreamingService.GetLookUp
        Dim loEx As New R_Exception
        Dim loCls As New ATR91000Cls
        Dim poParam As New ATR91000ParamDTO
        Dim loRtnList As New List(Of ATR91000LookUpDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                ._cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                ._cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnList = loCls.GetLookUp(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR91000LookUpDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList, "GetLookUp")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(popar2 As System.Collections.Generic.List(Of ATR91000Back.ATR91000ParamDTO)) Implements IATR91000StreamingService.Dummy

    End Sub
End Class

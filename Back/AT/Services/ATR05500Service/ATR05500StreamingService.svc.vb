' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR05500StreamingService" in code, svc and config file together.
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR05500Back
Imports ATR05500Common
Imports R_BackEnd
Public Class ATR05500StreamingService
    Implements IATR05500StreamingService

    Public Sub Dummy(popar2 As System.Collections.Generic.List(Of ATR05500Back.ATR05500DTO)) Implements IATR05500StreamingService.Dummy

    End Sub

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR05500StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR05500CLS
        Dim poParam As New ATR05500DTO
        Dim loRtnList As New List(Of ATR05500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.GetData(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR05500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

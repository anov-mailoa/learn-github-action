' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR06000StreamingService" in code, svc and config file together.
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR06000Back
Imports ATR06000Common
Imports R_BackEnd
Public Class ATR06000StreamingService
    Implements IATR06000StreamingService


    Public Sub Dummy(popar2 As System.Collections.Generic.List(Of ATR06000Back.ATR06000DTO)) Implements IATR06000StreamingService.Dummy

    End Sub

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR06000StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR06000CLS
        Dim poParam As New ATR06000DTO
        Dim loRtnList As New List(Of ATR06000StreamingDTO)
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
            loList = R_Utility.R_GetChunkData(Of ATR06000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

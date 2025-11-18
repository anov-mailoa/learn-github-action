Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR90800Back
Imports ATR90800Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR90800StreamingService" in code, svc and config file together.
Public Class ATR90800StreamingService
    Implements IATR90800StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR90800StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR90800CLS
        Dim poParam As New ATR90800DTO
        Dim loRtnList As New List(Of ATR90800StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lActivePeriod = R_Utility.R_GetStreamingContext("lActivePeriod")
                .cLeaveType = R_Utility.R_GetStreamingContext("cLeaveType")
                .cFilterBy = R_Utility.R_GetStreamingContext("cFilterBy")
                .lAllFilter = R_Utility.R_GetStreamingContext("lAllFilter")
                .cFilterList = R_Utility.R_GetStreamingContext("cFilterList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.GetData(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR90800StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

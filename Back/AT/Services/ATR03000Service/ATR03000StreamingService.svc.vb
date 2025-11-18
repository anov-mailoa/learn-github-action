' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR03000StreamingService" in code, svc and config file together.
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR03000Back
Imports ATR03000Common
Imports R_BackEnd

Public Class ATR03000StreamingService
    Implements IATR03000StreamingService


    Public Sub Dummy(popar2 As System.Collections.Generic.List(Of ATR03000Back.ATR03000DTO)) Implements IATR03000StreamingService.Dummy

    End Sub

    Public Function GetData() As System.ServiceModel.Channels.Message Implements IATR03000StreamingService.GetData
        Dim loException As New R_Exception
        Dim loCls As New ATR03000CLS
        Dim poParam As New ATR03000DTO
        Dim loRtnList As New List(Of ATR03000StreamingDTo)
        Dim loRtn As Message
        Dim loList As New List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmpWorkGroupList = R_Utility.R_GetStreamingContext("cEmpWorkGroupList")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .lAllEmpWorkGroup = R_Utility.R_GetStreamingContext("lAllEmpWorkGroup")
                .cFilterBy = R_Utility.R_GetStreamingContext("cFilterBy")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.GetData(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR03000StreamingDTo)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01100StreamingService" in code, svc and config file together.
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR01100Back
Imports ATR01100Common
Imports R_BackEnd
Public Class ATR01100StreamingService
    Implements IATR01100StreamingService

    Public Sub Dummy(popar2 As System.Collections.Generic.List(Of ATR01100Back.ATR01100DTO)) Implements IATR01100StreamingService.Dummy

    End Sub

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR01100StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR01100CLS
        Dim poParam As New ATR01100DTO
        Dim loRtnList As List(Of ATR01100StreamingDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
            End With

            loRtnList = loCls.GetData(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR01100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class

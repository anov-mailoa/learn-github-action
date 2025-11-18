' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00100StreamingService" in code, svc and config file together.
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00100Back
Imports ATR00100Common
Imports R_BackEnd

Public Class ATR00100StreamingService
    Implements IATR00100StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR00100StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR00100CLS
        Dim poParam As New ATR00100DTO
        Dim loRtnList As List(Of ATR00100StreamingDTO)
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
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnList = loCls.getData(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR00100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class

Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR90100Back
Imports ATR90100Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR90100StreamingService" in code, svc and config file together.
Public Class ATR90100StreamingService
    Implements IATR90100StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR90100StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR90100CLS
        Dim poParam As New ATR90100DTO
        Dim loRtnList As New List(Of ATR90100StreamingDTO)
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
                .lTransactionStatus = R_Utility.R_GetStreamingContext("lTransactionStatus")
                .cTransactionList = R_Utility.R_GetStreamingContext("cTransactionList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.GetData(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR90100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR90500Back
Imports ATR90500Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR90500StreamingService" in code, svc and config file together.
Public Class ATR90500StreamingService
    Implements IATR90500StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR90500StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR90500CLS
        Dim poParam As New ATR90500DTO
        Dim loRtnList As New List(Of ATR90500StreamingDTO)
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
                .cTransactionTypeList = R_Utility.R_GetStreamingContext("cTransactionTypeList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.GetData(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR90500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmb() As System.ServiceModel.Channels.Message Implements IATR90500StreamingService.getCmb
        Dim loException As New R_Exception
        Dim loCls As New ATR90500CLS
        Dim poParam As New ATR90500DTO
        Dim loRtnList As New List(Of ATR90500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getCmb(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR90500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmb")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

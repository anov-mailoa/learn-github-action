Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR05000Back
Imports ATR05000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR05000StreamingService" in code, svc and config file together.
Public Class ATR05000StreamingService
    Implements IATR05000StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR05000StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATR05000CLS
        Dim poParam As New ATR05000DTO
        Dim loRtnList As New List(Of ATR05000StreamingDTO)
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
            loList = R_Utility.R_GetChunkData(Of ATR05000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAllEmployee() As System.ServiceModel.Channels.Message Implements IATR05000StreamingService.getAllEmployee
        Dim loException As New R_Exception
        Dim loCls As New ATR05000CLS
        Dim poParam As New ATR05000DTO
        Dim loRtnList As New List(Of ATR05000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
            End With

            loRtnList = loCls.getAllEmployee(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR05000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAllEmployee")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(popar2 As System.Collections.Generic.List(Of ATR05000Back.ATR05000DTO)) Implements IATR05000StreamingService.Dummy

    End Sub

End Class

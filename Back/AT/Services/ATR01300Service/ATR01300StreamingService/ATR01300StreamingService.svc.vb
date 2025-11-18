Imports R_BackEnd
Imports R_Common
Imports ATR01300Back
Imports System.ServiceModel.Channels
Imports ATR01300Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01300StreamingService" in code, svc and config file together.
Public Class ATR01300StreamingService
    Implements IATR01300StreamingService
    Public Function getSP() As System.ServiceModel.Channels.Message Implements IATR01300StreamingService.getSP
        Dim loException As New R_Exception
        Dim loCls As New ATR01300Cls
        Dim loRtn As New List(Of ATR01300StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATR01300DTO
        Dim loList As List(Of Byte())

        Try
            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("cCompId")
            poParam.CEMPLOYEE_LIST = R_Utility.R_GetStreamingContext("cEmployeeList")
            poParam.CYEAR = R_Utility.R_GetStreamingContext("cYear")
            poParam.CLEAVE_TYPE = R_Utility.R_GetStreamingContext("cLeaveType")
            poParam.CLEAVE_LIST = R_Utility.R_GetStreamingContext("cLeaveList")
            poParam.LMOVEMENT = R_Utility.R_GetStreamingContext("lMovement")
            poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")

            loRtn = loCls.getSP(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR01300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "SPData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListView() As System.ServiceModel.Channels.Message Implements IATR01300StreamingService.getListView
        Dim loException As New R_Exception
        Dim loCls As New ATR01300Cls
        Dim loRtn As New List(Of ATR01300ListViewStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATR01300ListViewDTO
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLeaveType = R_Utility.R_GetStreamingContext("cLeaveType")
            loRtn = loCls.getListView(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR01300ListViewStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "ListViewData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of ATR01300Back.ATR01300DTO), poParDTO As System.Collections.Generic.List(Of ATR01300Back.ATR01300ListViewDTO)) Implements IATR01300StreamingService.Dummy

    End Sub
End Class

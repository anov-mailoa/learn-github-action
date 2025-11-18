Imports System.ServiceModel
Imports R_Common
Imports ATT90900Back
Imports ATT90900Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90900StreamService" in code, svc and config file together.
Public Class ATT90900StreamService
    Implements IATT90900StreamService

    Public Function GetLeaveList() As System.ServiceModel.Channels.Message Implements IATT90900StreamService.GetLeaveList
        Dim loException As New R_Exception
        Dim loCls As New ATT90900CLS
        Dim loRtnTemp As List(Of ATT90900StreamDto)
        Dim loParam As New ATT90900Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
        End With

        Try
            loRtnTemp = loCls.GetLeaveList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90900StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLeaveList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMonthList() As System.ServiceModel.Channels.Message Implements IATT90900StreamService.GetMonthList
        Dim loException As New R_Exception
        Dim loCls As New ATT90900CLS
        Dim loRtnTemp As List(Of ATT90900StreamDto)
        Dim loParam As New ATT90900Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
        End With

        Try
            loRtnTemp = loCls.GetMonthList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90900StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetMonthList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTransactionHistoryList() As System.ServiceModel.Channels.Message Implements IATT90900StreamService.GetTransactionHistoryList
        Dim loException As New R_Exception
        Dim loCls As New ATT90900CLS
        Dim loRtnTemp As List(Of ATT90900StreamDto)
        Dim loParam As New ATT90900Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            .cYear = R_Utility.R_GetStreamingContext("cYear")
            .cMonth = R_Utility.R_GetStreamingContext("cMonth")
        End With

        Try
            loRtnTemp = loCls.GetTransactionHistoryList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90900StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransactionHistoryList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTransactionList() As System.ServiceModel.Channels.Message Implements IATT90900StreamService.GetTransactionList
        Dim loException As New R_Exception
        Dim loCls As New ATT90900CLS
        Dim loRtnTemp As List(Of ATT90900StreamDto)
        Dim loParam As New ATT90900Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
        End With

        Try
            loRtnTemp = loCls.GetTransactionList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90900StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransactionList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

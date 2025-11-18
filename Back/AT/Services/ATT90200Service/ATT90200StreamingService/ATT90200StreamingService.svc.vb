Imports R_BackEnd
Imports R_Common
Imports ATT90200Back
Imports ATT90200Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90200StreamingService" in code, svc and config file together.
Public Class ATT90200StreamingService
    Implements IATT90200StreamingService

    Public Function getLeave() As System.ServiceModel.Channels.Message Implements IATT90200StreamingService.getLeave
        Dim loException As New R_Exception
        Dim loCls As New ATT90200Cls
        Dim poParam As New ATT90200DTO
        Dim loRtnTemp As List(Of ATT90200StreamingDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtnTemp = loCls.getLeave(poParam)
            loList = R_Utility.R_GetChunkData(Of ATT90200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "LeaveData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IATT90200StreamingService.getEmployee
        Dim loException As New R_Exception
        Dim loCls As New ATT90200Cls
        Dim loRtn As New List(Of ATT90201StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATT90201DTO
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtn = loCls.getEmployee(poParam)
            loList = R_Utility.R_GetChunkData(Of ATT90201StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "EmployeeData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getHistoryEmployee() As System.ServiceModel.Channels.Message Implements IATT90200StreamingService.getHistoryEmployee
        Dim loException As New R_Exception
        Dim loCls As New ATT90220Cls
        Dim loRtn As New List(Of ATT90221StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATT90221DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtn = loCls.getHistoryEmployee(poParam)
            loList = R_Utility.R_GetChunkData(Of ATT90221StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "HistoryEmployeeData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getHistoryLeave() As System.ServiceModel.Channels.Message Implements IATT90200StreamingService.getHistoryLeave
        Dim loException As New R_Exception
        Dim loCls As New ATT90220Cls
        Dim loRtn As New List(Of ATT90220StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATT90220DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            poParam.cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
            poParam.lCanceled = R_Utility.R_GetStreamingContext("lCanceled")
            poParam.lClosed = R_Utility.R_GetStreamingContext("lClosed")
            poParam.lDeleted = R_Utility.R_GetStreamingContext("lDeleted")
            loRtn = loCls.getHistoryLeave(poParam)
            loList = R_Utility.R_GetChunkData(Of ATT90220StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "HistoryLeaveData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getAdditional() As System.ServiceModel.Channels.Message Implements IATT90200StreamingService.getAdditional
        Dim loException As New R_Exception
        Dim loCls As New ATT90230Cls
        Dim loRtn As New List(Of ATT90230StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATT90230DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtn = loCls.getAdditional(poParam)
            loList = R_Utility.R_GetChunkData(Of ATT90230StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "AdditionalData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getOvertime() As System.ServiceModel.Channels.Message Implements IATT90200StreamingService.getOvertime
        Dim loException As New R_Exception
        Dim loCls As New ATT90210Cls
        Dim loRtn As New List(Of ATT90210StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATT90210DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")

            loRtn = loCls.getOvertime(poParam)
            loList = R_Utility.R_GetChunkData(Of ATT90210StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "OvertimeData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poParATT00601 As System.Collections.Generic.List(Of ATT90200Back.ATT90201DTO), poParATT00621 As System.Collections.Generic.List(Of ATT90200Back.ATT90221DTO), poParATT00612 As System.Collections.Generic.List(Of ATT90200Back.ATT90212DTO)) Implements IATT90200StreamingService.Dummy

    End Sub
End Class

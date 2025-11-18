' NOTE: You can use the "Rename" command on the context menu to change the class name "ATI00300SreamingService" in code, svc and config file together.
Imports System.ServiceModel
Imports ATI00300Back
Imports ATI00300Common
Imports R_Common
Imports System.ServiceModel.Channels
Imports R_Common.R_Utility
Imports R_BackEnd
Public Class ATI00300StreamingService
    Implements IATI00300StreamingService
     
    Public Function getOvtCalc() As System.ServiceModel.Channels.Message Implements IATI00300StreamingService.getOvtCalc
        Dim loRtn As New List(Of ATI00300OvtCalcDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATI00300CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATI00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtn = loCls.getOvtCalc(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATI00300OvtCalcDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getOvtCalc")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getLeave() As System.ServiceModel.Channels.Message Implements IATI00300StreamingService.getLeave

        Dim loRtn As New List(Of ATT00300LeaveDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATI00300CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATI00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtn = loCls.getLeave(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00300LeaveDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage


    End Function

    Public Function getOvertime() As System.ServiceModel.Channels.Message Implements IATI00300StreamingService.getOvertime

        Dim loRtn As New List(Of ATI00300OvertimeDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATI00300CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATI00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtn = loCls.getOvertime(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATI00300OvertimeDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getOvertime")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage


    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IATI00300StreamingService.getEmployee

        Dim loRtn As New List(Of ATI00300EmployeeListDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATI00300CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATI00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtn = loCls.getEmployee(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATI00300EmployeeListDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage


    End Function

    Public Function getLeaveBalance() As System.ServiceModel.Channels.Message Implements IATI00300StreamingService.getLeaveBalance

        Dim loRtn As New List(Of ATI00300LeaveBalanceDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATI00300CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATI00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtn = loCls.getLeaveBalance(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATI00300LeaveBalanceDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getLeaveBalance")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getDaily() As System.ServiceModel.Channels.Message Implements IATI00300StreamingService.getDaily

        Dim loRtn As List(Of ATT00300DailyDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATI00300CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATI00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CSHIFT_DATE = R_Utility.R_GetStreamingContext("CSHIFT_DATE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtn = loCls.getDaily(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00300DailyDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getDaily")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getSchedule() As System.ServiceModel.Channels.Message Implements IATI00300StreamingService.getSchedule

        Dim loRtn As List(Of ATT00300ScheduleDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATI00300CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATI00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtn = loCls.getSchedule(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00300ScheduleDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getSchedule")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getAttendance() As System.ServiceModel.Channels.Message Implements IATI00300StreamingService.getAttendance

        Dim loRtn As List(Of ATT00300AttendannceDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATI00300CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATI00300DTO
        Dim loChunk As New List(Of Byte())


        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtn = loCls.getAttendance(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00300AttendannceDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getAttendance")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function
End Class

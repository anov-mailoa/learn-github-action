Imports System.ServiceModel
Imports R_Common
Imports ATM00600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports ATM00600Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00600StreamingService" in code, svc and config file together.
Public Class ATM00600StreamingService
    Implements IATM00600StreamingService
     
    Public Function getListATM00600() As System.ServiceModel.Channels.Message Implements IATM00600StreamingService.getListATM00600
        Dim loRtn As Message
        Dim loCls As New ATM00600CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATM00600DTO
        Dim loRtnTemp As New List(Of ATM00600STREAMINGDTO)
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With
            loRtnTemp = loCls.getListATM00600(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00600STREAMINGDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "AmbilDatas")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getListATMPatternShift() As System.ServiceModel.Channels.Message Implements IATM00600StreamingService.getListATMPatternShift
        Dim loRtn As Message
        Dim loCls As New ATM00610ShiftPatternCLS
        Dim loEx As New R_Exception
        Dim poParam As New ATM00610ShiftPatternDTO
        Dim loRtnTemp As New List(Of ATM00610StreamShiftPatternDTO)
        Dim loList As List(Of Byte())


        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With
            loRtnTemp = loCls.getListAtmShiftPattern(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00610StreamShiftPatternDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "StreamShiftPattern")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getListATMPatternSeq() As System.ServiceModel.Channels.Message Implements IATM00600StreamingService.getListATMPatternSeq
        Dim loRtn As Message
        Dim loCls As New ATM00610PatternSeqCLS
        Dim loEx As New R_Exception
        Dim poParam As New ATM00610PatternSeqDTO
        Dim loRtnTemp As New List(Of ATM00610StreamPatternSeqDTO)
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPatternCode = R_Utility.R_GetStreamingContext("cPatternCode")
            End With
            loRtnTemp = loCls.getListATMPatternSeq(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00610StreamPatternSeqDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "StreamPatternSeq")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getDetail() As System.ServiceModel.Channels.Message Implements IATM00600StreamingService.getDetail
        Dim loRtn As Message
        Dim loCls As New ATM00620WorkGroupEmpCls
        Dim loEx As New R_Exception
        Dim poParam As New ATM00620WorkGroupEmpDTO
        Dim loRtnTemp As New List(Of ATM00620WorkGroupEmpGridDTO)
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .dDateNow = R_Utility.R_GetStreamingContext("dDateNow")
            End With
            loRtnTemp = loCls.getDetail(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00620WorkGroupEmpGridDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getMasterWorkTable() As System.ServiceModel.Channels.Message Implements IATM00600StreamingService.getMasterWorkTable
        Dim loEx As New R_Exception
        Dim loCls As New ATM00620WorkGroupCls
        Dim loRtnTemp As List(Of ATM00620GridWorkGroupDTO)
        Dim loRtn As Message
        Dim loParam As New ATM00620WorkGroupDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getMasterWorkTable(loParam)

            loList = R_Utility.R_GetChunkData(Of ATM00620GridWorkGroupDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMasterWorkTable")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetResultPreviewProcess() As System.ServiceModel.Channels.Message Implements IATM00600StreamingService.GetResultPreviewProcess
        Dim loRtn As Message
        Dim loCls As New ATM00620WGScheduleCls
        Dim loEx As New R_Exception
        Dim poParam As New ATM00620WGScheduleDTO
        Dim loRtnTemp As List(Of ATM00620GridWGScheduleDTO)
        Dim loList As List(Of Byte())

        Try
            With poParam
                .COMPANY_ID = R_Utility.R_GetStreamingContext("COMPANY_ID")
                .USER_ID = R_Utility.R_GetStreamingContext("USER_ID")
                .cScheduleStart = R_Utility.R_GetStreamingContext("cScheduleStrDate")
                .cScheduleTo = R_Utility.R_GetStreamingContext("cScheduleEndDate")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With
            loRtnTemp = loCls.getDataProcess(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00620GridWGScheduleDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetResultPreviewProcess")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
     
    Public Function getDataProcess() As System.ServiceModel.Channels.Message Implements IATM00600StreamingService.getDataProcess

    End Function

    Public Function getScheduleRGB() As System.ServiceModel.Channels.Message Implements IATM00600StreamingService.getScheduleRGB
        Dim loEx As New R_Exception
        Dim loCls As New ATM00620WGScheduleCls
        Dim loRtnTemp As List(Of ATM00620GridWGScheduleDTO)
        Dim loRtn As Message
        Dim loParam As New ATM00620WGScheduleDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getScheduleRGB(loParam)

            loList = R_Utility.R_GetChunkData(Of ATM00620GridWGScheduleDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getScheduleRGB")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getHoliday() As System.ServiceModel.Channels.Message Implements IATM00600StreamingService.getHoliday
        Dim loEx As New R_Exception
        Dim loCls As New ATM00620WGScheduleCls
        Dim loRtnTemp As List(Of ATM00620GridWGScheduleDTO)
        Dim loRtn As Message
        Dim loParam As New ATM00620WGScheduleDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cHolidayPeriod = R_Utility.R_GetStreamingContext("cHolidayPeriod")
            End With

            loRtnTemp = loCls.getHoliday(loParam)

            loList = R_Utility.R_GetChunkData(Of ATM00620GridWGScheduleDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHoliday")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParReguler As System.Collections.Generic.List(Of ATM00600Back.ATM00610RegulerShiftPatternDTO)) Implements IATM00600StreamingService.Dummy

    End Sub

    Public Sub Dummy1(poParReguler As System.Collections.Generic.List(Of ATM00600Back.ATM00600REGULERDTO)) Implements IATM00600StreamingService.Dummy1

    End Sub

    Public Sub Dummy2(poParReguler As System.Collections.Generic.List(Of ATM00600Back.ATM00610RegulerPatternSeqDTO)) Implements IATM00600StreamingService.Dummy2

    End Sub

    Public Sub Dummy4(ByRef poPar2 As System.Collections.Generic.List(Of ATM00600Back.ATM00620WorkGroupRegDTO)) Implements IATM00600StreamingService.Dummy4

    End Sub

End Class

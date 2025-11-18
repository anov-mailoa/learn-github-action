Imports R_Common
Imports ESM01400Back
Imports ESM01400Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01400StreamingService" in code, svc and config file together.
Public Class ESM01400StreamingService
    Implements IESM01400StreamingService

    Public Function getTreeList() As System.ServiceModel.Channels.Message Implements IESM01400StreamingService.getTreeList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01400CLS
        Dim loRtnTemp As List(Of ESM01400StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01400ParameterDTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .LINCLUDEBELOW = R_Utility.R_GetStreamingContext("LINCLUDEBELOW")
            End With

            loRtnTemp = loCls.getTreeList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01400StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTreeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getEmployeeList() As System.ServiceModel.Channels.Message Implements IESM01400StreamingService.getEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01400CLS
        Dim loRtnTemp As List(Of ESM01400StreamingEmployeeDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01400ParameterDTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CPOSITION_ID = R_Utility.R_GetStreamingContext("CPOSITION_ID")
            End With

            loRtnTemp = loCls.getEmployeeList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01400StreamingEmployeeDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployeeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployeeLeaveInfo() As System.ServiceModel.Channels.Message Implements IESM01400StreamingService.getEmployeeLeaveInfo
        Dim loEx As New R_Exception
        Dim loCls As New ESM01400CLS
        Dim loRtnTemp As List(Of ESM01400EmployeeLeaveDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01400ParameterDTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CPOSITION_ID = R_Utility.R_GetStreamingContext("CPOSITION_ID")
            End With

            loRtnTemp = loCls.getEmployeeLeaveInfo(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01400EmployeeLeaveDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployeeLeaveInfo")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployeeAttendanceList() As System.ServiceModel.Channels.Message Implements IESM01400StreamingService.getEmployeeAttendanceList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01400CLS
        Dim loRtnTemp As List(Of EmployeeAttendanceDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01400ParameterDTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CDATEFROM = R_Utility.R_GetStreamingContext("CDATEFROM")
                .CDATETO = R_Utility.R_GetStreamingContext("CDATETO")
            End With

            loRtnTemp = loCls.getEmployeeAttendanceList(loParam)

            loList = R_Utility.R_GetChunkData(Of EmployeeAttendanceDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployeeAttendanceList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getHistoryLeaveInfo() As System.ServiceModel.Channels.Message Implements IESM01400StreamingService.getHistoryLeaveInfo
        Dim loEx As New R_Exception
        Dim loCls As New ESM01400CLS
        Dim loRtnTemp As List(Of ESM01400HistroyLeaveDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01400ParameterDTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.getHistoryLeaveInfo(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01400HistroyLeaveDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHistoryLeaveInfo")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployeeData() As System.ServiceModel.Channels.Message Implements IESM01400StreamingService.getEmployeeData
        Dim loEx As New R_Exception
        Dim loCls As New ESM01400CLS
        Dim loRtnTemp As List(Of EmployeePersonalDataDTO)
        Dim loParam As New ESM01400ParameterDTO
        Dim loList As List(Of Byte())
        Dim loRtn As Message

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.getEmployeeData(loParam)
            loList = R_Utility.R_GetChunkData(Of EmployeePersonalDataDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployeeData")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getOvertimeCalcIndex() As System.ServiceModel.Channels.Message Implements IESM01400StreamingService.getOvertimeCalcIndex
        Dim loEx As New R_Exception
        Dim loCls As New ESM01400CLS
        Dim loRtnTemp As List(Of ESM01400StreamingEmployeeDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01400ParameterDTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CDATEFROM = R_Utility.R_GetStreamingContext("CDATEFROM")
                .CDATETO = R_Utility.R_GetStreamingContext("CDATETO")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.getOvertimeCalcIndex(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01400StreamingEmployeeDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getOvertimeCalcIndex")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

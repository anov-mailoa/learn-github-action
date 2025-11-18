Imports R_Common
Imports ESM01200Back
Imports System.ServiceModel.Channels
Imports ESM01200Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01100StreamingService" in code, svc and config file together.
Public Class ESM01200StreamingService
    Implements IESM01200StreamingService

    Public Function getMyActivity() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getMyActivity
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200CLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CMONTH = R_Utility.R_GetStreamingContext("CMONTH")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnTemp = loCls.getMyActivity(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMyActivity")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getOvtList() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getOvtList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .ITRANSACTION_TYPE = R_Utility.R_GetStreamingContext("ITRANSACTION_TYPE")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CHISTORY_FROM_DATE = R_Utility.R_GetStreamingContext("CHISTORY_FROM_DATE")
                .CHISTORY_TO_DATE = R_Utility.R_GetStreamingContext("CHISTORY_TO_DATE")
                .CHISTORY_STATUS = R_Utility.R_GetStreamingContext("CHISTORY_STATUS")
            End With

            loRtnTemp = loCls.getOvtList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getOvtList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getOvtType() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getOvtType
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .ISHIFT_TYPE = R_Utility.R_GetStreamingContext("ISHIFT_TYPE")
                .IDAY_TYPE = R_Utility.R_GetStreamingContext("IDAY_TYPE")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnTemp = loCls.getOvtType(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getOvtType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getShiftList() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getShiftList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.getShiftList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getShiftList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLeaveList() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getLeaveList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200LeaveCLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .ITRANSACTION_TYPE = R_Utility.R_GetStreamingContext("ITRANSACTION_TYPE")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CLEAVE_TYPE = R_Utility.R_GetStreamingContext("CLEAVE_TYPE")
                .CHISTORY_FROM_DATE = R_Utility.R_GetStreamingContext("CHISTORY_FROM_DATE")
                .CHISTORY_TO_DATE = R_Utility.R_GetStreamingContext("CHISTORY_TO_DATE")
                .CHISTORY_STATUS = R_Utility.R_GetStreamingContext("CHISTORY_STATUS")
            End With

            loRtnTemp = loCls.getLeaveList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLeaveList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLeaveBalanceDetail() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getLeaveBalanceDetail
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200LeaveCLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .ITRANSACTION_TYPE = R_Utility.R_GetStreamingContext("ITRANSACTION_TYPE")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CLEAVE_TYPE = R_Utility.R_GetStreamingContext("CLEAVE_TYPE")
                .CLEAVE_CODE = R_Utility.R_GetStreamingContext("CLEAVE_CODE")
                .CENTITLEMENT_DATE = R_Utility.R_GetStreamingContext("CENTITLEMENT_DATE")

            End With

            loRtnTemp = loCls.getLeaveList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLeaveBalanceDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getCmbReason() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getCmbReason
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200LeaveCLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLEAVE_TYPE = R_Utility.R_GetStreamingContext("CLEAVE_TYPE")
            End With

            loRtnTemp = loCls.getCmbReason(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbReason")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLeaveBalanceList() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getLeaveBalanceList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200LeaveCLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getLeaveBalanceList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLeaveBalanceList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getOvtDtValueChanged() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getOvtDtValueChanged
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO


        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .COVERTIME_START_DATE = R_Utility.R_GetStreamingContext("COVERTIME_START_DATE")
                .COVERTIME_END_DATE = R_Utility.R_GetStreamingContext("COVERTIME_END_DATE")
            End With

            loRtnTemp = loCls.getOvtDtValueChanged(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getOvtDtValueChanged")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function RSP_ESS_GET_PAID_BY_LIST() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.RSP_ESS_GET_PAID_BY_LIST
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200CLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .COVERTIME_DATE = R_Utility.R_GetStreamingContext("COVERTIME_DATE")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnTemp = loCls.RSP_ESS_GET_PAID_BY_LIST(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_ESS_GET_PAID_BY_LIST")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getIncorrectAtt() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getIncorrectAtt
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200IncorrectAttCLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnTemp = loCls.getIncorrectAtt(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getIncorrectAtt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getShiftDaysOffList() As System.ServiceModel.Channels.Message Implements IESM01200StreamingService.getShiftDaysOffList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01200OvtCLS
        Dim loRtnTemp As List(Of ESM01200StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .COVERTIME_DATE = R_Utility.R_GetStreamingContext("COVERTIME_DATE")
            End With

            loRtnTemp = loCls.getShiftDaysOffList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getShiftDaysOffList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


End Class

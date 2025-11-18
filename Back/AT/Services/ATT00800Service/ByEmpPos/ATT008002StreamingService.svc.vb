Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports ATT00800Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT008002StreamingService" in code, svc and config file together.
Public Class ATT008002StreamingService
    Implements IATT008002StreamingService

    Public Function getAttCorrectionByEmp() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.getAttCorrectionByEmp
        Dim loException As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtnTemp As New List(Of ATT008002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            Dim lcEmp As String = ""
            Dim loEmp As New List(Of ATT00800LookUpDTO)
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cShiftDateFrom = R_Utility.R_GetStreamingContext("cShiftDateFrom")
                .cShiftDateTo = R_Utility.R_GetStreamingContext("cShiftDateTo")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cWorkGroupCode = R_Utility.R_GetStreamingContext("cWorkGroupCode")
                .cListDate = R_Utility.R_GetStreamingContext("cListDate")
                lcEmp = R_Utility.R_GetStreamingContext("oListEmpReason")
                loEmp = R_Utility.XMLToObject(Of List(Of ATT00800LookUpDTO))(lcEmp)
            End With

            loRtnTemp = loCls.getAttCorrectionByEmp(loParam, loEmp)

            loList = R_Utility.R_GetChunkData(Of ATT008002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAttCorrectionByEmp")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAttCorrectionByPosition() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.getAttCorrectionByPosition
        Dim loException As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtnTemp As New List(Of ATT008002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .cShiftDateFrom = R_Utility.R_GetStreamingContext("cShiftDateFrom")
                .cShiftDateTo = R_Utility.R_GetStreamingContext("cShiftDateTo")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getAttCorrectionByPosition(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT008002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAttCorrectionByPosition")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDepartment() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.getDepartment
        Dim loException As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtnTemp As New List(Of ATT008002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getDepartment(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT008002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDepartment")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getShiftCode() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.getShiftCode
        Dim loException As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtnTemp As New List(Of ATT008002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getShiftCode(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT008002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getShiftCode")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of ATT00800Back.ATT008002RegDTO)) Implements IATT008002StreamingService.Dummy

    End Sub

    Public Function getLookUpTime() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.getLookUpTime

        Dim loException As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtnTemp As New List(Of ATT00800LookUpDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cAttCode = R_Utility.R_GetStreamingContext("cAttCode")
                .cShifDate = R_Utility.R_GetStreamingContext("cShifDate")
            End With

            loRtnTemp = loCls.getLookUpTime(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00800LookUpDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpTime")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RFT_AT_CALCULATE_CUT_OFF() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.RFT_AT_CALCULATE_CUT_OFF
        Dim loException As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtnTemp As New List(Of ATT008002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cShifDate = R_Utility.R_GetStreamingContext("cShiftDate")
            End With

            loRtnTemp = loCls.RFT_AT_CALCULATE_CUT_OFF(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT008002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_AT_CALCULATE_CUT_OFF")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpWorkGroup() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.getLookUpWorkGroup

        Dim loException As New R_Exception
        Dim loCls As New ATT00800ByWorkGroupCls
        Dim loRtnTemp As New List(Of ATT00800LookUpDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With


            loRtnTemp = loCls.getLookUpWorkGroup(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00800LookUpDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpWorkGroup")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getSchedule() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.getSchedule

        Dim loException As New R_Exception
        Dim loCls As New ATT00800ByWorkGroupCls
        Dim loRtnTemp As New List(Of ATT00800LookUpDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cShiftDateFrom = R_Utility.R_GetStreamingContext("cShiftDateFrom")
                .cShiftDateTo = R_Utility.R_GetStreamingContext("cShiftDateTo")
                .cWorkGroupCode = R_Utility.R_GetStreamingContext("cWorkGroupCode")
            End With

            loRtnTemp = loCls.getSchedule(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00800LookUpDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSchedule")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RFT_AT_CALCULATE_CUT_OFF_LIST() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.RFT_AT_CALCULATE_CUT_OFF_LIST
        Dim loException As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtnTemp As New List(Of ATT008002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            With loParam

                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CSHIFT_CODE = R_Utility.R_GetStreamingContext("CSHIFT_CODE")

            End With

            loRtnTemp = loCls.RFT_AT_CALCULATE_CUT_OFF_LIST(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT008002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_AT_CALCULATE_CUT_OFF_LIST")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_AT_VALIDATE_SHIFT_CORRECTION() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.RSP_AT_VALIDATE_SHIFT_CORRECTION
        Dim loException As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtnTemp As New List(Of RSP_AT_VALIDATE_SHIFT_CORRECTIONDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            With loParam

                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.RSP_AT_VALIDATE_SHIFT_CORRECTION(loParam)

            loList = R_Utility.R_GetChunkData(Of RSP_AT_VALIDATE_SHIFT_CORRECTIONDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_AT_VALIDATE_SHIFT_CORRECTION")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpReason() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.getLookUpReason

        Dim loException As New R_Exception
        Dim loCls As New ATT00800ByWorkGroupCls
        Dim loRtnTemp As New List(Of ATT00800LookUpDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpReason(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00800LookUpDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpReason")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmpByReason() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.getEmpByReason
        Dim loException As New R_Exception
        Dim loCls As New ATT00800ByWorkGroupCls
        Dim loRtnTemp As New List(Of ATT00800LookUpDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cShiftDateFrom = R_Utility.R_GetStreamingContext("cShiftDateFrom")
                .cShiftDateTo = R_Utility.R_GetStreamingContext("cShiftDateTo")
                .CREASON_CODE = R_Utility.R_GetStreamingContext("CREASON_CODE")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getEmpByReason(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00800LookUpDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmpByReason")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function doUploadfromExcelCR04() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.doUploadfromExcelCR04
        Dim loException As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtnTemp As New List(Of ATT008002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            Dim lcUpl As String = ""
            Dim loUpl As New List(Of ATT008002UploadDTO)
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cShiftDateFrom = R_Utility.R_GetStreamingContext("cShiftDateFrom")
                .cShiftDateTo = R_Utility.R_GetStreamingContext("cShiftDateTo")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cWorkGroupCode = R_Utility.R_GetStreamingContext("cWorkGroupCode")
                .cListDate = R_Utility.R_GetStreamingContext("cListDate")
                lcUpl = R_Utility.R_GetStreamingContext("oListUploadData")
                loUpl = R_Utility.XMLToObject(Of List(Of ATT008002UploadDTO))(lcUpl)
            End With

            loRtnTemp = loCls.doUploadfromExcelCR04(loParam, loUpl)

            loList = R_Utility.R_GetChunkData(Of ATT008002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "doUploadfromExcelCR04")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function doValidateProcessCR04() As System.ServiceModel.Channels.Message Implements IATT008002StreamingService.doValidateProcessCR04
        Dim loException As New R_Exception
        Dim loCls As New ATT008002Cls
        Dim loRtnTemp As New List(Of ATT008002StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT008002DTO
        Dim loList As List(Of Byte())

        Try
            Dim lcUpl As String = ""
            Dim loUpl As New List(Of ATT008002UploadDTO)
            With loParam
                lcUpl = R_Utility.R_GetStreamingContext("oListUploadData")
                loUpl = R_Utility.XMLToObject(Of List(Of ATT008002UploadDTO))(lcUpl)
            End With

            loRtnTemp = loCls.doValidateProcessCR04(loUpl)

            loList = R_Utility.R_GetChunkData(Of ATT008002StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "doValidateProcessCR04")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

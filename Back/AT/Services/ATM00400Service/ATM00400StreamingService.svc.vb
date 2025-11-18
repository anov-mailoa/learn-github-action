Imports System.ServiceModel.Channels
Imports R_Common
Imports ATM00400Back
Imports ATM00400Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00400StreamingService" in code, svc and config file together.
Public Class ATM00400StreamingService
    Implements IATM00400StreamingService
     
    Public Function getAtmCard() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getAtmCard
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of ATM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cCardDate = R_Utility.R_GetStreamingContext("cCardDate")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            poParam.cCardNo = R_Utility.R_GetStreamingContext("cCardNo")

            loRtnList = loCls.getAtmCard(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "EmployeeCard")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPnmEmpOffice() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getPnmEmpOffice
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of ATM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cCardDate = R_Utility.R_GetStreamingContext("cCardDate")

            loRtnList = loCls.getPnmEmpOffice(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "Employee")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekAtmCard() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.cekAtmCard
        Dim loException As New R_Exception
        Dim loCls As New ATM00410Cls
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of ATM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnList = loCls.cekAtmCard(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "CekAtmCard")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataXls() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getDataXls
        Dim loException As New R_Exception
        Dim loCls As New ATM00410Cls
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of ATM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtnList = loCls.getDataXls(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataXls")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getEmployee
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of ATM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                '.cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                '.lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                '.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                '.cPosition = R_Utility.R_GetStreamingContext("cPosition")
                '.lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                '.cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                '.cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                '.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                '.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                '.cCardDate = R_Utility.R_GetStreamingContext("cCardDate")
            End With

            loRtnList = loCls.getEmployee(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployee")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAttendanceId() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getAttendanceId
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of ATM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnList = loCls.getAttendanceId(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAttendanceId")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDeptDB() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getDeptDB
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim loRtnTemp As List(Of ATM00410ExcelDTO)
        Dim loRtn As Message
        Dim loParam As List(Of ATM00410ExcelDTO)
        Dim loParamObj As String
        Dim loList As List(Of Byte())

        Try
            loParamObj = R_Utility.R_GetStreamingContext("oList")

            loParam = R_Utility.XMLToObject(Of List(Of ATM00410ExcelDTO))(loParamObj)

            loRtnTemp = loCls.getDeptDB(loParam)

            loList = R_Utility.R_GetChunkData(Of ATM00410ExcelDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDeptDB")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAnnual() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getAnnual
        Dim loException As New R_Exception
        Dim loCls As New ATM00400AnnualLeaveCLS
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of ATM00400AnnualStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnList = loCls.getAnnual(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00400AnnualStreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAnnual")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getWorkGroup() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getWorkGroup
        Dim loException As New R_Exception
        Dim loCls As New ATM00400WorkGroupCLS
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of ATM00400StreamingWorkGroupDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnList = loCls.getWorkGroup(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00400StreamingWorkGroupDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getWorkGroup")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbGroup() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getCmbGroup
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim poParam As New ATM00400DTO
        Dim loRtn As Message = Nothing
        Dim loRtnList As New List(Of comboBoxDTO)
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getCmbGroup(poParam)

            loList = R_Utility.R_GetChunkData(Of comboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbGroup")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbLeave() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getCmbLeave
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim poParam As New ATM00400DTO
        Dim loRtn As Message = Nothing
        Dim loRtnList As New List(Of comboBoxDTO)
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getCmbLeave(poParam)

            loList = R_Utility.R_GetChunkData(Of comboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbLeave")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getHistory
        Dim loException As New R_Exception
        Dim loCls As New ATM00420CLS
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of ATM00420StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cCardNo = R_Utility.R_GetStreamingContext("cCardNo")
            End With

            loRtnList = loCls.getHistory(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00420StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHistory")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function searchAttendanceId() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.searchAttendanceId
        Dim loException As New R_Exception
        Dim loCls As New ATM00420CLS
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of ATM00420StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCardNo = R_Utility.R_GetStreamingContext("cCardNo")
            End With

            loRtnList = loCls.searchAttendanceId(poParam)

            loList = R_Utility.R_GetChunkData(Of ATM00420StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "searchAttendanceId")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy() Implements IATM00400StreamingService.Dummy

    End Sub

    Public Function getAnnualLeaveDB() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getAnnualLeaveDB
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim loRtnTemp As List(Of ATM00410ExcelDTO)
        Dim loRtn As Message
        Dim loParam As List(Of ATM00410ExcelDTO)
        Dim loParamObj As String
        Dim loList As List(Of Byte())

        Try
            loParamObj = R_Utility.R_GetStreamingContext("oList")

            loParam = R_Utility.XMLToObject(Of List(Of ATM00410ExcelDTO))(loParamObj)

            loRtnTemp = loCls.getAnnualLeaveDB(loParam)

            loList = R_Utility.R_GetChunkData(Of ATM00410ExcelDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAnnualLeaveDB")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getWorkGroupDB() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.getWorkGroupDB
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim loRtnTemp As List(Of ATM00410ExcelDTO)
        Dim loRtn As Message
        Dim loParam As List(Of ATM00410ExcelDTO)
        Dim loParamObj As String
        Dim loList As List(Of Byte())

        Try
            loParamObj = R_Utility.R_GetStreamingContext("oList")

            loParam = R_Utility.XMLToObject(Of List(Of ATM00410ExcelDTO))(loParamObj)

            loRtnTemp = loCls.getWorkGroupDB(loParam)

            loList = R_Utility.R_GetChunkData(Of ATM00410ExcelDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getWorkGroupDB")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_AT_VALIDATE_EMPLOYEE_MASTER() As System.ServiceModel.Channels.Message Implements IATM00400StreamingService.RSP_AT_VALIDATE_EMPLOYEE_MASTER
        Dim loException As New R_Exception
        Dim loCls As New ATM00410Cls
        Dim poParam As New ATM00400DTO
        Dim loRtnList As New List(Of RSP_AT_VALIDATE_EMPLOYEE_MASTERDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
            End With

            loRtnList = loCls.RSP_AT_VALIDATE_EMPLOYEE_MASTER(poParam)

            loList = R_Utility.R_GetChunkData(Of RSP_AT_VALIDATE_EMPLOYEE_MASTERDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_AT_VALIDATE_EMPLOYEE_MASTER")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

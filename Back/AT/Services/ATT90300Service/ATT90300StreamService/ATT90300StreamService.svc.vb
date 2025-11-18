Imports System.ServiceModel
Imports R_Common
Imports ATT90300Back
Imports ATT90300Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports SIAPP_SERVICE_AT
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90300StreamService" in code, svc and config file together.
Public Class ATT90300StreamService
    Implements IATT90300StreamService

    Public Function GetDepartmentList() As System.ServiceModel.Channels.Message Implements IATT90300StreamService.GetDepartmentList
        Dim loException As New R_Exception
        Dim loCls As New ATT90300CLS
        Dim loRtnTemp As List(Of ATT90300StreamDto)
        Dim loParam As New ATT90300Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
        End With

        Try
            loRtnTemp = loCls.GetDepartmentList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90300StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDepartmentList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetDetailList() As System.ServiceModel.Channels.Message Implements IATT90300StreamService.GetDetailList
        Dim loException As New R_Exception
        Dim loCls As New ATT90300CLS
        Dim loRtnTemp As List(Of ATT90300StreamDto)
        Dim loParam As New ATT90300Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            .cReferenceDate = R_Utility.R_GetStreamingContext("cReferenceDate")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
        End With

        Try
            loRtnTemp = loCls.GetDetailList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90300StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDetailList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IATT90300StreamService.GetEmployeeList
        Dim loException As New R_Exception
        Dim loCls As New ATT90300CLS
        Dim loRtnTemp As List(Of ATT90300StreamDto)
        Dim loParam As New ATT90300Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            .cShiftDate = R_Utility.R_GetStreamingContext("cShiftDate")
            .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
            .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE") 
            .cLocation = R_Utility.R_GetStreamingContext("cLocation") 
            .cPosition = R_Utility.R_GetStreamingContext("cPosition") 
            .cWorkGroup = R_Utility.R_GetStreamingContext("cWorkGroup") 
        End With

        Try
            loRtnTemp = loCls.GetEmployeeList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90300StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTransactionList() As System.ServiceModel.Channels.Message Implements IATT90300StreamService.GetTransactionList
        Dim loException As New R_Exception
        Dim loCls As New ATT90300CLS
        Dim loRtnTemp As List(Of ATT90300StreamDto)
        Dim loParam As New ATT90300Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
        End With

        Try
            loRtnTemp = loCls.GetTransactionList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90300StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransactionList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTransactionHistoryList() As System.ServiceModel.Channels.Message Implements IATT90300StreamService.GetTransactionHistoryList
        Dim loException As New R_Exception
        Dim loCls As New ATT90300CLS
        Dim loRtnTemp As List(Of ATT90300StreamDto)
        Dim loParam As New ATT90300Dto
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

            loList = R_Utility.R_GetChunkData(Of ATT90300StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransactionHistoryList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMonthList() As System.ServiceModel.Channels.Message Implements IATT90300StreamService.GetMonthList
        Dim loException As New R_Exception
        Dim loCls As New ATT90300CLS
        Dim loRtnTemp As List(Of ATT90300StreamDto)
        Dim loParam As New ATT90300Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
        End With

        Try
            loRtnTemp = loCls.GetMonthList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90300StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetMonthList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListShift() As Message Implements IATT90300StreamService.getListShift
        Dim loException As New R_Exception
        Dim loCls As New ATT90300CLS
        Dim loRtnTemp As List(Of LookupDto)
        Dim loParam As String
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        loParam = R_Utility.R_GetStreamingContext("cCompId")

        Try
            loRtnTemp = loCls.getListShift(loParam)

            loList = R_Utility.R_GetChunkData(Of LookupDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListShift")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

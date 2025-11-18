Imports System.ServiceModel
Imports R_Common
Imports ATT90100Back
Imports ATT90100Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports ATT90300Back
Imports LookupDto = ATT90300Common.LookupDto
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90100StreamService" in code, svc and config file together.
Public Class ATT90100StreamService
    Implements IATT90100StreamService

    Public Function GetDepartmentList() As System.ServiceModel.Channels.Message Implements IATT90100StreamService.GetDepartmentList
        Dim loException As New R_Exception
        Dim loCls As New ATT90100CLS
        Dim loRtnTemp As List(Of ATT90100StreamDto)
        Dim loParam As New ATT90100Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
        End With

        Try
            loRtnTemp = loCls.GetDepartmentList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90100StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDepartmentList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetDetailList() As System.ServiceModel.Channels.Message Implements IATT90100StreamService.GetDetailList
        Dim loException As New R_Exception
        Dim loCls As New ATT90100CLS
        Dim loRtnTemp As List(Of ATT90100StreamDto)
        Dim loParam As New ATT90100Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
        End With

        Try
            loRtnTemp = loCls.GetDetailList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90100StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDetailList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IATT90100StreamService.GetEmployeeList
        Dim loException As New R_Exception
        Dim loCls As New ATT90100CLS
        Dim loRtnTemp As List(Of ATT90100StreamDto)
        Dim loParam As New ATT90100Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            .cShiftDate = R_Utility.R_GetStreamingContext("cShiftDate")
            .lLocation = R_Utility.R_GetStreamingContext("lLocation")
            .cLocation = R_Utility.R_GetStreamingContext("cLocation")
            .lPosition = R_Utility.R_GetStreamingContext("lPosition")
            .cPosition = R_Utility.R_GetStreamingContext("cPosition")
            .lWorkGroup = R_Utility.R_GetStreamingContext("lWorkGroup")
            .cWorkGroup = R_Utility.R_GetStreamingContext("cWorkGroup")
        End With

        Try
            loRtnTemp = loCls.GetEmployeeList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90100StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTransactionList() As System.ServiceModel.Channels.Message Implements IATT90100StreamService.GetTransactionList
        Dim loException As New R_Exception
        Dim loCls As New ATT90100CLS
        Dim loRtnTemp As List(Of ATT90100StreamDto)
        Dim loParam As New ATT90100Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
        End With

        Try
            loRtnTemp = loCls.GetTransactionList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90100StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransactionList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTransactionHistoryList() As System.ServiceModel.Channels.Message Implements IATT90100StreamService.GetTransactionHistoryList
        Dim loException As New R_Exception
        Dim loCls As New ATT90100CLS
        Dim loRtnTemp As List(Of ATT90100StreamDto)
        Dim loParam As New ATT90100Dto
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

            loList = R_Utility.R_GetChunkData(Of ATT90100StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransactionHistoryList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMonthList() As System.ServiceModel.Channels.Message Implements IATT90100StreamService.GetMonthList
        Dim loException As New R_Exception
        Dim loCls As New ATT90100CLS
        Dim loRtnTemp As List(Of ATT90100StreamDto)
        Dim loParam As New ATT90100Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
        End With

        Try
            loRtnTemp = loCls.GetMonthList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90100StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetMonthList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function getLookUpShift() As System.ServiceModel.Channels.Message Implements IATT90100StreamService.getLookUpShift
        Dim loException As New R_Exception
        Dim loCls As New ATT90100CLS
        Dim loRtnTemp As List(Of ATT90100Common.LookupDto)
        Dim loParam As String
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        loParam = R_Utility.R_GetStreamingContext("cCompId")

        Try
            loRtnTemp = loCls.getlookupshift(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90100Common.LookupDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpShift")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

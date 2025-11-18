' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00600StreamingService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports ATT00600Back
Imports ATT00600Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class ATT00600StreamingService
    Implements IATT00600StreamingService
     
    Public Function getListCorrection() As System.ServiceModel.Channels.Message Implements IATT00600StreamingService.getListCorrection
        Dim loException As New R_Exception
        Dim loCls As New ATT00600CLS
        Dim loRtnTemp As List(Of ATT00600StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00600DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getListCorrection(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00600StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListCorrection")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListCorrectionHistory() As System.ServiceModel.Channels.Message Implements IATT00600StreamingService.getListCorrectionHistory
        Dim loException As New R_Exception
        Dim loCls As New ATT00600CLS
        Dim loRtnTemp As List(Of ATT00600StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00600DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionDate = R_Utility.R_GetStreamingContext("cTransactionDate")
            End With

            loRtnTemp = loCls.getListCorrectionHistory(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00600StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListCorrectionHistory")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getHeaderDetail() As System.ServiceModel.Channels.Message Implements IATT00600StreamingService.getHeaderDetail
        Dim loException As New R_Exception
        Dim loCls As New ATT00610CLS
        Dim loRtnTemp As List(Of ATT00610DTO)
        Dim loRtn As Message
        Dim loParam As New ATT00610DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cMonthFirstDate = R_Utility.R_GetStreamingContext("cMonthFirstDate")
                .cMonthLastDate = R_Utility.R_GetStreamingContext("cMonthLastDate")
                .lHistory = R_Utility.R_GetStreamingContext("lHistory")
            End With

            loRtnTemp = loCls.getHeaderDetail(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00610DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHeaderDetail")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getShiftList() As System.ServiceModel.Channels.Message Implements IATT00600StreamingService.getShiftList
        Dim loException As New R_Exception
        Dim loCls As New ATT00610CLS
        Dim loRtnTemp As List(Of ATT00610ShiftListDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00610DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getShiftList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00610ShiftListDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getShiftList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbWorkGroup() As System.ServiceModel.Channels.Message Implements IATT00600StreamingService.getCmbWorkGroup
        Dim loException As New R_Exception
        Dim loCls As New ATT00610CLS
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00610DTO


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbWorkGroup(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable(), "getCmbWorkGroup")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_SCHEDULE_WORK_GROUP() As System.ServiceModel.Channels.Message Implements IATT00600StreamingService.RFT_GET_SCHEDULE_WORK_GROUP
        Dim loException As New R_Exception
        Dim loCls As New ATT00610CLS
        Dim loRtnTemp As List(Of ATT00610DetailDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00610DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cMonthFirstDate = R_Utility.R_GetStreamingContext("cMonthFirstDate")
                .cMonthLastDate = R_Utility.R_GetStreamingContext("cMonthLastDate")
                .cCorrectionValue = R_Utility.R_GetStreamingContext("cCorrectionValue")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.RFT_GET_SCHEDULE_WORK_GROUP(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00610DetailDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_SCHEDULE_WORK_GROUP")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_SCHEDULE_WORK_GROUP_EMPLOYEE() As System.ServiceModel.Channels.Message Implements IATT00600StreamingService.RFT_GET_SCHEDULE_WORK_GROUP_EMPLOYEE

        Dim loException As New R_Exception
        Dim loCls As New ATT00610CLS
        Dim loRtnTemp As List(Of ATT00610DetailDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00610DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cMonthFirstDate = R_Utility.R_GetStreamingContext("cMonthFirstDate")
                .cMonthLastDate = R_Utility.R_GetStreamingContext("cMonthLastDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.RFT_GET_SCHEDULE_WORK_GROUP_EMPLOYEE(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00610DetailDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_SCHEDULE_WORK_GROUP_EMPLOYEE")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getShiftLookup() As System.ServiceModel.Channels.Message Implements IATT00600StreamingService.getShiftLookup
        Dim loException As New R_Exception
        Dim loCls As New ATT00610CLS
        Dim loRtnTemp As List(Of ATT00610ShiftListDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00610DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cShiftDate = R_Utility.R_GetStreamingContext("cShiftDate")
            End With

            loRtnTemp = loCls.getShiftLookup(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00610ShiftListDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getShiftLookup")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getShiftExcel() As System.ServiceModel.Channels.Message Implements IATT00600StreamingService.getShiftExcel
        Dim loException As New R_Exception
        Dim loCls As New ATT00610CLS
        Dim loRtnTemp As List(Of ATT00610ShiftListDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00610DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .cShiftCode = R_Utility.R_GetStreamingContext("cShiftCode")
            End With

            loRtnTemp = loCls.getShiftExcel(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00610ShiftListDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getShiftExcel")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

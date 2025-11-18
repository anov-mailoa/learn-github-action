' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90600StreamingService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports ATT90600Back
Imports ATT90600Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class ATT90600StreamingService
    Implements IATT90600StreamingService
     
    Public Function getListCompensatory() As System.ServiceModel.Channels.Message Implements IATT90600StreamingService.getListCompensatory
        Dim loException As New R_Exception
        Dim loCls As New ATT90600CLS
        Dim loRtnTemp As List(Of ATT90600StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ATT90600DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            End With

            loRtnTemp = loCls.getListCompensatory(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90600StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListCompensatory")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListCompensatoryHistory() As System.ServiceModel.Channels.Message Implements IATT90600StreamingService.getListCompensatoryHistory

        Dim loException As New R_Exception
        Dim loCls As New ATT90600CLS
        Dim loRtnTemp As List(Of ATT90600StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ATT90600DTO
        Dim loList As List(Of Byte())

        Try
            With loParam

                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cReferencePeriod = R_Utility.R_GetStreamingContext("cReferencePeriod")

            End With

            loRtnTemp = loCls.getListCompensatoryHistory(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90600StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListCompensatoryHistory")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getCmbLeaveCode() As System.ServiceModel.Channels.Message Implements IATT90600StreamingService.getCmbLeaveCode
        Dim loException As New R_Exception
        Dim loCls As New ATT90600CLS
        Dim loRtnTemp As List(Of ComboBoxDTO)
        Dim loRtn As Message
        Dim loParam As New ATT90600DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLeaveType = R_Utility.R_GetStreamingContext("cLeaveType")
            End With

            loRtnTemp = loCls.getCmbLeaveCode(loParam)

            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbLeaveCode")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLeaveBalance() As System.ServiceModel.Channels.Message Implements IATT90600StreamingService.getLeaveBalance
        Dim loException As New R_Exception
        Dim loCls As New ATT90600CLS
        Dim loRtnTemp As List(Of ATT90600StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ATT90600DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId") 
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cLastdtGetMachine = R_Utility.R_GetStreamingContext("cLastdtGetMachine")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")

            End With

            loRtnTemp = loCls.getLeaveBalance(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90600StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLeaveBalance")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

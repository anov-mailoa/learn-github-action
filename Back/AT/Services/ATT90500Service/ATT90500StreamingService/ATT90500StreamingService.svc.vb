Imports System.ServiceModel
Imports R_Common
Imports ATT90500Back
Imports ATT90500Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90500StreamingService" in code, svc and config file together.
Public Class ATT90500StreamingService
    Implements IATT90500StreamingService
     
    Public Function getListLeave() As System.ServiceModel.Channels.Message Implements IATT90500StreamingService.getListLeave
        Dim loException As New R_Exception
        Dim loCls As New ATT90500CLS
        Dim loRtnTemp As List(Of ATT90500StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ATT90500DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            End With

            loRtnTemp = loCls.getListLeave(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListLeave")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListLeaveHistory() As System.ServiceModel.Channels.Message Implements IATT90500StreamingService.getListLeaveHistory

        Dim loException As New R_Exception
        Dim loCls As New ATT90500CLS
        Dim loRtnTemp As List(Of ATT90500StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ATT90500DTO
        Dim loList As List(Of Byte())


        Try
            With loParam

                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cReferencePeriod = R_Utility.R_GetStreamingContext("cReferencePeriod")

            End With

            loRtnTemp = loCls.getListLeaveHistory(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT90500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListLeaveHistory")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getCmbLeaveCode() As System.ServiceModel.Channels.Message Implements IATT90500StreamingService.getCmbLeaveCode
        Dim loException As New R_Exception
        Dim loCls As New ATT90500CLS
        Dim loRtnTemp As List(Of ComboBoxDTO)
        Dim loRtn As Message
        Dim loParam As New ATT90500DTO
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
End Class

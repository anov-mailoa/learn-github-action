' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT91000StreamingService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports ATT91000Back
Imports ATT91000Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class ATT91000StreamingService
    Implements IATT91000StreamingService

    Public Function getHeaderDetail() As System.ServiceModel.Channels.Message Implements IATT91000StreamingService.getHeaderDetail
        Dim loException As New R_Exception
        Dim loCls As New ATT91010CLS
        Dim loRtnTemp As List(Of ATT91010DTO)
        Dim loRtn As Message
        Dim loParam As New ATT91010DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .lHistory = R_Utility.R_GetStreamingContext("lHistory")
            End With

            loRtnTemp = loCls.getHeaderDetail(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT91010DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHeaderDetail")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListMassLeave() As System.ServiceModel.Channels.Message Implements IATT91000StreamingService.getListMassLeave
        Dim loException As New R_Exception
        Dim loCls As New ATT91000CLS
        Dim loRtnTemp As List(Of ATT91000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ATT91000DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getListMassLeave(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT91000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListMassLeave")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListMassLeaveHistory() As System.ServiceModel.Channels.Message Implements IATT91000StreamingService.getListMassLeaveHistory
        Dim loException As New R_Exception
        Dim loCls As New ATT91000CLS
        Dim loRtnTemp As List(Of ATT91000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ATT91000DTO
        Dim loList As List(Of Byte())


        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cReferencePeriod = R_Utility.R_GetStreamingContext("cReferencePeriod")
            End With

            loRtnTemp = loCls.getListMassLeaveHistory(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT91000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListMassLeaveHistory")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

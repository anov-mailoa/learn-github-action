Imports R_Common
Imports R_BackEnd
Imports GSM01000Back
Imports GSM01000Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01020StreamingService" in code, svc and config file together.
Public Class GSM01020StreamingService
    Implements IGSM01020StreamingService

    Public Function getListAppUser() As System.ServiceModel.Channels.Message Implements IGSM01020StreamingService.getListAppUser
        Dim loException As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtnTemp As List(Of GSM01020UserAppDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01020DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getListAppUser(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01020UserAppDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListAppUser")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDepartment() As System.ServiceModel.Channels.Message Implements IGSM01020StreamingService.getDepartment
        Dim loException As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtnTemp As List(Of GSM01020UserAppDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01020DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getDepartment(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01020UserAppDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDepartment")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListUser() As System.ServiceModel.Channels.Message Implements IGSM01020StreamingService.getListUser
        Dim loException As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtnTemp As List(Of GSM01020UserAppDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01020DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .lDeptMode = R_Utility.R_GetStreamingContext("lDeptMode")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getListUser(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01020UserAppDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListUser")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReplacementList() As System.ServiceModel.Channels.Message Implements IGSM01020StreamingService.getReplacementList
        Dim loException As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtnTemp As List(Of GSM01020UserAppDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01020DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getReplacementList(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01020UserAppDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReplacementList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

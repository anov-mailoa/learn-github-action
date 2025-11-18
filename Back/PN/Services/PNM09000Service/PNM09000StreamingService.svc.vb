Imports System.ServiceModel
Imports R_Common
Imports PNM09000Back
Imports PNM09000Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM09000StreamingService" in code, svc and config file together.

Public Class PNM09000StreamingService
    Implements IPNM09000StreamingService

    Public Function getEmailAlerts() As System.ServiceModel.Channels.Message Implements IPNM09000StreamingService.getEmailAlerts
        Dim loException As New R_Exception
        Dim loCls As New PNM09000Cls
        Dim loRtnTemp As List(Of PNM09000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loParam As New PNM09000DTO

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.getEmailAlerts(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM09000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmailAlerts")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpUser() As System.ServiceModel.Channels.Message Implements IPNM09000StreamingService.getLookUpUser
        Dim loException As New R_Exception
        Dim loCls As New PNM09000Cls
        Dim loRtnTemp As List(Of PNM09000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loParam As New PNM09000DTO

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserList = R_Utility.R_GetStreamingContext("cUserList")

            loRtnTemp = loCls.getLookUpUser(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM09000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpUser")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getUserList() As System.ServiceModel.Channels.Message Implements IPNM09000StreamingService.getUserList
        Dim loException As New R_Exception
        Dim loCls As New PNM09000Cls
        Dim loRtnTemp As List(Of PNM09000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loParam As New PNM09000DTO

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cAlertCode = R_Utility.R_GetStreamingContext("cAlertCode")

            loRtnTemp = loCls.getUserList(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM09000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getUserList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmailDt() As System.ServiceModel.Channels.Message Implements IPNM09000StreamingService.getEmailDt
        Dim loException As New R_Exception
        Dim loCls As New PNM09000DetailCls
        Dim loRtnTemp As List(Of PNM09000DetailStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loParam As New PNM09000DetailDTO

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cAlertCode = R_Utility.R_GetStreamingContext("cAlertCode")

            loRtnTemp = loCls.getEmailDt(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM09000DetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmailDt")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbSequence() As System.ServiceModel.Channels.Message Implements IPNM09000StreamingService.getCmbSequence
        Dim loException As New R_Exception
        Dim loCls As New PNM09000Cls
        Dim loRtnTemp As List(Of PNM09000DetailStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loParam As New PNM09000DetailDTO

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cAlertCode = R_Utility.R_GetStreamingContext("cAlertCode")

            loRtnTemp = loCls.getCmbSequence(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM09000DetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbSequence")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of PNM09000Back.PNM09000GridDTO), poPar2 As System.Collections.Generic.List(Of PNM09000Back.PNM09000DetailGridDTO)) Implements IPNM09000StreamingService.Dummy

    End Sub
End Class

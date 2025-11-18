' NOTE: You can use the "Rename" command on the context menu to change the class name "PQM00500StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select PQM00500StreamingService.svc or PQM00500StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports R_Common
Imports PQM00500Back
Imports System.ServiceModel.Channels
Imports PQM00500Common
Imports REALTA_SERVICES

Public Class PQM00500StreamingService
    Implements IPQM00500StreamingService

    Public Function getCmbCompany() As Message Implements IPQM00500StreamingService.getCmbCompany
        Dim loException As New R_Exception
        Dim loCls As New PQM00500Cls
        Dim loRtnTemp As List(Of CmbDto)
        Dim loRtn As Message
        Dim lcParam As String
        Dim loList As New List(Of Byte())

        Try

            lcParam = R_Utility.R_GetStreamingContext("cUserId")
            loRtnTemp = loCls.getCmbCompany(lcParam)

            loList = R_Utility.R_GetChunkData(Of CmbDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCompany")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbUser() As Message Implements IPQM00500StreamingService.getCmbUser
        Dim loException As New R_Exception
        Dim loCls As New PQM00500Cls
        Dim loRtnTemp As List(Of CmbDto)
        Dim loRtn As Message
        Dim loParam As New PQM00500Dto
        Dim loList As New List(Of Byte())

        Try

            loRtnTemp = loCls.getCmbUser(loParam)

            loList = R_Utility.R_GetChunkData(Of CmbDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbUser")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListDataMenu() As Message Implements IPQM00500StreamingService.getListDataMenu
        Dim loException As New R_Exception
        Dim loCls As New PQM00500Cls
        Dim loRtnTemp As List(Of PQM00500GridMenuDto)
        Dim loRtn As Message
        Dim loParam As New PQM00500Dto
        Dim loList As New List(Of Byte())

        Try

            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            loRtnTemp = loCls.getListDataMenu(loParam)

            loList = R_Utility.R_GetChunkData(Of PQM00500GridMenuDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDataMenu")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListDataUser() As Message Implements IPQM00500StreamingService.getListDataUser
        Dim loException As New R_Exception
        Dim loCls As New PQM00500Cls
        Dim loRtnTemp As List(Of PQM00500GridDto)
        Dim loRtn As Message
        Dim loParam As New PQM00500Dto
        Dim loList As New List(Of Byte())

        Try

            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            loParam.CMENU_ID = R_Utility.R_GetStreamingContext("CMENU_ID")
            loRtnTemp = loCls.getListDataUser(loParam)

            loList = R_Utility.R_GetChunkData(Of PQM00500GridDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDataUser")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

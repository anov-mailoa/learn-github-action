' NOTE: You can use the "Rename" command on the context menu to change the class name "PQM00400StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select PQM00400StreamingService.svc or PQM00400StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports R_Common
Imports PQM00400Back
Imports System.ServiceModel.Channels
Imports PQM00400Common

Public Class PQM00400StreamingService
    Implements IPQM00400StreamingService

    Public Function getCmbCompany() As Message Implements IPQM00400StreamingService.getCmbCompany
        Dim loException As New R_Exception
        Dim loCls As New PQM00400Cls
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

    Public Function getCmbService() As Message Implements IPQM00400StreamingService.getCmbService
        Dim loException As New R_Exception
        Dim loCls As New PQM00400Cls
        Dim loRtnTemp As List(Of CmbDto)
        Dim loRtn As Message
        Dim loParam As New PQM00400Dto
        Dim loList As New List(Of Byte())

        Try

            loRtnTemp = loCls.getCmbService(loParam)

            loList = R_Utility.R_GetChunkData(Of CmbDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbService")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListDataMenu() As Message Implements IPQM00400StreamingService.getListDataMenu
        Dim loException As New R_Exception
        Dim loCls As New PQM00400Cls
        Dim loRtnTemp As List(Of PQM00400GridMenuDto)
        Dim loRtn As Message
        Dim loParam As New PQM00400Dto
        Dim loList As New List(Of Byte())

        Try

            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            loRtnTemp = loCls.getListDataMenu(loParam)

            loList = R_Utility.R_GetChunkData(Of PQM00400GridMenuDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDataMenu")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListDataService() As Message Implements IPQM00400StreamingService.getListDataService
        Dim loException As New R_Exception
        Dim loCls As New PQM00400Cls
        Dim loRtnTemp As List(Of PQM00400GridDto)
        Dim loRtn As Message
        Dim loParam As New PQM00400Dto
        Dim loList As New List(Of Byte())

        Try

            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            loParam.CMENU_ID = R_Utility.R_GetStreamingContext("CMENU_ID")
            loRtnTemp = loCls.getListDataService(loParam)

            loList = R_Utility.R_GetChunkData(Of PQM00400GridDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDataService")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

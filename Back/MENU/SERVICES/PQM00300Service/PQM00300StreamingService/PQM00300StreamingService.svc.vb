' NOTE: You can use the "Rename" command on the context menu to change the class name "PQM00300StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select PQM00300StreamingService.svc or PQM00300StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports R_Common
Imports PQM00300Back
Imports System.ServiceModel.Channels
Imports PQM00300Common
Imports TelerikMenuService

Public Class PQM00300StreamingService
    Implements IPQM00300StreamingService

    Public Function getListData() As Message Implements IPQM00300StreamingService.getListData
        Dim loException As New R_Exception
        Dim loCls As New PQM00300Cls
        Dim loRtnTemp As List(Of PQM00300GridDto)
        Dim loRtn As Message
        Dim loParam As New PQM00300Dto
        Dim loList As New List(Of Byte())
        Dim lcCoid As String

        Try

            lcCoid = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtnTemp = loCls.getListData(lcCoid)

            loList = R_Utility.R_GetChunkData(Of PQM00300GridDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListData")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getUserCompany() As Message Implements IPQM00300StreamingService.getUserCompany
        Dim loException As New R_Exception
        Dim loCls As New PQM00300Cls
        Dim loRtnTemp As List(Of CmbDto)
        Dim loRtn As Message
        Dim lcUserId As String
        Dim loList As New List(Of Byte())

        Try

            lcUserId = R_Utility.R_GetStreamingContext("cUserId")
            loRtnTemp = loCls.getUserCompany(lcUserId)

            loList = R_Utility.R_GetChunkData(Of CmbDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getUserCompany")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

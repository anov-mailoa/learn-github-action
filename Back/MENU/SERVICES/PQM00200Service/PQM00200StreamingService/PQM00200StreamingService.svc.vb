' NOTE: You can use the "Rename" command on the context menu to change the class name "PQM00200StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select PQM00200StreamingService.svc or PQM00200StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports R_Common
Imports PQM00200Back
Imports System.ServiceModel.Channels
Imports PQM00200Common
Imports TelerikMenuService

Public Class PQM00200StreamingService
    Implements IPQM00200StreamingService

    Public Function getListData() As Message Implements IPQM00200StreamingService.getListData
        Dim loException As New R_Exception
        Dim loCls As New PQM00200Cls
        Dim loRtnTemp As List(Of PQM00200GridDto)
        Dim loRtn As Message
        Dim loParam As New PQM00200Dto
        Dim loList As New List(Of Byte())

        Try
            loRtnTemp = loCls.getListData()

            loList = R_Utility.R_GetChunkData(Of PQM00200GridDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListData")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getUserCompany() As Message Implements IPQM00200StreamingService.getUserCompany
        Dim loException As New R_Exception
        Dim loCls As New PQM00200Cls
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

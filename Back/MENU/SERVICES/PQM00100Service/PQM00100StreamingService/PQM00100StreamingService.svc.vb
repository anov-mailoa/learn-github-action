' NOTE: You can use the "Rename" command on the context menu to change the class name "PQM00100StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select PQM00100StreamingService.svc or PQM00100StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports R_Common
Imports PQM00100Back
Imports System.ServiceModel.Channels
Imports PQM00100Common

Public Class PQM00100StreamingService
    Implements IPQM00100StreamingService

    Public Function getListData() As Message Implements IPQM00100StreamingService.getListData
        Dim loException As New R_Exception
        Dim loCls As New PQM00100Cls
        Dim loRtnTemp As List(Of PQM00100GridDto)
        Dim loRtn As Message
        Dim loParam As New PQM00100Dto
        Dim loList As New List(Of Byte())

        Try
            loRtnTemp = loCls.getListData()

            loList = R_Utility.R_GetChunkData(Of PQM00100GridDto)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListData")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

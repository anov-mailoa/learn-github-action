Imports R_Common
Imports SAM01500Back
Imports System.ServiceModel.Channels
Imports SAM01500Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM01500StreamingService" in code, svc and config file together.
Public Class SAM01500StreamingService
    Implements ISAM01500StreamingService

    Public Function getLockingList() As System.ServiceModel.Channels.Message Implements ISAM01500StreamingService.getLockingList
        Dim loException As New R_Exception
        Dim loCls As New SAM01500Cls
        Dim loRtnTemp As List(Of SAM01500DTOnon)
        Dim loRtn As Message
        Dim lcCompId As String
        Dim loList As New List(Of Byte())

        Try
            lcCompId = R_Utility.R_GetStreamingContext("cCompId")
            loRtnTemp = loCls.getLockingList(lcCompId)

            loList = R_Utility.R_GetChunkData(Of SAM01500DTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLockingList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

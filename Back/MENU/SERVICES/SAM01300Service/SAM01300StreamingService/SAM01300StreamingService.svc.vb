Imports R_Common
Imports SAM01300Back
Imports System.ServiceModel.Channels
Imports SAM01300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM01300StreamingService" in code, svc and config file together.
Public Class SAM01300StreamingService
    Implements ISAM01300StreamingService

    Public Function getLockingList() As System.ServiceModel.Channels.Message Implements ISAM01300StreamingService.getLockingList
        Dim loException As New R_Exception
        Dim loCls As New SAM01300Cls
        Dim loRtnTemp As List(Of SAM01300DTOnon)
        Dim loRtn As Message
        Dim loList As New List(Of Byte())

        Try
            loRtnTemp = loCls.getLockingList()

            loList = R_Utility.R_GetChunkData(Of SAM01300DTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLockingList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

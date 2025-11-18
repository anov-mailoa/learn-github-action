Imports R_Common
Imports SAM00200Back
Imports System.ServiceModel.Channels
Imports SAM00200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM00200StreamingService" in code, svc and config file together.
Public Class SAM00200StreamingService
    Implements ISAM00200StreamingService

    Public Function getLOBList() As System.ServiceModel.Channels.Message Implements ISAM00200StreamingService.getLOBList
        Dim loException As New R_Exception
        Dim loCls As New SAM00200Cls
        Dim loRtnTemp As List(Of SAM00200GridDTO)
        Dim loRtn As Message
        Dim loList As New List(Of Byte())

        Try
            loRtnTemp = loCls.getLOBList()

            loList = R_Utility.R_GetChunkData(Of SAM00200GridDTO)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLOBList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02700StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAM02700StreamingService.svc or SAM02700StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports System.ServiceModel.Channels
Imports R_Common
Imports SAM02700Back
Imports SAM02700Common

Public Class SAM02700StreamingService
    Implements ISAM02700StreamingService

    Public Function GetData() As Message Implements ISAM02700StreamingService.GetData
        Dim loException As New R_Exception
        Dim loCls As New SAM02700Cls
        Dim loRtnTemp As List(Of SAM02700DTOnon)
        Dim loRtn As Message = Nothing
        Dim loList As New List(Of Byte())

        Try
            loRtnTemp = loCls.GetData()

            loList = R_Utility.R_GetChunkData(Of SAM02700DTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetData")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

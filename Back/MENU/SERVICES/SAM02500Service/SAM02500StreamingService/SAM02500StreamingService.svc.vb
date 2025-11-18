' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02500StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAM02500StreamingService.svc or SAM02500StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports System.ServiceModel.Channels
Imports R_Common
Imports SAM02500Back
Imports SAM02500Common

Public Class SAM02500StreamingService
    Implements ISAM02500StreamingService

    Public Function GetOutboxList() As Message Implements ISAM02500StreamingService.GetOutboxList
        Dim loException As New R_Exception
        Dim loCls As New SAM02500Cls
        Dim loRtnTemp As List(Of SAM02500DTOnon) = Nothing
        Dim loRtn As Message = Nothing
        Dim loList As New List(Of Byte())
        Dim lcCompanyId As String = ""

        Try
            lcCompanyId = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtnTemp = loCls.GetOutboxList(lcCompanyId)

            loList = R_Utility.R_GetChunkData(Of SAM02500DTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetOutboxList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

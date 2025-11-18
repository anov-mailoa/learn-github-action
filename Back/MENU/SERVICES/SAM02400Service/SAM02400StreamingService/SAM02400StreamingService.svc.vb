' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02400StreamingService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAM02400StreamingService.svc or SAM02400StreamingService.svc.vb at the Solution Explorer and start debugging.
Imports System.ServiceModel.Channels
Imports R_Common
Imports SAM02400Back
Imports SAM02400Common

Public Class SAM02400StreamingService
    Implements ISAM02400StreamingService

    Public Function GetTypeList() As Message Implements ISAM02400StreamingService.GetTypeList
        Dim loException As New R_Exception
        Dim loCls As New SAM02400Cls
        Dim loRtnTemp As List(Of SAM02400DTOnon) = Nothing
        Dim loRtn As Message = Nothing
        Dim loList As New List(Of Byte())
        Dim lcCompanyId As String = ""

        Try
            lcCompanyId = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtnTemp = loCls.GetTypeList(lcCompanyId)

            loList = R_Utility.R_GetChunkData(Of SAM02400DTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTypeList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

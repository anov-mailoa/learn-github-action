Imports R_Common
Imports R_BackEnd
Imports JCM00100Back
Imports JCM00100Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "JCM00100StreamingService" in code, svc and config file together.
Public Class JCM00100StreamingService
    Implements IJCM00100StreamingService

    Public Function getList() As System.ServiceModel.Channels.Message Implements IJCM00100StreamingService.getList
        Dim loEx As New R_Exception
        Dim loCls As New JCM00100Cls
        Dim loRtnTemp As List(Of JCM00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New JCM00100DTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtnTemp = loCls.getList(loParam.cCompanyId)
            loList = R_Utility.R_GetChunkData(Of JCM00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

Imports R_Common
Imports SAM02300Back
Imports System.ServiceModel.Channels
Imports SAM02300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02300StreamingService" in code, svc and config file together.
Public Class SAM02300StreamingService
    Implements ISAM02300StreamingService

    Public Function GetReportList() As System.ServiceModel.Channels.Message Implements ISAM02300StreamingService.GetReportList
        Dim loException As New R_Exception
        Dim loCls As New SAM02300Cls
        Dim loRtnTemp As List(Of SAM02300DTOnon)
        Dim loRtn As Message
        Dim lcUserId As String
        Dim loList As New List(Of Byte())

        Try
            lcUserId = R_Utility.R_GetStreamingContext("CUSER_ID")

            loRtnTemp = loCls.GetReportList(lcUserId)

            loList = R_Utility.R_GetChunkData(Of SAM02300DTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetByteFile() As System.ServiceModel.Channels.Message Implements ISAM02300StreamingService.GetByteFile
        Dim loException As New R_Exception
        Dim loCls As New SAM02300Cls
        Dim loRtnTemp As List(Of SAM02300DTOnon)
        Dim loRtn As Message
        Dim lcUserId As String
        Dim lcGuid As String
        Dim loList As New List(Of Byte())

        Try
            lcGuid = R_Utility.R_GetStreamingContext("CREPORT_GUID")
            lcUserId = R_Utility.R_GetStreamingContext("CUSER_ID")

            loRtnTemp = loCls.GetByteFile(lcGuid, lcUserId)

            loList = R_Utility.R_GetChunkData(Of SAM02300DTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loRtnTemp.AsEnumerable, "GetByteFile")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

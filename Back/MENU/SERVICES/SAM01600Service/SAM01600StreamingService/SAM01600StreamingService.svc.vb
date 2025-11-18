Imports R_Common
Imports SAM01600Back
Imports System.ServiceModel.Channels
Imports SAM01600Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM01600StreamingService" in code, svc and config file together.
Public Class SAM01600StreamingService
    Implements ISAM01600StreamingService

    Public Function GetDatabaseName() As System.ServiceModel.Channels.Message Implements ISAM01600StreamingService.GetDatabaseName
        Dim loException As New R_Exception
        Dim loCls As New SAM01600Cls
        Dim loRtnTemp As List(Of DatabaseDTOnon)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO
        Dim loList As New List(Of Byte())

        Try
            With loParam
                .InstanceMode = R_Utility.R_GetStreamingContext("InstanceMode")
                .ConnectionString = R_Utility.R_GetStreamingContext("ConnectionString")
            End With

            loRtnTemp = loCls.GetDatabaseName(loParam)

            loList = R_Utility.R_GetChunkData(Of DatabaseDTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDatabaseName")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetServerName() As System.ServiceModel.Channels.Message Implements ISAM01600StreamingService.GetServerName
        Dim loException As New R_Exception
        Dim loCls As New SAM01600Cls
        Dim loRtnTemp As List(Of ServerDTOnon)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO
        Dim loList As New List(Of Byte())

        Try
            loParam.InstanceMode = R_Utility.R_GetStreamingContext("InstanceMode")

            loRtnTemp = loCls.GetServerName(loParam)

            loList = R_Utility.R_GetChunkData(Of ServerDTOnon)(loRtnTemp, R_BackEnd.R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetServerName")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar2 As System.Collections.Generic.List(Of SAM01600Back.DatabaseDTO), poPar3 As System.Collections.Generic.List(Of SAM01600Back.ServerDTO)) Implements ISAM01600StreamingService.Dummy

    End Sub
End Class

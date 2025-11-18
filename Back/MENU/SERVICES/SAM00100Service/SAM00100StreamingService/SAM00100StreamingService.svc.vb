Imports R_Common
Imports R_BackEnd
Imports SAM00100Back
Imports SAM00100Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM0100StreamingService" in code, svc and config file together.
Public Class SAM00100StreamingService
    Implements ISAM00100StreamingService


    Public Function getCurrList() As System.ServiceModel.Channels.Message Implements ISAM00100StreamingService.getCurrList
        Dim loException As New R_Exception
        Dim loCls As New SAM00100Cls
        Dim loRtnTemp As New List(Of SAM00100StreamingDTO)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.getCurrList()

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of SAM00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCurrList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of SAM00100Back.SAM00100GridDTO), poPar1 As System.Collections.Generic.List(Of SAM00100Back.SAM00110GridDTO)) Implements ISAM00100StreamingService.Dummy

    End Sub

    Public Function getListRateType() As System.ServiceModel.Channels.Message Implements ISAM00100StreamingService.getListRateType
        Dim loException As New R_Exception
        Dim loCls As New SAM00110Cls
        Dim loRtnTemp As List(Of SAM00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As String

        Try
            loParam = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.getListRateType(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of SAM00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListRateType")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

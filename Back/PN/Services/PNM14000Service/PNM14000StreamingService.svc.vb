Imports System.ServiceModel
Imports R_Common
Imports PNM14000Common
Imports PNM14000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14000StreamingService" in code, svc and config file together.

Public Class PNM14000StreamingService
    Implements IPNM14000StreamingService

    Public Function getListGeography() As System.ServiceModel.Channels.Message Implements IPNM14000StreamingService.getListGeography
        Dim loException As New R_Exception
        Dim loCls As New PNM14000Cls
        Dim loRtnTemp As List(Of PNM14000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            loRtnTemp = loCls.getListGeography()
            loList = R_Utility.R_GetChunkData(Of PNM14000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGeography")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PNM14000Back.PNM14000TreeDTO)) Implements IPNM14000StreamingService.Dummy

    End Sub
End Class

Imports R_Common
Imports System.ServiceModel.Channels
Imports PNM14300Back
Imports PNM14300Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14300StreamingService" in code, svc and config file together.
Public Class PNM14300StreamingService
    Implements IPNM14300StreamingService

    Public Function getListGrid() As System.ServiceModel.Channels.Message Implements IPNM14300StreamingService.getListGrid
        Dim loCls As New PNM14300Cls
        Dim poParam As New PNM14300DetailDTO
        Dim loRtnTemp As List(Of PNM14300StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getListGrid(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM14300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGrid")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of PNM14300Back.PNM14300GridDTO)) Implements IPNM14300StreamingService.Dummy

    End Sub
End Class

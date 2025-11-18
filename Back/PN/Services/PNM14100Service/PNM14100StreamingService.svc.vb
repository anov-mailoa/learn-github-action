Imports R_Common
Imports R_BackEnd
Imports PNM14100Back
Imports PNM14100Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14100StreamingService" in code, svc and config file together.
Public Class PNM14100StreamingService
    Implements IPNM14100StreamingService

    Public Function getDataGrid() As System.ServiceModel.Channels.Message Implements IPNM14100StreamingService.getDataGrid
        Dim loRtnTemp As List(Of PNM14100StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM14100Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM14100Dto

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.getDataGrid(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM14100StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListBPJSPerusahaan() As System.ServiceModel.Channels.Message Implements IPNM14100StreamingService.getListBPJSPerusahaan
        Dim loRtnTemp As List(Of PNM14100StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM14200Cls
        Dim loEx As New R_Exception
        Dim poParam As New PNM14200Dto

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getListBPJSPerusahaan(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM14100StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListBPJSPerusahaan")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParReguler As PNM14100Back.PNM14100Dto_R, poPar As System.Collections.Generic.List(Of PNM14100Back.PNM14500ParameterStreamingDTO)) Implements IPNM14100StreamingService.Dummy

    End Sub
End Class

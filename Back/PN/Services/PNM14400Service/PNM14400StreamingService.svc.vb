Imports R_Common
Imports System.ServiceModel.Channels
Imports PNM14400Back
Imports PNM14400Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14400StreamingService" in code, svc and config file together.
Public Class PNM14400StreamingService
    Implements IPNM14400StreamingService

    Public Function getListGrid() As System.ServiceModel.Channels.Message Implements IPNM14400StreamingService.getListGrid
        Dim loCls As New PNM14400PesertaBpjsKesehatanCls
        Dim poParam As New PNM14400PesertaBpjsKesehatanDetailDTO
        Dim loRtnTemp As List(Of PNM14400PesertaBpjsKesehatanStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            End With

            loRtnTemp = loCls.getListGrid(poParam)

            ' If there is data, convert to Message
            If loRtnTemp IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of PNM14400PesertaBpjsKesehatanStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGrid")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getKelasRawatInapList() As System.ServiceModel.Channels.Message Implements IPNM14400StreamingService.getKelasRawatInapList
        Dim loCls As New PNM14400PesertaBpjsKesehatanCls
        Dim poParam As New PNM14400PesertaBpjsKesehatanDetailDTO
        Dim loRtnTemp As List(Of PNM14400PesertaBpjsKesehatanStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cKodeBpjsPerusahaan = R_Utility.R_GetStreamingContext("cKodeBpjsPerusahaan")
            End With

            loRtnTemp = loCls.getKelasRawatInapList(poParam)

            ' If there is data, convert to Message
            If loRtnTemp IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of PNM14400PesertaBpjsKesehatanStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getKelasRawatInapList")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function getListDataKKGrid() As System.ServiceModel.Channels.Message Implements IPNM14400StreamingService.getListDataKKGrid
        Dim loCls As New PNM14400AnggotaBpjsCls
        Dim poParam As New PNM14400AnggotaBpjsDetailDTO
        Dim loRtnTemp As List(Of PNM14400AnggotaBpjsStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cLookUpLanguage = R_Utility.R_GetStreamingContext("cLookUpLanguage")
            End With

            loRtnTemp = loCls.getListDataKKGrid(poParam)

            ' If there is data, convert to Message
            If loRtnTemp IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of PNM14400AnggotaBpjsStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDataKKGrid")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PNM14400Back.PNM14400PesertaBpjsKesehatanGridDTO), poParam2 As System.Collections.Generic.List(Of PNM14400Back.PNM14400AnggotaBpjsGridDTO)) Implements IPNM14400StreamingService.Dummy

    End Sub
End Class

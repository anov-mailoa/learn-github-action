Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYM09000Back
Imports PYM09000Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM09000StreamingService" in code, svc and config file together.
Public Class PYM09000StreamingService
    Implements IPYM09000StreamingService

    Public Function getDispensasiList() As System.ServiceModel.Channels.Message Implements IPYM09000StreamingService.getDispensasiList
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000Cls
        Dim poParam As New PYM09000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM09000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnList = loCls.getDispensasiList(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM09000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDispensasiList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPeriodeDispensasi() As System.ServiceModel.Channels.Message Implements IPYM09000StreamingService.getPeriodeDispensasi
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000Cls
        Dim poParam As New PYM09000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM09000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTAHUN = R_Utility.R_GetStreamingContext("CTAHUN")
            End With

            loRtnList = loCls.getPeriodeDispensasi(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM09000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriodeDispensasi")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'KATEGORI
    Public Function getKategoriDispensasiPajakList() As System.ServiceModel.Channels.Message Implements IPYM09000StreamingService.getKategoriDispensasiPajakList
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KategoriCls
        Dim poParam As New PYM09000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM09000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTAHUN = R_Utility.R_GetStreamingContext("CTAHUN")
                .ISEQUENCE = R_Utility.R_GetStreamingContext("ISEQUENCE")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
            End With

            loRtnList = loCls.getKategoriDispensasiPajakList(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM09000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getKategoriDispensasiPajakList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookupKategoriDispensasi() As System.ServiceModel.Channels.Message Implements IPYM09000StreamingService.getLookupKategoriDispensasi
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KategoriCls
        Dim poParam As New PYM09000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM09000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTAHUN = R_Utility.R_GetStreamingContext("CTAHUN")
                .ISEQUENCE = R_Utility.R_GetStreamingContext("ISEQUENCE")
                .CKODE_KATEGORI = R_Utility.R_GetStreamingContext("CKODE_KATEGORI")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
            End With

            loRtnList = loCls.getLookupKategoriDispensasi(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM09000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookupKategoriDispensasi")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'KOMPONEN
    Public Function getCmbBoxGrupGaji() As System.ServiceModel.Channels.Message Implements IPYM09000StreamingService.getCmbBoxGrupGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KomponenCls
        Dim poParam As New PYM09000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM09000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTAHUN = R_Utility.R_GetStreamingContext("CTAHUN")
                .ISEQUENCE = R_Utility.R_GetStreamingContext("ISEQUENCE")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
            End With

            loRtnList = loCls.getCmbBoxGrupGaji(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM09000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbBoxGrupGaji")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGrupGajiList() As System.ServiceModel.Channels.Message Implements IPYM09000StreamingService.getGrupGajiList
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KomponenCls
        Dim poParam As New PYM09000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM09000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTAHUN = R_Utility.R_GetStreamingContext("CTAHUN")
                .ISEQUENCE = R_Utility.R_GetStreamingContext("ISEQUENCE")
            End With

            loRtnList = loCls.getGrupGajiList(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM09000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGajiList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getKomponenList() As System.ServiceModel.Channels.Message Implements IPYM09000StreamingService.getKomponenList
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KomponenCls
        Dim poParam As New PYM09000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM09000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTAHUN = R_Utility.R_GetStreamingContext("CTAHUN")
                .ISEQUENCE = R_Utility.R_GetStreamingContext("ISEQUENCE")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
            End With

            loRtnList = loCls.getKomponenList(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM09000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getKomponenList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookupKomponen() As System.ServiceModel.Channels.Message Implements IPYM09000StreamingService.getLookupKomponen
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KomponenCls
        Dim poParam As New PYM09000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYM09000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTAHUN = R_Utility.R_GetStreamingContext("CTAHUN")
                .ISEQUENCE = R_Utility.R_GetStreamingContext("ISEQUENCE")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .IMODE = R_Utility.R_GetStreamingContext("IMODE")
            End With

            loRtnList = loCls.getLookupKomponen(poParam)
            loList = R_Utility.R_GetChunkData(Of PYM09000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookupKomponen")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

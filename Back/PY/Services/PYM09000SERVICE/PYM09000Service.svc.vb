Imports R_Common
Imports PYM09000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM09000Service" in code, svc and config file together.
Public Class PYM09000Service
    Implements IPYM09000Service

    Public Sub Svc_R_Delete(poEntity As PYM09000Back.PYM09000DTO) Implements R_BackEnd.R_IServicebase(Of PYM09000Back.PYM09000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM09000Back.PYM09000DTO) As PYM09000Back.PYM09000DTO Implements R_BackEnd.R_IServicebase(Of PYM09000Back.PYM09000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000Cls
        Dim loRtn As PYM09000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM09000Back.PYM09000DTO, poCRUDMode As R_Common.eCRUDMode) As PYM09000Back.PYM09000DTO Implements R_BackEnd.R_IServicebase(Of PYM09000Back.PYM09000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000Cls
        Dim loRtn As PYM09000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMinMaxDurasiDispensasi(poParam As PYM09000Back.PYM09000DTO) As Integer Implements IPYM09000Service.getMinMaxDurasiDispensasi
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000Cls
        Dim liRtn As Integer

        Try
            liRtn = loCls.getMinMaxDurasiDispensasi(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return liRtn
    End Function

    Public Function getMinTahunDispensasi(poParam As PYM09000Back.PYM09000DTO) As String Implements IPYM09000Service.getMinTahunDispensasi
        Dim loCls As New PYM09000Cls
        Dim lcRtn As String
        Dim loEx As New R_Exception

        Try
            lcRtn = loCls.getMinTahunDispensasi(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcRtn
    End Function

    Public Sub deleteKategoriDispensasiPajak(poParam As PYM09000Back.PYM09000DTO) Implements IPYM09000Service.deleteKategoriDispensasiPajak
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KategoriCls

        Try
            loCls.deleteKategoriDispensasiPajak(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function saveKategoriDispensasiPajak(poParam As PYM09000Back.PYM09000DTO) As Boolean Implements IPYM09000Service.saveKategoriDispensasiPajak
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KategoriCls
        Dim llRtn As Boolean

        Try
            llRtn = loCls.saveKategoriDispensasiPajak(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return llRtn
    End Function

    Public Function cekProsesGaji(poParam As PYM09000Back.PYM09000DTO) As Boolean Implements IPYM09000Service.cekProsesGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000Cls
        Dim llRtn As Boolean

        Try
            llRtn = loCls.cekProsesGaji(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return llRtn
    End Function

    Public Function checkEnableGrupGaji(poParam As PYM09000Back.PYM09000DTO) As Boolean Implements IPYM09000Service.checkEnableGrupGaji
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KomponenCls
        Dim llRtn As Boolean

        Try
            llRtn = loCls.checkEnableGrupGaji(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return llRtn
    End Function

    Public Sub deleteKomponenDispensasiPajak(poParam As PYM09000Back.PYM09000DTO) Implements IPYM09000Service.deleteKomponenDispensasiPajak
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KomponenCls

        Try
            loCls.deleteKomponenDispensasiPajak(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub saveKomponenDispensasiPajak(poParam As PYM09000Back.PYM09000DTO) Implements IPYM09000Service.saveKomponenDispensasiPajak
        Dim loEx As New R_Exception
        Dim loCls As New PYM09000KomponenCls

        Try
            loCls.saveKomponenDispensasiPajak(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class

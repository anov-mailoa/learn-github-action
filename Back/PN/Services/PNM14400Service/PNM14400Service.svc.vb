Imports R_BackEnd
Imports R_Common
Imports PNM14400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14400Service" in code, svc and config file together.
Public Class PNM14400Service
    Implements IPNM14400Service

    Public Function Activate(poParam As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO) As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO Implements IPNM14400Service.Activate
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400PesertaBpjsKesehatanCls
        Dim loRtn As New PNM14400PesertaBpjsKesehatanDetailDTO
        Try
            loRtn = loCls.Activate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Deactivate(poParam As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO) As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO Implements IPNM14400Service.Deactivate
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400PesertaBpjsKesehatanCls
        Dim loRtn As New PNM14400PesertaBpjsKesehatanDetailDTO
        Try
            loRtn = loCls.Deactivate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Svc_R_Delete1(poEntity As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO) Implements R_BackEnd.R_IServicebase(Of PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord1(poEntity As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO) As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO Implements R_BackEnd.R_IServicebase(Of PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400PesertaBpjsKesehatanCls
        Dim loRtn As New PNM14400PesertaBpjsKesehatanDetailDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save1(poEntity As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO, poCRUDMode As R_Common.eCRUDMode) As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO Implements R_BackEnd.R_IServicebase(Of PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400PesertaBpjsKesehatanCls
        Dim loRtn As New PNM14400PesertaBpjsKesehatanDetailDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getEmployeeDetail(poParam As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO) As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO Implements IPNM14400Service.getEmployeeDetail
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400PesertaBpjsKesehatanCls
        Dim loRtn As New PNM14400PesertaBpjsKesehatanDetailDTO
        Try
            loRtn = loCls.getEmployeeDetail(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getKodeBpjsPerusahaan(poParam As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO) As PNM14400Back.PNM14400PesertaBpjsKesehatanDetailDTO Implements IPNM14400Service.getKodeBpjsPerusahaan
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400PesertaBpjsKesehatanCls
        Dim loRtn As New PNM14400PesertaBpjsKesehatanDetailDTO
        Try
            loRtn = loCls.getKodeBpjsPerusahaan(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub checkEmployeeExist(pcCompId As String, pcEmpId As String) Implements IPNM14400Service.checkEmployeeExist
        Dim loEx As New R_Exception
        Dim loCls As New PNM14400PesertaBpjsKesehatanCls
        Dim loRtn As New PNM14400PesertaBpjsKesehatanDetailDTO
        Try
            loCls.checkEmployeeExist(pcCompId, pcEmpId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class

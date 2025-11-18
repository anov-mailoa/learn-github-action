Imports R_Common
Imports PYM00900Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00900SalaryProcessService" in code, svc and config file together.
Public Class PYM00900SalaryProcessService
    Implements IPYM00900SalaryProcessService

    Public Sub Svc_R_Delete(poEntity As PYM00900Back.PYM00900SalaryProcessDTO) Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900SalaryProcessDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SalaryProcessCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00900Back.PYM00900SalaryProcessDTO) As PYM00900Back.PYM00900SalaryProcessDTO Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900SalaryProcessDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SalaryProcessCls
        Dim loRtn As PYM00900SalaryProcessDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00900Back.PYM00900SalaryProcessDTO, poCRUDMode As R_Common.eCRUDMode) As PYM00900Back.PYM00900SalaryProcessDTO Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900SalaryProcessDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SalaryProcessCls
        Dim loRtn As PYM00900SalaryProcessDTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getValidasi(poParam As PYM00900Back.PYM00900SalaryProcessDTO) As Integer Implements IPYM00900SalaryProcessService.getValidasi
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SalaryProcessCls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getValidasi(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getValidasiComponentTwice(poParam As PYM00900Back.PYM00900SalaryProcessDTO) As Integer Implements IPYM00900SalaryProcessService.getValidasiComponentTwice

        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SalaryProcessCls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getValidasiComponentTwice(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RFN_IS_POSTING_VALID(poParam As PYM00900Back.PYM00900SalaryProcessDTO) As Boolean Implements IPYM00900SalaryProcessService.RFN_IS_POSTING_VALID
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SalaryProcessCls
        Dim llRtn As Boolean

        Try
            llRtn = loCls.RFN_IS_POSTING_VALID(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return llRtn
    End Function

End Class

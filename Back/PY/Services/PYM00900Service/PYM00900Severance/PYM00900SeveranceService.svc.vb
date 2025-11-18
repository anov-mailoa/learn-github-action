Imports R_Common
Imports PYM00900Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00900SeveranceService" in code, svc and config file together.
Public Class PYM00900SeveranceService
    Implements IPYM00900SeveranceService

    Public Sub Svc_R_Delete(poEntity As PYM00900Back.PYM00900SalaryProcessDTO) Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900SalaryProcessDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SeveranceCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00900Back.PYM00900SalaryProcessDTO) As PYM00900Back.PYM00900SalaryProcessDTO Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900SalaryProcessDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SeveranceCls
        Dim loRtn As PYM00900SalaryProcessDTO

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
        Dim loCls As New PYM00900SeveranceCls
        Dim loRtn As PYM00900SalaryProcessDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

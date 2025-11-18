Imports R_Common
Imports R_BackEnd
Imports ATM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00400AnnualService" in code, svc and config file together.
Public Class ATM00400AnnualService
    Implements IATM00400AnnualService
     
    Public Sub Svc_R_Delete(poEntity As ATM00400Back.ATM00400AnnualDTO) Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400AnnualDTO).Svc_R_Delete
         Dim loEx As New R_Exception
        Dim loCls As New ATM00400AnnualLeaveCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00400Back.ATM00400AnnualDTO) As ATM00400Back.ATM00400AnnualDTO Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400AnnualDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00400AnnualLeaveCLS
        Dim loRtn As ATM00400AnnualDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As ATM00400Back.ATM00400AnnualDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00400Back.ATM00400AnnualDTO Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400AnnualDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00400AnnualLeaveCLS
        Dim loRtn As ATM00400AnnualDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

Imports R_Common
Imports PYM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00400KPPMasterService" in code, svc and config file together.
Public Class PYM00400KPPMasterService
    Implements IPYM00400KPPMasterService

    Public Sub DoWork() Implements IPYM00400KPPMasterService.DoWork
    End Sub

    Public Sub SaveIDTKU(poParam As System.Collections.Generic.List(Of PYM00400Back.PYM00400KPPMasterDTO), compid As String) Implements IPYM00400KPPMasterService.SaveIDTKU
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400KPPMasterCLS
        Try
            loCls.SaveIDTKU(poParam, compid)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub


    Public Sub Svc_R_Delete(poEntity As PYM00400Back.PYM00400KPPMasterDTO) Implements R_BackEnd.R_IServicebase(Of PYM00400Back.PYM00400KPPMasterDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400KPPMasterCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00400Back.PYM00400KPPMasterDTO) As PYM00400Back.PYM00400KPPMasterDTO Implements R_BackEnd.R_IServicebase(Of PYM00400Back.PYM00400KPPMasterDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400KPPMasterCLS
        Dim loRtn As New PYM00400KPPMasterDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00400Back.PYM00400KPPMasterDTO, poCRUDMode As R_Common.eCRUDMode) As PYM00400Back.PYM00400KPPMasterDTO Implements R_BackEnd.R_IServicebase(Of PYM00400Back.PYM00400KPPMasterDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400KPPMasterCLS
        Dim loRtn As New PYM00400KPPMasterDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PYM00400Back.PYM00400KPPMasterGridDTO)) Implements IPYM00400KPPMasterService.Dummy

    End Sub
End Class

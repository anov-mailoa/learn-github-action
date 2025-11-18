Imports R_Common
Imports PYT00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00100ComponentService" in code, svc and config file together.
Public Class PYT00100ComponentService
    Implements IPYT00100ComponentService

    'Public Sub Svc_R_Delete(poEntity As PYT00100Back.PYT00100ComponentDTO) Implements R_BackEnd.R_IServicebase(Of PYT00100Back.PYT00100ComponentDTO).Svc_R_Delete
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PYT00100ComponentCls

    '    Try
    '        loCls.R_Delete(poEntity)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub

    'Public Function Svc_R_GetRecord(poEntity As PYT00100Back.PYT00100ComponentDTO) As PYT00100Back.PYT00100ComponentDTO Implements R_BackEnd.R_IServicebase(Of PYT00100Back.PYT00100ComponentDTO).Svc_R_GetRecord
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PYT00100ComponentCls
    '    Dim loRtn As PYT00100ComponentDTO = Nothing

    '    Try
    '        loRtn = loCls.R_GetRecord(poEntity)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function Svc_R_Save(poEntity As PYT00100Back.PYT00100ComponentDTO, poCRUDMode As R_Common.eCRUDMode) As PYT00100Back.PYT00100ComponentDTO Implements R_BackEnd.R_IServicebase(Of PYT00100Back.PYT00100ComponentDTO).Svc_R_Save
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PYT00100ComponentCls
    '    Dim loRtn As PYT00100ComponentDTO = Nothing

    '    Try
    '        loRtn = loCls.R_Save(poEntity, poCRUDMode)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function getLookUpFormula(poParam As PYT00100Back.PYT00100ComponentDTO) As System.Collections.Generic.List(Of PYT00100Back.PYT00100ComponentDTO) Implements IPYT00100ComponentService.getLookUpFormula
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00100ComponentCls
    '    Dim loRtn As List(Of PYT00100ComponentDTO)

    '    Try
    '        loRtn = loCls.getLookUpFormula(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function
End Class

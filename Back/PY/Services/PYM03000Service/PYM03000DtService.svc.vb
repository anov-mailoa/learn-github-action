Imports R_Common
Imports R_BackEnd
Imports PYM03000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM03000DtService" in code, svc and config file together.
Public Class PYM03000DtService
    Implements IPYM03000DtService

    Public Sub Svc_R_Delete(poEntity As PYM03000Back.PYM03000DtDTO) Implements R_BackEnd.R_IServicebase(Of PYM03000Back.PYM03000DtDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM03000Back.PYM03000DtDTO) As PYM03000Back.PYM03000DtDTO Implements R_BackEnd.R_IServicebase(Of PYM03000Back.PYM03000DtDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM03000DetailCls
        Dim loRtn As New PYM03000DtDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM03000Back.PYM03000DtDTO, poCRUDMode As R_Common.eCRUDMode) As PYM03000Back.PYM03000DtDTO Implements R_BackEnd.R_IServicebase(Of PYM03000Back.PYM03000DtDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM03000DetailCls
        Dim loRtn As New PYM03000DtDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

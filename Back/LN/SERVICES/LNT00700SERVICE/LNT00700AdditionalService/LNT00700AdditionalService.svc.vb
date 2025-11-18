Imports R_BackEnd
Imports R_Common
Imports LNT00700Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00700AdditionalService" in code, svc and config file together.
Public Class LNT00700AdditionalService
    Implements ILNT00700AdditionalService


    Public Sub Svc_R_Delete(poEntity As LNT00700Back.LNT00700AdditionalDto) Implements R_BackEnd.R_IServicebase(Of LNT00700Back.LNT00700AdditionalDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNT00700AdditionalCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNT00700Back.LNT00700AdditionalDto) As LNT00700Back.LNT00700AdditionalDto Implements R_BackEnd.R_IServicebase(Of LNT00700Back.LNT00700AdditionalDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNT00700AdditionalCls
        Dim loRtn As LNT00700AdditionalDto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNT00700Back.LNT00700AdditionalDto, poCRUDMode As R_Common.eCRUDMode) As LNT00700Back.LNT00700AdditionalDto Implements R_BackEnd.R_IServicebase(Of LNT00700Back.LNT00700AdditionalDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNT00700AdditionalCls
        Dim loRtn As LNT00700AdditionalDto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Draft(poParam As LNT00700Back.LNT00700AdditionalDto) As LNT00700Back.LNT00700AdditionalDto Implements ILNT00700AdditionalService.Draft
        Dim loEx As New R_Exception
        Dim loCls As New LNT00700AdditionalCls
        Dim loRtn As New LNT00700AdditionalDto

        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As LNT00700Back.LNT00700AdditionalDto) As LNT00700Back.LNT00700AdditionalDto Implements ILNT00700AdditionalService.Submit
        Dim loEx As New R_Exception
        Dim loCls As New LNT00700AdditionalCls
        Dim loRtn As New LNT00700AdditionalDto

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

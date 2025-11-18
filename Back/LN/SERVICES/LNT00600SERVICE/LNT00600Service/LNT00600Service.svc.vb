Imports R_BackEnd
Imports R_Common
Imports LNT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00600Service" in code, svc and config file together.
Public Class LNT00600Service
    Implements ILNT00600Service

    Public Sub Svc_R_Delete(poEntity As LNT00600Back.LNT00600Dto) Implements R_BackEnd.R_IServicebase(Of LNT00600Back.LNT00600Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNT00600Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNT00600Back.LNT00600Dto) As LNT00600Back.LNT00600Dto Implements R_BackEnd.R_IServicebase(Of LNT00600Back.LNT00600Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNT00600Cls
        Dim loRtn As LNT00600Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNT00600Back.LNT00600Dto, poCRUDMode As R_Common.eCRUDMode) As LNT00600Back.LNT00600Dto Implements R_BackEnd.R_IServicebase(Of LNT00600Back.LNT00600Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNT00600Cls
        Dim loRtn As LNT00600Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getTransactionProfile(poParam As LNT00600Back.LNT00600Dto) As LNT00600Back.LNT00600Dto Implements ILNT00600Service.getTransactionProfile
        Dim loCls As New LNT00600Cls
        Dim loRtn As New LNT00600Dto
        Dim loEx As New R_Exception()

        Try
            loRtn = loCls.getTransactionProfile(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Draft(poParam As LNT00600Back.LNT00600Dto) As LNT00600Back.LNT00600Dto Implements ILNT00600Service.Draft
        Dim loEx As New R_Exception
        Dim loCls As New LNT00600Cls
        Dim loRtn As New LNT00600Dto

        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As LNT00600Back.LNT00600Dto) As LNT00600Back.LNT00600Dto Implements ILNT00600Service.Submit
        Dim loEx As New R_Exception
        Dim loCls As New LNT00600Cls
        Dim loRtn As New LNT00600Dto

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getRemaining(poParam As LNT00600Back.LNT00600Dto) As LNT00600Back.LNT00600Dto Implements ILNT00600Service.getRemaining
        Dim loEx As New R_Exception
        Dim loCls As New LNT00600Cls
        Dim loRtn As New LNT00600Dto

        Try
            loRtn = loCls.getRemaining(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkStatus(poParam As LNT00600Back.LNT00600Dto) As Boolean Implements ILNT00600Service.checkStatus
        Dim loEx As New R_Exception
        Dim loCls As New LNT00600Cls
        Dim llRtn As Boolean

        Try
            llRtn = loCls.checkStatus(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return llRtn
    End Function
End Class

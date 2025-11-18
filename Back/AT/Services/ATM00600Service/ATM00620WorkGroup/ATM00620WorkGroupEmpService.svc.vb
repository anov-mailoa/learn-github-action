Imports System.ServiceModel
Imports ATM00600Back
Imports R_Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00620WorkGroupEmpService" in code, svc and config file together.
Public Class ATM00620WorkGroupEmpService
    Implements IATM00620WorkGroupEmpService

    Public Sub Svc_R_Delete(ByVal poEntity As ATM00600Back.ATM00620WorkGroupEmpDTO) Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00620WorkGroupEmpDTO).Svc_R_Delete
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupEmpCls

            loClass.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As ATM00600Back.ATM00620WorkGroupEmpDTO) As ATM00600Back.ATM00620WorkGroupEmpDTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00620WorkGroupEmpDTO).Svc_R_GetRecord
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupEmpCls

            Return loClass.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_R_Save(ByVal poEntity As ATM00600Back.ATM00620WorkGroupEmpDTO, ByVal poCRUDMode As R_Common.eCRUDMode) As ATM00600Back.ATM00620WorkGroupEmpDTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00620WorkGroupEmpDTO).Svc_R_Save
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupEmpCls

            Return loClass.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function


    Public Sub DeleteSection(ByVal poParam As ATM00600Back.ATM00620WorkGroupEmpDTO) Implements IATM00620WorkGroupEmpService.DeleteSection
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupEmpCls

            loClass.DeleteSection(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function DeleteValidation(ByVal poParam As ATM00600Back.ATM00620WorkGroupEmpDTO) As ATM00600Back.ATM00620WorkGroupEmpDTO Implements IATM00620WorkGroupEmpService.DeleteValidation
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupEmpCls

            Return loClass.DeleteValidation(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function BatchValidation(ByVal poParam As ATM00600Back.ATM00620WorkGroupEmpDTO) As ATM00600Back.ATM00620WorkGroupEmpDTO Implements IATM00620WorkGroupEmpService.BatchValidation
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupEmpCls

            Return loClass.BatchValidation(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Sub DeleteBatchSection(ByVal poParam As ATM00600Back.ATM00620WorkGroupEmpDTO) Implements IATM00620WorkGroupEmpService.DeleteBatchSection
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupEmpCls

            loClass.DeleteBatchSection(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function DeleteBatchValidation(ByVal poParam As ATM00600Back.ATM00620WorkGroupEmpDTO) As ATM00600Back.ATM00620WorkGroupEmpDTO Implements IATM00620WorkGroupEmpService.DeleteBatchValidation
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupEmpCls

            Return loClass.DeleteBatchValidation(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class

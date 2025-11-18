Imports System.ServiceModel
Imports ATM00600Back
Imports R_Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00620WorkGroupService" in code, svc and config file together.
Public Class ATM00620WorkGroupService
    Implements IATM00620WorkGroupService

    Public Sub Svc_R_Delete(ByVal poEntity As ATM00600Back.ATM00620WorkGroupDTO) Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00620WorkGroupDTO).Svc_R_Delete
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupCls

            loClass.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As ATM00600Back.ATM00620WorkGroupDTO) As ATM00600Back.ATM00620WorkGroupDTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00620WorkGroupDTO).Svc_R_GetRecord
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupCls

            Return loClass.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_R_Save(ByVal poEntity As ATM00600Back.ATM00620WorkGroupDTO, ByVal poCRUDMode As R_Common.eCRUDMode) As ATM00600Back.ATM00620WorkGroupDTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00620WorkGroupDTO).Svc_R_Save
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupCls

            Return loClass.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Sub CopyToProcess(ByVal poParam As ATM00600Back.ATM00620WorkGroupDTO) Implements IATM00620WorkGroupService.CopyToProcess
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATM00620WorkGroupCls

            loClass.CopyToProcess(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub


End Class

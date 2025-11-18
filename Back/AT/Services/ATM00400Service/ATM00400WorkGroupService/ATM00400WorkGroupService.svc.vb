' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00400WorkGroupService" in code, svc and config file together.
Imports R_Common
Imports R_BackEnd
Imports ATM00400Back

Public Class ATM00400WorkGroupService
    Implements IATM00400WorkGroupService
     
    Public Sub Svc_R_Delete(poEntity As ATM00400Back.ATM00400WorkGroupDTO) Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400WorkGroupDTO).Svc_R_Delete
          Dim loEx As New R_Exception
        Dim loCls As New ATM00400WorkGroupCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00400Back.ATM00400WorkGroupDTO) As ATM00400Back.ATM00400WorkGroupDTO Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400WorkGroupDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00400WorkGroupCLS
        Dim loRtn As ATM00400WorkGroupDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00400Back.ATM00400WorkGroupDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00400Back.ATM00400WorkGroupDTO Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400WorkGroupDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00400WorkGroupCLS
        Dim loRtn As ATM00400WorkGroupDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

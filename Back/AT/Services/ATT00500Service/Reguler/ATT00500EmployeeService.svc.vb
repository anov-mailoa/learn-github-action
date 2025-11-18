Imports System.ServiceModel
Imports R_Common
Imports ATT00500Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00500EmployeeService" in code, svc and config file together.
Public Class ATT00500EmployeeService
    Implements IATT00500EmployeeService


    Public Sub DoWork() Implements IATT00500EmployeeService.DoWork
    End Sub

    Public Sub Svc_R_Delete(poEntity As ATT00500Back.ATT00500EmployeeDTO) Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500EmployeeDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500EmployeeCLS
        Dim loRtn As ATT00500EmployeeDTO
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00500Back.ATT00500EmployeeDTO) As ATT00500Back.ATT00500EmployeeDTO Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500EmployeeDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500EmployeeCLS
        Dim loRtn As ATT00500EmployeeDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT00500Back.ATT00500EmployeeDTO, poCRUDMode As R_Common.eCRUDMode) As ATT00500Back.ATT00500EmployeeDTO Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500EmployeeDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500EmployeeCLS
        Dim loRtn As ATT00500EmployeeDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

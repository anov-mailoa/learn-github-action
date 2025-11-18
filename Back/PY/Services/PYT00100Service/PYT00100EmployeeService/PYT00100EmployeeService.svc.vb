Imports R_Common
Imports PYT00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00100EmployeeService" in code, svc and config file together.
Public Class PYT00100EmployeeService
    Implements IPYT00100EmployeeService

    Public Sub checkDetail(poParam As PYT00100Back.PYT00100EmployeeDTO) Implements IPYT00100EmployeeService.checkDetail
        Dim loException As New R_Exception
        'Dim loCls As New PYT00100EmployeeCls

        Try
            'loCls.checkDetail(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub CheckIfExistUpload(poParam As PYT00100Back.PYT00100EmployeeDTO) Implements IPYT00100EmployeeService.CheckIfExistUpload
        Dim loException As New R_Exception
        'Dim loCls As New PYT00100EmployeeCls

        Try
            'loCls.CheckIfExistUpload(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

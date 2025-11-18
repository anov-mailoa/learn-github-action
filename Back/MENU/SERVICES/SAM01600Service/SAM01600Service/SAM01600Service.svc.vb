Imports R_Common
Imports SAM01600Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM01600Service" in code, svc and config file together.
Public Class SAM01600Service
    Implements ISAM01600Service

    'Public Function CheckCompany(pcConn As String, pcCompId As String, pcCompName As String) As Boolean Implements ISAM01600Service.CheckCompany
    '    Dim loException As New R_Exception

    '    Try
    '        Dim loClass As New SAM01600Cls

    '        Return loClass.CheckCompany(pcConn, pcCompId, pcCompName)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try
    '    loException.ConvertAndThrowToServiceExceptionIfErrors()
    'End Function

    'Public Sub BackupSource(pcPath As String) Implements ISAM01600Service.BackupSource
    'Dim loException As New R_Exception

    'Try
    '    Dim loClass As New SAM01600Cls

    '    loClass.BackupSource(pcPath)
    'Catch ex As Exception
    '    loException.Add(ex)
    'End Try
    'loException.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub

    'Public Function GetServerNameCurrent() As System.Collections.Generic.List(Of SAM01600Back.ServerDTO) Implements ISAM01600Service.GetServerNameCurrent
    '    Dim loException As New R_Exception

    '    Try
    '        Dim loClass As New SAM01600Cls

    '        Return loClass.GetServerNameCurrent()
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try
    '    loException.ConvertAndThrowToServiceExceptionIfErrors()
    'End Function

    Public Sub CheckCompany(poParam As SAM01600Back.ParameterDTO) Implements ISAM01600Service.CheckCompany
        Dim loException As New R_Exception

        Try
            Dim loClass As New SAM01600Cls

            loClass.CheckCompany(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

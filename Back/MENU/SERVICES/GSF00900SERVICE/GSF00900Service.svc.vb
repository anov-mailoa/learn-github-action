' NOTE: You can use the "Rename" command on the context menu to change the class name "GSB00100Service" in code, svc and config file together.
Imports R_Common
Imports GSF00900Back

Public Class GSF00900Service
    Implements IGSF00900Service

    Public Sub cekUserPassword(poParam As GSF00900Back.GSF00900DTO) Implements IGSF00900Service.cekUserPassword
        Dim loEx As New R_Exception
        Dim loCls As New GSF00900CLS
        Try
            loCls.cekUserPassword(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub


    Public Function RSP_ACTIVITY_VALIDITY(poParam As GSF00900Back.GSF00900DTO) As System.Collections.Generic.List(Of GSF00900Back.GSF00900DTO) Implements IGSF00900Service.RSP_ACTIVITY_VALIDITY
        Dim loEx As New R_Exception
        Dim loCls As New GSF00900CLS
        Dim loRtn As New List(Of GSF00900DTO)
        Try
            loRtn = loCls.RSP_ACTIVITY_VALIDITY(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ESM00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00100StructuralService" in code, svc and config file together.
Public Class ESM00100StructuralService
    Implements IESM00100StructuralService

    Public Function GetApprovalCode(poParam As ESM00100Back.ESM00100StructuralDTO) As String Implements IESM00100StructuralService.GetApprovalCode
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100StructuralCls
        Dim loRtn As String = ""

        Try
            loRtn = loCls.GetApprovalCode(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

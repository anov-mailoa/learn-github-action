Imports R_BackEnd
Imports R_Common
Imports JCT01100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "JCT01100Service" in code, svc and config file together.
Public Class JCT01100Service
    Implements IJCT01100Service

    Public Sub Svc_R_Delete(poEntity As JCT01100Back.JCT01100DTO) Implements R_BackEnd.R_IServicebase(Of JCT01100Back.JCT01100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As JCT01100Back.JCT01100DTO) As JCT01100Back.JCT01100DTO Implements R_BackEnd.R_IServicebase(Of JCT01100Back.JCT01100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As JCT01100Back.JCT01100DTO, poCRUDMode As R_Common.eCRUDMode) As JCT01100Back.JCT01100DTO Implements R_BackEnd.R_IServicebase(Of JCT01100Back.JCT01100DTO).Svc_R_Save

    End Function

    Public Function getEvaluationYear() As String Implements IJCT01100Service.getEvaluationYear
        Dim loEx As New R_Exception
        Dim loCls As New JCT01100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getEvaluationYear()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getHeader(poParam As JCT01100Back.JCT01100DTO) As JCT01100Back.JCT01100DTO Implements IJCT01100Service.getHeader
        Dim loEx As New R_Exception
        Dim loCls As New JCT01100Cls
        Dim loRtn As New JCT01100DTO

        Try
            loRtn = loCls.getHeader(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

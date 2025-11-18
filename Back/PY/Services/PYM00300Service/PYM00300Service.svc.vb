Imports R_Common
Imports PYM00300Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00300Service" in code, svc and config file together.
Public Class PYM00300Service
    Implements IPYM00300Service

    Public Sub Svc_R_Delete(poEntity As PYM00300Back.PYM00300DTO) Implements R_BackEnd.R_IServicebase(Of PYM00300Back.PYM00300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00300Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00300Back.PYM00300DTO) As PYM00300Back.PYM00300DTO Implements R_BackEnd.R_IServicebase(Of PYM00300Back.PYM00300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00300Cls
        Dim loRtn As PYM00300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00300Back.PYM00300DTO, poCRUDMode As R_Common.eCRUDMode) As PYM00300Back.PYM00300DTO Implements R_BackEnd.R_IServicebase(Of PYM00300Back.PYM00300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00300Cls
        Dim loRtn As PYM00300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub getCheckSyntax(pcCompId As String, pcFormula As String, plIsFilter As Boolean) Implements IPYM00300Service.getCheckSyntax
        Dim loCls As New PYM00300Cls
        Dim loEx As New R_Exception

        Try
            loCls.getCheckSyntax(pcCompId, pcFormula, plIsFilter)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class

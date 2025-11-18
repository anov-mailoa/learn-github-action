Imports R_Common
Imports R_BackEnd
Imports PYM01300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01300Service" in code, svc and config file together.
Public Class PYM01300Service
    Implements IPYM01300Service

    Public Sub Svc_R_Delete(poEntity As PYM01300Back.PYM01300DTO) Implements R_BackEnd.R_IServicebase(Of PYM01300Back.PYM01300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM01300Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM01300Back.PYM01300DTO) As PYM01300Back.PYM01300DTO Implements R_BackEnd.R_IServicebase(Of PYM01300Back.PYM01300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM01300Cls
        Dim loRtn As PYM01300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM01300Back.PYM01300DTO, poCRUDMode As R_Common.eCRUDMode) As PYM01300Back.PYM01300DTO Implements R_BackEnd.R_IServicebase(Of PYM01300Back.PYM01300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM01300Cls
        Dim loRtn As PYM01300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Sub getCheckSyntax(pcSyntax As String) Implements IPYM01300Service.getCheckSyntax
        Dim loCls As New PYM01300Cls
        Dim loEx As New R_Exception


        Try
            loCls.getCheckSyntax(pcSyntax)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class

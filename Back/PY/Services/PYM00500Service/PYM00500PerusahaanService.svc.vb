' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00500PerusahaanService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PYM00500Back
Imports System.ServiceModel

Public Class PYM00500PerusahaanService
    Implements IPYM00500PerusahaanService

    Public Sub Svc_R_Delete(poEntity As PYM00500Back.PYM00500PerusahaanDTO) Implements R_BackEnd.R_IServicebase(Of PYM00500Back.PYM00500PerusahaanDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00500PerusahaanCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00500Back.PYM00500PerusahaanDTO) As PYM00500Back.PYM00500PerusahaanDTO Implements R_BackEnd.R_IServicebase(Of PYM00500Back.PYM00500PerusahaanDTO).Svc_R_GetRecord

        Dim loEx As New R_Exception
        Dim loCls As New PYM00500PerusahaanCLS
        Dim loRtn As PYM00500PerusahaanDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As PYM00500Back.PYM00500PerusahaanDTO, poCRUDMode As R_Common.eCRUDMode) As PYM00500Back.PYM00500PerusahaanDTO Implements R_BackEnd.R_IServicebase(Of PYM00500Back.PYM00500PerusahaanDTO).Svc_R_Save

        Dim loEx As New R_Exception
        Dim loCls As New PYM00500PerusahaanCLS
        Dim loRtn As PYM00500PerusahaanDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    'Public Function checkDelete(pcJamsostekCode As String) As Boolean Implements IPYM00500PerusahaanService.checkDelete
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PYM00500PerusahaanCLS
    '    Dim loRtn As Boolean

    '    Try
    '        loRtn = loCls.checkDelete(pcJamsostekCode)

    '    Catch ex As Exception
    '        loEx.Add(ex)

    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    '    Return loRtn

    'End Function

    Public Function checkDelete(poParam As PYM00500Back.PYM00500PerusahaanDTO) As Boolean Implements IPYM00500PerusahaanService.checkDelete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00500PerusahaanCLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkDelete(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

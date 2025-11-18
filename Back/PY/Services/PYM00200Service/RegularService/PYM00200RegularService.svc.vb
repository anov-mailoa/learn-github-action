Imports R_BackEnd
Imports R_Common
Imports PYM00200Back
Imports System.ServiceModel

Public Class PYM00200RegularService
    Implements IPYM00200RegularService


    Public Sub Svc_R_Delete(poEntity As PYM00200Back.PYM00200GridDto) Implements R_BackEnd.R_IServicebase(Of PYM00200Back.PYM00200GridDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00200Back.PYM00200GridDto) As PYM00200Back.PYM00200GridDto Implements R_BackEnd.R_IServicebase(Of PYM00200Back.PYM00200GridDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PYM00200Back.PYM00200GridDto, poCRUDMode As R_Common.eCRUDMode) As PYM00200Back.PYM00200GridDto Implements R_BackEnd.R_IServicebase(Of PYM00200Back.PYM00200GridDto).Svc_R_Save

    End Function

    Public Sub Dummy(poParGrid As System.Collections.Generic.List(Of PYM00200Back.PYM00210GridDto)) Implements IPYM00200RegularService.Dummy

    End Sub

    Public Function checkPaymentConfiguration(poParam As PYM00200Back.PYM00200GridDto) As Boolean Implements IPYM00200RegularService.checkPaymentConfiguration
        Dim loEx As New R_Exception
        Dim loCls As New PYM00200Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkPaymentConfiguration(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

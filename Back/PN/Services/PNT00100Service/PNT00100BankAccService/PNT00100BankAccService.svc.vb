Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT00100BankAccService" in code, svc and config file together.
Public Class PNT00100BankAccService
    Implements IPNT00100BankAccService

    Public Sub DoWork() Implements IPNT00100BankAccService.DoWork
    End Sub

    Public Sub Svc_R_Delete(poEntity As PNT00100Back.PNT00100BankAccGridDTO) Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100BankAccGridDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100BankAccCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT00100Back.PNT00100BankAccGridDTO) As PNT00100Back.PNT00100BankAccGridDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100BankAccGridDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100BankAccCLS
        Dim loRtn As PNT00100BankAccGridDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT00100Back.PNT00100BankAccGridDTO, poCRUDMode As R_Common.eCRUDMode) As PNT00100Back.PNT00100BankAccGridDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100BankAccGridDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100BankAccCLS
        Dim loRtn As PNT00100BankAccGridDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

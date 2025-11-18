Imports R_BackEnd
Imports R_Common
Imports PNT03200Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "pnt03200BankAccService" in code, svc and config file together.
Public Class PNT03200BankAccService
    Implements IPNT03200BankAccService

    Public Sub DoWork() Implements IPNT03200BankAccService.DoWork
    End Sub

    Public Sub Svc_R_Delete(poEntity As PNT03200Back.PNT03200AccountDTO) Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200AccountDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200BankAccDataCls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT03200Back.PNT03200AccountDTO) As PNT03200Back.PNT03200AccountDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200AccountDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200BankAccDataCls
        Dim loRtn As PNT03200AccountDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT03200Back.PNT03200AccountDTO, poCRUDMode As R_Common.eCRUDMode) As PNT03200Back.PNT03200AccountDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200AccountDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200BankAccDataCls
        Dim loRtn As PNT03200AccountDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

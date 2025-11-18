Imports System.ServiceModel
Imports R_Common
Imports PYT00200Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00200DetailService" in code, svc and config file together.
Public Class PYT00200DetailService
    Implements IPYT00200DetailService

    Public Sub Svc_R_Delete(poEntity As PYT00200Back.PYT00200DetailDTO) Implements R_BackEnd.R_IServicebase(Of PYT00200Back.PYT00200DetailDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT00200Back.PYT00200DetailDTO) As PYT00200Back.PYT00200DetailDTO Implements R_BackEnd.R_IServicebase(Of PYT00200Back.PYT00200DetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls
        Dim loRtn As PYT00200DetailDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT00200Back.PYT00200DetailDTO, poCRUDMode As R_Common.eCRUDMode) As PYT00200Back.PYT00200DetailDTO Implements R_BackEnd.R_IServicebase(Of PYT00200Back.PYT00200DetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls
        Dim loRtn As PYT00200DetailDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub ProcessDetail(poEntity As System.Collections.Generic.List(Of PYT00200Back.PYT00200DetailDTO)) Implements IPYT00200DetailService.ProcessDetail
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls

        Try
            loCls.ProcessDetail(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub UnassignEmployee(poEntity As System.Collections.Generic.List(Of PYT00200Back.PYT00200DetailDTO)) Implements IPYT00200DetailService.UnassignEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls

        Try
            loCls.UnassignEmployee(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function isValidDownloadExcel(poParam As PYT00200Back.PYT00200DetailDTO) As Boolean Implements IPYT00200DetailService.isValidDownloadExcel
        Dim loCls As New PYT00200DetailCls
        Dim loException As New R_Exception
        Dim loRtn As Boolean

        Try
            loRtn = loCls.isValidDownloadExcel(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub ValidationAssign(poParam As PYT00200Back.PYT00200DetailDTO) Implements IPYT00200DetailService.ValidationAssign
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls

        Try
            loCls.ValidationAssign(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

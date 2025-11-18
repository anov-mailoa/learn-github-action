Imports R_Common
Imports PYM12000Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM12000Service" in code, svc and config file together.
Public Class PYM12000FooterService
    Implements IPYM12000FooterService

    Public Sub Svc_R_Delete1(poEntity As PYM12000Back.PYM12000FooterDTO) Implements R_BackEnd.R_IServicebase(Of PYM12000Back.PYM12000FooterDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM12000FooterCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord1(poEntity As PYM12000Back.PYM12000FooterDTO) As PYM12000Back.PYM12000FooterDTO Implements R_BackEnd.R_IServicebase(Of PYM12000Back.PYM12000FooterDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM12000FooterCls
        Dim loRtn As PYM12000FooterDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save1(poEntity As PYM12000Back.PYM12000FooterDTO, poCRUDMode As R_Common.eCRUDMode) As PYM12000Back.PYM12000FooterDTO Implements R_BackEnd.R_IServicebase(Of PYM12000Back.PYM12000FooterDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM12000FooterCls
        Dim loRtn As PYM12000FooterDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployeeName(poParam As PYM12000Back.PYM12000FooterDTO) As String Implements IPYM12000FooterService.getEmployeeName
        Dim loEx As New R_Exception
        Dim loCls As New PYM12000FooterCls
        Dim loRtn As String

        Try
            loRtn = loCls.getEmployeeName(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

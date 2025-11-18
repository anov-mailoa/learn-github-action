Imports R_Common
Imports PYM00600Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00600Service" in code, svc and config file together.
Public Class PYM00600Service
    Implements IPYM00600Service

    Public Sub Svc_R_Delete(poEntity As PYM00600Back.PYM00600GridDTO) Implements R_BackEnd.R_IServicebase(Of PYM00600Back.PYM00600GridDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00600Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00600Back.PYM00600GridDTO) As PYM00600Back.PYM00600GridDTO Implements R_BackEnd.R_IServicebase(Of PYM00600Back.PYM00600GridDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00600Cls
        Dim loRtn As PYM00600GridDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00600Back.PYM00600GridDTO, poCRUDMode As R_Common.eCRUDMode) As PYM00600Back.PYM00600GridDTO Implements R_BackEnd.R_IServicebase(Of PYM00600Back.PYM00600GridDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00600Cls
        Dim loRtn As PYM00600GridDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkCodeUsage(poParam As PYM00600Back.PYM00600GridDTO) As Integer Implements IPYM00600Service.checkCodeUsage

        Dim loEx As New R_Exception
        Dim loCls As New PYM00600Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.checkCodeUsage(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

End Class

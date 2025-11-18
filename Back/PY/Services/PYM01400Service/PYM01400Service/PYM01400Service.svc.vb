Imports R_Common
Imports PYM01400Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01400Service" in code, svc and config file together.
Public Class PYM01400Service
    Implements IPYM01400Service

    Public Sub Svc_R_Delete(poEntity As PYM01400Back.PYM01400Dto) Implements R_BackEnd.R_IServicebase(Of PYM01400Back.PYM01400Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM01400Back.PYM01400Dto) As PYM01400Back.PYM01400Dto Implements R_BackEnd.R_IServicebase(Of PYM01400Back.PYM01400Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM01400Cls
        Dim loRtn As PYM01400Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM01400Back.PYM01400Dto, poCRUDMode As R_Common.eCRUDMode) As PYM01400Back.PYM01400Dto Implements R_BackEnd.R_IServicebase(Of PYM01400Back.PYM01400Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM01400Cls
        Dim loRtn As PYM01400Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ActivateDeactivate(poParam As PYM01400Back.PYM01400Dto) As PYM01400Back.PYM01400Dto Implements IPYM01400Service.ActivateDeactivate
        Dim loEx As New R_Exception
        Dim loCls As New PYM01400Cls
        Dim loRtn As New PYM01400Dto

        Try
            loRtn = loCls.ActivateDeactivate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

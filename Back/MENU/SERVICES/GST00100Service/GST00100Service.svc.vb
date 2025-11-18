Imports R_Common
Imports GST00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "GST00100Service" in code, svc and config file together.
Public Class GST00100Service
    Implements IGST00100Service

    Public Sub Svc_R_Delete(poEntity As GST00100Back.GST00100DTO) Implements R_BackEnd.R_IServicebase(Of GST00100Back.GST00100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GST00100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GST00100Back.GST00100DTO) As GST00100Back.GST00100DTO Implements R_BackEnd.R_IServicebase(Of GST00100Back.GST00100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GST00100Cls
        Dim loRtn As GST00100DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GST00100Back.GST00100DTO, poCRUDMode As R_Common.eCRUDMode) As GST00100Back.GST00100DTO Implements R_BackEnd.R_IServicebase(Of GST00100Back.GST00100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GST00100Cls
        Dim loRtn As GST00100DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLblWelcome(poParam As GST00100Back.GST00100DTO) As String Implements IGST00100Service.getLblWelcome
        Dim loEx As New R_Exception
        Dim loCls As New GST00100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getLblWelcome(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransType(poParam As GST00100Back.GST00100DTO) As String Implements IGST00100Service.getTransType
        Dim loEx As New R_Exception
        Dim loCls As New GST00100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getTransType(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

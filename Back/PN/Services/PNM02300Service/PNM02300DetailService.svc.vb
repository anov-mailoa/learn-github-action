Imports R_Common
Imports PNM02300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02300DetailService" in code, svc and config file together.
Public Class PNM02300DetailService
    Implements IPNM02300DetailService

    Public Sub Svc_R_Delete(poEntity As PNM02300Back.PNM02300DetailDTO) Implements R_BackEnd.R_IServicebase(Of PNM02300Back.PNM02300DetailDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02300DetailCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02300Back.PNM02300DetailDTO) As PNM02300Back.PNM02300DetailDTO Implements R_BackEnd.R_IServicebase(Of PNM02300Back.PNM02300DetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM02300DetailCLS
        Dim loRtn As New PNM02300DetailDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM02300Back.PNM02300DetailDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02300Back.PNM02300DetailDTO Implements R_BackEnd.R_IServicebase(Of PNM02300Back.PNM02300DetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM02300DetailCLS
        Dim loRtn As New PNM02300DetailDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PNM02300Back.PNM02300DetailGridDTO)) Implements IPNM02300DetailService.Dummy

    End Sub

    Public Function Activate(poParam As PNM02300Back.PNM02300DetailDTO) As PNM02300Back.PNM02300DetailDTO Implements IPNM02300DetailService.Activate
        Dim loEx As New R_Exception
        Dim loCls As New PNM02300DetailCLS
        Dim loRtn As New PNM02300DetailDTO
        Try
            loRtn = loCls.Activate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function validasiActivate(poParam As PNM02300Back.PNM02300DetailDTO) As Boolean Implements IPNM02300DetailService.validasiActivate
        Dim loEx As New R_Exception
        Dim loCls As New PNM02300DetailCLS
        Dim loRtn As New Boolean
        Try
            loRtn = loCls.validasiActivate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

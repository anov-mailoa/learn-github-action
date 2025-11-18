Imports R_Common
Imports PYM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00100Service" in code, svc and config file together.
Public Class PYM00100Service
    Implements IPYM00100Service

    Public Sub Svc_R_Delete(poEntity As PYM00100Back.PYM00100DTO) Implements R_BackEnd.R_IServicebase(Of PYM00100Back.PYM00100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00100Back.PYM00100DTO) As PYM00100Back.PYM00100DTO Implements R_BackEnd.R_IServicebase(Of PYM00100Back.PYM00100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00100Cls
        Dim loRtn As PYM00100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00100Back.PYM00100DTO, poCRUDMode As R_Common.eCRUDMode) As PYM00100Back.PYM00100DTO Implements R_BackEnd.R_IServicebase(Of PYM00100Back.PYM00100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00100Cls
        Dim loRtn As PYM00100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRecord(poParam As PYM00100Back.PYM00100DTO) As PYM00100Back.PYM00100DTO Implements IPYM00100Service.getRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00100Cls
        Dim loRtn As New PYM00100DTO
        Try
            loRtn = loCls.getRecord(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetRateTypeCode(poParam As PYM00100Back.PYM00100DTO) As System.Collections.Generic.List(Of PYM00100Back.PYM00100CmbDTO) Implements IPYM00100Service.GetRateTypeCode
        Dim loEx As New R_Exception
        Dim loCls As New PYM00100Cls
        Dim loRtn As List(Of PYM00100CmbDTO)

        Try
            loRtn = loCls.GetRateTypeCode(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckFinalizeTax(poParam As PYM00100Back.PYM00100DTO) As Boolean Implements IPYM00100Service.CheckFinalizeTax
        Dim loEx As New R_Exception
        Dim loCls As New PYM00100Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.CheckFinalizeTax(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub DUMMY(poParam As PYM00100Back.PYM00100GridProportionalDTO) Implements IPYM00100Service.DUMMY

    End Sub
End Class

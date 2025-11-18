Imports R_Common
Imports PYM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00400PPH21Service" in code, svc and config file together.
Public Class PYM00400PPH21Service
    Implements IPYM00400PPH21Service

    Public Sub Svc_R_Delete(poEntity As PYM00400Back.PYM00400PPH21DTO) Implements R_BackEnd.R_IServicebase(Of PYM00400Back.PYM00400PPH21DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400PPH21CLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00400Back.PYM00400PPH21DTO) As PYM00400Back.PYM00400PPH21DTO Implements R_BackEnd.R_IServicebase(Of PYM00400Back.PYM00400PPH21DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400PPH21CLS
        Dim loRtn As New PYM00400PPH21DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00400Back.PYM00400PPH21DTO, poCRUDMode As R_Common.eCRUDMode) As PYM00400Back.PYM00400PPH21DTO Implements R_BackEnd.R_IServicebase(Of PYM00400Back.PYM00400PPH21DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400PPH21CLS
        Dim loRtn As New PYM00400PPH21DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PYM00400Back.PYM00400PPH21GridDTO)) Implements IPYM00400PPH21Service.Dummy

    End Sub

    Public Function cekCustomTax(poParam As PYM00400Back.PYM00400PPH21DTO) As Boolean Implements IPYM00400PPH21Service.cekCustomTax
        Dim loEx As New R_Exception
        Dim loCls As New PYM00400PPH21CLS
        Dim llRtn As Boolean
        Try
            llRtn = loCls.cekCustomTax(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return llRtn
    End Function

End Class

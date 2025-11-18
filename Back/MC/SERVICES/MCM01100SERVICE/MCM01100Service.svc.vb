Imports R_BackEnd
Imports R_Common
Imports MCM01100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM01100Service" in code, svc and config file together.
Public Class MCM01100Service
    Implements IMCM01100Service

    Public Sub Svc_R_Delete(ByVal poEntity As MCM01100Back.MCM01100Dto) Implements R_BackEnd.R_IServicebase(Of MCM01100Back.MCM01100Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM01100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As MCM01100Back.MCM01100Dto) As MCM01100Back.MCM01100Dto Implements R_BackEnd.R_IServicebase(Of MCM01100Back.MCM01100Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM01100Cls
        Dim loRtn As New MCM01100Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(ByVal poEntity As MCM01100Back.MCM01100Dto, ByVal poCRUDMode As R_Common.eCRUDMode) As MCM01100Back.MCM01100Dto Implements R_BackEnd.R_IServicebase(Of MCM01100Back.MCM01100Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM01100Cls
        Dim loRtn As New MCM01100Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetYear(ByRef pcCompanyId As String) As System.Collections.Generic.List(Of MCM01100Back.MCM01100GridYearDto) Implements IMCM01100Service.GetYear
        Dim loEx As New R_Exception
        Dim loCls As New MCM01100Cls
        Dim loRtn As New List(Of MCM01100GridYearDto)

        Try
            loRtn = loCls.GetYear(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub CopyPrevious(ByVal poParam As MCM01100Back.MCM01100Dto) Implements IMCM01100Service.CopyPrevious
        Dim loEx As New R_Exception
        Dim loCls As New MCM01100Cls

        Try
            loCls.CopyPrevious(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub CopyRule(ByVal poParam As MCM01100Back.MCM01100Dto) Implements IMCM01100Service.CopyRule
        Dim loEx As New R_Exception
        Dim loCls As New MCM01100Cls

        Try
            loCls.CopyRule(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub DeleteAll(ByVal poParam As MCM01100Back.MCM01100Dto) Implements IMCM01100Service.DeleteAll
        Dim loEx As New R_Exception
        Dim loCls As New MCM01100Cls

        Try
            loCls.DeleteAll(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function ChkDatRul(poParam As MCM01100Dto) As Boolean Implements IMCM01100Service.ChkDatRul
        Dim loException As New R_Exception
        Dim loCls As New MCM01100Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.ChkDatRul(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetDlogRecord(poParam As MCM01100Back.MCM01100Dto) As MCM01100Back.MCM01100Dto Implements IMCM01100Service.GetDlogRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM01100Cls
        Dim loRtn As New MCM01100Dto

        Try
            loRtn = loCls.GetDlogRecord(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

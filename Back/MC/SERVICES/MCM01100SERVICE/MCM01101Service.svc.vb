Imports R_BackEnd
Imports R_Common
Imports MCM01100Back
Imports MCM01100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM01101Service" in code, svc and config file together.
Public Class MCM01101Service
    Implements IMCM01101Service

    Public Sub Svc_R_Delete(poEntity As MCM01100Back.MCM01101Dto) Implements R_BackEnd.R_IServicebase(Of MCM01100Back.MCM01101Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM01101Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM01100Back.MCM01101Dto) As MCM01100Back.MCM01101Dto Implements R_BackEnd.R_IServicebase(Of MCM01100Back.MCM01101Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM01101Cls
        Dim loRtn As New MCM01101Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM01100Back.MCM01101Dto, poCRUDMode As R_Common.eCRUDMode) As MCM01100Back.MCM01101Dto Implements R_BackEnd.R_IServicebase(Of MCM01100Back.MCM01101Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM01101Cls
        Dim loRtn As New MCM01101Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function LimitPolicy(ByRef pcComId As String) As Integer Implements IMCM01101Service.LimitPolicy
        Dim loEx As New R_Exception
        Dim loCls As New MCM01101Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.LimitPolicy(pcComId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function ComboMedicalItem(ByRef pcComId As String) As System.Collections.Generic.List(Of MCM01100Back.MCM01101ComboDto) Implements IMCM01101Service.ComboMedicalItem
        Dim loEx As New R_Exception
        Dim loCls As New MCM01101Cls
        Dim loRtn As New List(Of MCM01101ComboDto)

        Try
            loRtn = loCls.ComboMedicalItem(pcComId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetDlogRecord(poParam As MCM01100Back.MCM01101Dto) As MCM01100Back.MCM01101Dto Implements IMCM01101Service.GetDlogRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM01101Cls
        Dim loRtn As New MCM01101Dto

        Try
            loRtn = loCls.GetDlogRecord(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

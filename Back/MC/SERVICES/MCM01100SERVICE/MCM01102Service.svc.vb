Imports R_BackEnd
Imports R_Common
Imports MCM01100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM01102Service" in code, svc and config file together.
Public Class MCM01102Service
    Implements IMCM01102Service

    Public Sub Svc_R_Delete(poEntity As MCM01100Back.MCM01102Dto) Implements R_BackEnd.R_IServicebase(Of MCM01100Back.MCM01102Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM01102Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM01100Back.MCM01102Dto) As MCM01100Back.MCM01102Dto Implements R_BackEnd.R_IServicebase(Of MCM01100Back.MCM01102Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM01102Cls
        Dim loRtn As New MCM01102Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM01100Back.MCM01102Dto, poCRUDMode As R_Common.eCRUDMode) As MCM01100Back.MCM01102Dto Implements R_BackEnd.R_IServicebase(Of MCM01100Back.MCM01102Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM01102Cls
        Dim loRtn As New MCM01102Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function ContractEmployee(poParam As MCM01100Back.MCM01102Dto) As Boolean Implements IMCM01102Service.ContractEmployee
        Dim loException As New R_Exception
        Dim loCls As New MCM01102Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.ContractEmployee(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetDlogRecord(poParam As MCM01100Back.MCM01102Dto) As MCM01100Back.MCM01102Dto Implements IMCM01102Service.GetDlogRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM01102Cls
        Dim loRtn As New MCM01102Dto

        Try
            loRtn = loCls.GetDlogRecord(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

Imports R_BackEnd
Imports R_Common
Imports MCT02100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM02100Service" in code, svc and config file together.
Public Class MCT02100Service
    Implements IMCT02100Service

    Public Sub Svc_R_Delete(poEntity As MCT02100Back.MCT02100Dto) Implements R_BackEnd.R_IServicebase(Of MCT02100Back.MCT02100Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT02100Back.MCT02100Dto) As MCT02100Back.MCT02100Dto Implements R_BackEnd.R_IServicebase(Of MCT02100Back.MCT02100Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100Cls
        Dim loRtn As New MCT02100Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCT02100Back.MCT02100Dto, poCRUDMode As R_Common.eCRUDMode) As MCT02100Back.MCT02100Dto Implements R_BackEnd.R_IServicebase(Of MCT02100Back.MCT02100Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100Cls
        Dim loRtn As New MCT02100Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetYear(ByRef pcCompanyId As String) As String Implements IMCT02100Service.GetYear
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.GetYear(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function ReDraft(ByRef poParam As MCT02100Back.MCT02100Dto) As MCT02100Back.MCT02100Dto Implements IMCT02100Service.ReDraft
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100Cls
        Dim loRtn As New MCT02100Dto

        Try
            loRtn = loCls.ReDraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(ByRef poParam As MCT02100Back.MCT02100Dto) As MCT02100Back.MCT02100Dto Implements IMCT02100Service.Submit
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100Cls
        Dim loRtn As New MCT02100Dto

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

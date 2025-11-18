Imports R_BackEnd
Imports R_Common
Imports JCM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "JCM00100Service" in code, svc and config file together.
Public Class JCM00100Service
    Implements IJCM00100Service

    Public Sub Svc_R_Delete(poEntity As JCM00100Back.JCM00100DTO) Implements R_BackEnd.R_IServicebase(Of JCM00100Back.JCM00100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As JCM00100Back.JCM00100DTO) As JCM00100Back.JCM00100DTO Implements R_BackEnd.R_IServicebase(Of JCM00100Back.JCM00100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New JCM00100Cls
        Dim loRtn As JCM00100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As JCM00100Back.JCM00100DTO, poCRUDMode As R_Common.eCRUDMode) As JCM00100Back.JCM00100DTO Implements R_BackEnd.R_IServicebase(Of JCM00100Back.JCM00100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New JCM00100Cls
        Dim loRtn As JCM00100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMainData(pcCompId As String) As Integer Implements IJCM00100Service.getMainData
        Dim loEx As New R_Exception
        Dim loCls As New JCM00100Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getMainData(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRecord(poEntity As JCM00100Back.JCM00100DTO) As JCM00100Back.JCM00100DTO Implements IJCM00100Service.getRecord
        Dim loEx As New R_Exception
        Dim loCls As New JCM00100Cls
        Dim loRtn As JCM00100DTO

        Try
            loRtn = loCls.getRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

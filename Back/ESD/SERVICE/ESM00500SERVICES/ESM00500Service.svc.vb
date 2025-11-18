Imports R_Common
Imports ESM00500Back
Imports ESM00500Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00500Service" in code, svc and config file together.
Public Class ESM00500Service
    Implements IESM00500Service

    Public Sub Svc_R_Delete(poEntity As ESM00500Back.ESM00500ParameterDTO) Implements R_BackEnd.R_IServicebase(Of ESM00500Back.ESM00500ParameterDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM00500Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00500Back.ESM00500ParameterDTO) As ESM00500Back.ESM00500ParameterDTO Implements R_BackEnd.R_IServicebase(Of ESM00500Back.ESM00500ParameterDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00500Cls
        Dim loRtn As New ESM00500ParameterDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00500Back.ESM00500ParameterDTO, poCRUDMode As R_Common.eCRUDMode) As ESM00500Back.ESM00500ParameterDTO Implements R_BackEnd.R_IServicebase(Of ESM00500Back.ESM00500ParameterDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM00500Cls
        Dim loRtn As New ESM00500ParameterDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub setActive(poParam As ESM00500Back.ESM00500ParameterDTO) Implements IESM00500Service.setActive
        Dim loException As New R_Exception
        Dim loCls As New ESM00500Cls
        Try
            loCls.setActive(poParam)

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub
End Class

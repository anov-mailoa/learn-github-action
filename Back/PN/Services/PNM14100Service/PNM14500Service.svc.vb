Imports R_Common
Imports R_BackEnd
Imports PNM14100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM14500Service" in code, svc and config file together.
Public Class PNM14500Service
    Implements IPNM14500Service

    Public Sub Svc_R_Delete(poEntity As PNM14100Back.PNM14500ParameterDTO) Implements R_BackEnd.R_IServicebase(Of PNM14100Back.PNM14500ParameterDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM14100Back.PNM14500ParameterDTO) As PNM14100Back.PNM14500ParameterDTO Implements R_BackEnd.R_IServicebase(Of PNM14100Back.PNM14500ParameterDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PNM14500Cls
        Dim loRtn As New PNM14500ParameterDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM14100Back.PNM14500ParameterDTO, poCRUDMode As R_Common.eCRUDMode) As PNM14100Back.PNM14500ParameterDTO Implements R_BackEnd.R_IServicebase(Of PNM14100Back.PNM14500ParameterDTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New PNM14500Cls
        Dim loRtn As New PNM14500ParameterDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub DoWork() Implements IPNM14500Service.DoWork

    End Sub

    Public Function getCheckSyntax(poParam As PNM14100Back.PNM14500ParameterDTO) As Boolean Implements IPNM14500Service.getCheckSyntax
        Dim loRtn As Boolean
        Dim loCls As New PNM14500Cls
        Dim loEx As New R_Exception

        Try

            loRtn = loCls.getCheckSyntax(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

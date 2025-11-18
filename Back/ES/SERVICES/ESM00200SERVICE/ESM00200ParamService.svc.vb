Imports System.ServiceModel
Imports R_Common
Imports ESM00200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00200Service" in code, svc and config file together.
Public Class ESM00200ParamService
    Implements IESM00200ParamService

    Public Sub Svc_R_Delete(poEntity As ESM00200Back.ESM00200ParamDTO) Implements R_BackEnd.R_IServicebase(Of ESM00200Back.ESM00200ParamDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00200Back.ESM00200ParamDTO) As ESM00200Back.ESM00200ParamDTO Implements R_BackEnd.R_IServicebase(Of ESM00200Back.ESM00200ParamDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00200ParamCLS
        Dim loRtn As ESM00200ParamDTO

        Try

            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00200Back.ESM00200ParamDTO, poCRUDMode As R_Common.eCRUDMode) As ESM00200Back.ESM00200ParamDTO Implements R_BackEnd.R_IServicebase(Of ESM00200Back.ESM00200ParamDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM00200ParamCLS
        Dim loRtn As ESM00200ParamDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub saveESSReason(poParam As ESM00200Back.ESM00200ParamDTO) Implements IESM00200ParamService.saveESSReason
        Dim loEx As New R_Exception
        Dim loCls As New ESM00200ParamCLS

        Try
            loCls.saveESSReason(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function UpdateReserveGeocoding(poParam As ESM00200Back.ESM00200ParamDTO) As ESM00200Back.ESM00200ParamDTO Implements IESM00200ParamService.UpdateReserveGeocoding
        Dim loEx As New R_Exception
        Dim loCls As New ESM00200ParamCLS
        Dim loRtn As New ESM00200ParamDTO

        Try

            loRtn = loCls.UpdateReserveGeocoding(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

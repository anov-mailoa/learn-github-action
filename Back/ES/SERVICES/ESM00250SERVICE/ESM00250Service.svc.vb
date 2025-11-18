Imports R_Common
Imports ESM00250Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00250Service" in code, svc and config file together.
Public Class ESM00250Service
    Implements IESM00250Service

    Public Sub Svc_R_Delete(poEntity As ESM00250Back.ESM00250DTO) Implements R_BackEnd.R_IServicebase(Of ESM00250Back.ESM00250DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM00250Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00250Back.ESM00250DTO) As ESM00250Back.ESM00250DTO Implements R_BackEnd.R_IServicebase(Of ESM00250Back.ESM00250DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00250Cls
        Dim loRtn As ESM00250DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00250Back.ESM00250DTO, poCRUDMode As R_Common.eCRUDMode) As ESM00250Back.ESM00250DTO Implements R_BackEnd.R_IServicebase(Of ESM00250Back.ESM00250DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM00250Cls
        Dim loRtn As ESM00250DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Sub saveGeneralAccess(poNewEntity As System.Collections.Generic.Dictionary(Of String, String)) Implements IESM00250Service.saveGeneralAccess
    '    Dim loEx As New R_Exception
    '    Dim loCls As New ESM00250Cls

    '    Try
    '        loCls.saveGeneralAccess(poNewEntity)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub

End Class

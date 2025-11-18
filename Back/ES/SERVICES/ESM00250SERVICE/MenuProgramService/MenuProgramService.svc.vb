Imports R_Common
Imports ESM00250Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "MenuProgramService" in code, svc and config file together.
Public Class MenuProgramService
    Implements IMenuProgramService

    Public Sub Svc_R_Delete(poEntity As ESM00250Back.ESM00250MenuProgramDTO) Implements R_BackEnd.R_IServicebase(Of ESM00250Back.ESM00250MenuProgramDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM00250MenuProgramCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00250Back.ESM00250MenuProgramDTO) As ESM00250Back.ESM00250MenuProgramDTO Implements R_BackEnd.R_IServicebase(Of ESM00250Back.ESM00250MenuProgramDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00250MenuProgramCls
        Dim loRtn As ESM00250MenuProgramDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00250Back.ESM00250MenuProgramDTO, poCRUDMode As R_Common.eCRUDMode) As ESM00250Back.ESM00250MenuProgramDTO Implements R_BackEnd.R_IServicebase(Of ESM00250Back.ESM00250MenuProgramDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM00250MenuProgramCls
        Dim loRtn As ESM00250MenuProgramDTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Sub saveButtonAccess(poParam As ESM00250Back.ESM00250MenuProgramDTO) Implements IMenuProgramService.saveButtonAccess
    '    Dim loEx As New R_Exception
    '    Dim loCls As New ESM00250MenuProgramCls

    '    Try
    '        loCls.saveButtonAccess(poParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub

    'Public Sub saveGeneralAccess(poparam As ESM00250Back.ESM00250MenuProgramDTO) Implements IMenuProgramService.saveGeneralAccess
    '    Dim loEx As New R_Exception
    '    Dim loCls As New ESM00250MenuProgramCls

    '    Try
    '        loCls.saveGeneralAccess(poparam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub
End Class

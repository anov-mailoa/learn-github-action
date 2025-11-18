Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00900Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00901Service" in code, svc and config file together.
Public Class ATT00901Service
    Implements IATT00901Service

    Public Sub Svc_R_Delete(poEntity As ATT00900Back.ATT00901DTO) Implements R_BackEnd.R_IServicebase(Of ATT00900Back.ATT00901DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT00901Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00900Back.ATT00901DTO) As ATT00900Back.ATT00901DTO Implements R_BackEnd.R_IServicebase(Of ATT00900Back.ATT00901DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT00901Cls
        Dim loRtn As ATT00901DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT00900Back.ATT00901DTO, poCRUDMode As R_Common.eCRUDMode) As ATT00900Back.ATT00901DTO Implements R_BackEnd.R_IServicebase(Of ATT00900Back.ATT00901DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT00901Cls
        Dim loRtn As ATT00901DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

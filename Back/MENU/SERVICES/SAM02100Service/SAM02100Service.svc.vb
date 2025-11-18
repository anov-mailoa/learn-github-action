Imports R_Common
Imports SAM02100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02100Service" in code, svc and config file together.
Public Class SAM02100Service
    Implements ISAM02100Service

    Public Sub Svc_R_Delete(poEntity As SAM02100Back.SAM02100DTO) Implements R_BackEnd.R_IServicebase(Of SAM02100Back.SAM02100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM02100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM02100Back.SAM02100DTO) As SAM02100Back.SAM02100DTO Implements R_BackEnd.R_IServicebase(Of SAM02100Back.SAM02100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New SAM02100Cls
        Dim loRtn As SAM02100DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As SAM02100Back.SAM02100DTO, poCRUDMode As R_Common.eCRUDMode) As SAM02100Back.SAM02100DTO Implements R_BackEnd.R_IServicebase(Of SAM02100Back.SAM02100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New SAM02100Cls
        Dim loRtn As SAM02100DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub saveData(poData As R_Common.R_EmailEngineCommandPar, poParam As SAM02100Back.SAM02100DTO) Implements ISAM02100Service.saveData
        Dim loEx As New R_Exception
        Dim loCls As New SAM02100Cls

        Try
            loCls.saveData(poData, poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

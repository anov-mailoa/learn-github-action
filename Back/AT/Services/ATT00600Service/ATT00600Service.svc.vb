' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00600Service" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports ATT00600Back
Imports ATT00600Common
Imports R_BackEnd

Public Class ATT00600Service
    Implements IATT00600Service
     
    Public Sub Svc_R_Delete(poEntity As ATT00600Back.ATT00600DTO) Implements R_BackEnd.R_IServicebase(Of ATT00600Back.ATT00600DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT00600CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00600Back.ATT00600DTO) As ATT00600Back.ATT00600DTO Implements R_BackEnd.R_IServicebase(Of ATT00600Back.ATT00600DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT00600CLS
        Dim loRtn As ATT00600DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT00600Back.ATT00600DTO, poCRUDMode As R_Common.eCRUDMode) As ATT00600Back.ATT00600DTO Implements R_BackEnd.R_IServicebase(Of ATT00600Back.ATT00600DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT00600CLS
        Dim loRtn As ATT00600DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Draft(poParam As ATT00600Back.ATT00600DTO) As ATT00600Back.ATT00600DTO Implements IATT00600Service.Draft

        Dim loEx As New R_Exception
        Dim loCls As New ATT00600CLS
        Dim loRtn As ATT00600DTO = Nothing

        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function Submit(poParam As ATT00600Back.ATT00600DTO) As ATT00600Back.ATT00600DTO Implements IATT00600Service.Submit

        Dim loEx As New R_Exception
        Dim loCls As New ATT00600CLS
        Dim loRtn As ATT00600DTO = Nothing

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

End Class

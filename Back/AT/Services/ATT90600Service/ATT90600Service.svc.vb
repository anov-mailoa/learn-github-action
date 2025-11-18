' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90600Service" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports ATT90600Back
Imports ATT90600Common
Imports R_BackEnd

Public Class ATT90600Service
    Implements IATT90600Service
     
    Public Sub Svc_R_Delete(poEntity As ATT90600Back.ATT90600DTO) Implements R_BackEnd.R_IServicebase(Of ATT90600Back.ATT90600DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT90600Back.ATT90600DTO) As ATT90600Back.ATT90600DTO Implements R_BackEnd.R_IServicebase(Of ATT90600Back.ATT90600DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATT90600Back.ATT90600DTO, poCRUDMode As R_Common.eCRUDMode) As ATT90600Back.ATT90600DTO Implements R_BackEnd.R_IServicebase(Of ATT90600Back.ATT90600DTO).Svc_R_Save

    End Function

    Public Function Draft(poParam As ATT90600Back.ATT90600DTO) As ATT90600Back.ATT90600DTO Implements IATT90600Service.Draft

        Dim loEx As New R_Exception
        Dim loCls As New ATT90600CLS
        Dim loRtn As ATT90600DTO = Nothing

        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getListCompensatoryDetail(poParam As ATT90600Back.ATT90600DTO) As ATT90600Back.ATT90600DTO Implements IATT90600Service.getListCompensatoryDetail

        Dim loEx As New R_Exception
        Dim loCls As New ATT90600CLS
        Dim loRtn As ATT90600DTO = Nothing

        Try
            loRtn = loCls.getListCompensatoryDetail(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getListCompensatoryDetailHistory(poParam As ATT90600Back.ATT90600DTO) As ATT90600Back.ATT90600DTO Implements IATT90600Service.getListCompensatoryDetailHistory


        Dim loEx As New R_Exception
        Dim loCls As New ATT90600CLS
        Dim loRtn As ATT90600DTO = Nothing

        Try
            loRtn = loCls.getListCompensatoryDetailHistory(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function Submit(poParam As ATT90600Back.ATT90600DTO) As ATT90600Back.ATT90600DTO Implements IATT90600Service.Submit

        Dim loEx As New R_Exception
        Dim loCls As New ATT90600CLS
        Dim loRtn As ATT90600DTO = Nothing

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub deleteHeader(poParam As ATT90600Back.ATT90600DTO) Implements IATT90600Service.deleteHeader

        Dim loEx As New R_Exception
        Dim loCls As New ATT90600CLS
        Dim loRtn As ATT90600DTO = Nothing

        Try
            loCls.deleteHeader(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function getSystemParam(poParam As ATT90600Back.ATT90600DTO) As ATT90600Back.ATT90600DTO Implements IATT90600Service.getSystemParam

        Dim loEx As New R_Exception
        Dim loCls As New ATT90600CLS
        Dim loRtn As ATT90600DTO = Nothing

        Try
            loRtn = loCls.getSystemParam(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class

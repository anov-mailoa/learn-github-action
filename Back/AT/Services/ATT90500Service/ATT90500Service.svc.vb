' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90500Service" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports ATT90500Back
Imports ATT90500Common
Imports R_BackEnd

Public Class ATT90500Service
    Implements IATT90500Service
     
    Public Sub Svc_R_Delete(poEntity As ATT90500Back.ATT90500DTO) Implements R_BackEnd.R_IServicebase(Of ATT90500Back.ATT90500DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT90500Back.ATT90500DTO) As ATT90500Back.ATT90500DTO Implements R_BackEnd.R_IServicebase(Of ATT90500Back.ATT90500DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATT90500Back.ATT90500DTO, poCRUDMode As R_Common.eCRUDMode) As ATT90500Back.ATT90500DTO Implements R_BackEnd.R_IServicebase(Of ATT90500Back.ATT90500DTO).Svc_R_Save

    End Function

    Public Function Draft(poParam As ATT90500Back.ATT90500DTO) As ATT90500Back.ATT90500DTO Implements IATT90500Service.Draft

        Dim loEx As New R_Exception
        Dim loCls As New ATT90500CLS
        Dim loRtn As ATT90500DTO = Nothing

        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getListLeaveDetail(poParam As ATT90500Back.ATT90500DTO) As ATT90500Back.ATT90500DTO Implements IATT90500Service.getListLeaveDetail

        Dim loEx As New R_Exception
        Dim loCls As New ATT90500CLS
        Dim loRtn As ATT90500DTO = Nothing

        Try
            loRtn = loCls.getListLeaveDetail(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getListLeaveDetailHistory(poParam As ATT90500Back.ATT90500DTO) As ATT90500Back.ATT90500DTO Implements IATT90500Service.getListLeaveDetailHistory


        Dim loEx As New R_Exception
        Dim loCls As New ATT90500CLS
        Dim loRtn As ATT90500DTO = Nothing

        Try
            loRtn = loCls.getListLeaveDetailHistory(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function Submit(poParam As ATT90500Back.ATT90500DTO) As ATT90500Back.ATT90500DTO Implements IATT90500Service.Submit

        Dim loEx As New R_Exception
        Dim loCls As New ATT90500CLS
        Dim loRtn As ATT90500DTO = Nothing

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub deleteHeader(poParam As ATT90500Back.ATT90500DTO) Implements IATT90500Service.deleteHeader

        Dim loEx As New R_Exception
        Dim loCls As New ATT90500CLS
        Dim loRtn As ATT90500DTO = Nothing

        Try
            loCls.deleteHeader(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
         
    End Sub
End Class

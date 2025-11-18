' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT91000Service" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports ATT91000Back
Imports ATT91000Common
Imports R_BackEnd

Public Class ATT91000Service
    Implements IATT91000Service
    Public Sub Svc_R_Delete(poEntity As ATT91000Back.ATT91000DTO) Implements R_BackEnd.R_IServicebase(Of ATT91000Back.ATT91000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT91000CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT91000Back.ATT91000DTO) As ATT91000Back.ATT91000DTO Implements R_BackEnd.R_IServicebase(Of ATT91000Back.ATT91000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT91000CLS
        Dim loRtn As ATT91000DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT91000Back.ATT91000DTO, poCRUDMode As R_Common.eCRUDMode) As ATT91000Back.ATT91000DTO Implements R_BackEnd.R_IServicebase(Of ATT91000Back.ATT91000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT91000CLS
        Dim loRtn As ATT91000DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Draft(poParam As ATT91000Back.ATT91000DTO) As ATT91000Back.ATT91000DTO Implements IATT91000Service.Draft

        Dim loEx As New R_Exception
        Dim loCls As New ATT91000CLS
        Dim loRtn As ATT91000DTO = Nothing

        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function Submit(poParam As ATT91000Back.ATT91000DTO) As ATT91000Back.ATT91000DTO Implements IATT91000Service.Submit

        Dim loEx As New R_Exception
        Dim loCls As New ATT91000CLS
        Dim loRtn As ATT91000DTO = Nothing

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function GetSystemParam(poParam As String) As String Implements IATT91000Service.GetSystemParam
        Dim loEx As New R_Exception
        Dim loCls As New ATT91010CLS
        Dim loRtn As String = ""

        Try
            loRtn = loCls.getSystemParam(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

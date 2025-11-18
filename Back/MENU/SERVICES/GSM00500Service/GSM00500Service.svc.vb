Imports System.ServiceModel
Imports R_Common
Imports GSM00500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM00500Service" in code, svc and config file together.
Public Class GSM00500Service
    Implements IGSM00500Service


    Public Sub Svc_R_Delete(poEntity As GSM00500Back.GSM00500DTO) Implements R_BackEnd.R_IServicebase(Of GSM00500Back.GSM00500DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM00500Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM00500Back.GSM00500DTO) As GSM00500Back.GSM00500DTO Implements R_BackEnd.R_IServicebase(Of GSM00500Back.GSM00500DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM00500Cls
        Dim loRtn As GSM00500DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM00500Back.GSM00500DTO, poCRUDMode As R_Common.eCRUDMode) As GSM00500Back.GSM00500DTO Implements R_BackEnd.R_IServicebase(Of GSM00500Back.GSM00500DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM00500Cls
        Dim loRtn As GSM00500DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckLevelChild(poParam As GSM00500Back.GSM00500DTO) As Integer Implements IGSM00500Service.CheckLevelChild
        Dim loEx As New R_Exception
        Dim loCls As New GSM00500Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.CheckLevelChild(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ActivateProcess(poParam As GSM00500Back.GSM00500DTO) As GSM00500Back.GSM00500DTO Implements IGSM00500Service.ActivateProcess
        Dim loEx As New R_Exception
        Dim loCls As New GSM00500Cls
        Dim loRtn As New GSM00500DTO

        Try
            loRtn = loCls.ActivateProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function CheckLoad(pcCompId As String) As Boolean Implements IGSM00500Service.CheckLoad
        Dim loEx As New R_Exception
        Dim loCls As New GSM00500Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.CheckLoad(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function RSP_GSM_DEPARTMENT_MOVE_DEPARTMENT(poParam As GSM00500Back.GSM00500DTO) As GSM00500Back.GSM00500DTO Implements IGSM00500Service.RSP_GSM_DEPARTMENT_MOVE_DEPARTMENT
        Dim loEx As New R_Exception
        Dim loCls As New GSM00500Cls
        Dim loRtn As New GSM00500DTO

        Try
            loRtn = loCls.RSP_GSM_DEPARTMENT_MOVE_DEPARTMENT(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub InitializeDepartment(pcCompId As String, pcUserId As String) Implements IGSM00500Service.InitializeDepartment
        Dim loEx As New R_Exception
        Dim loCls As New GSM00500Cls

        Try
            loCls.InitializeDepartment(pcCompId, pcUserId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

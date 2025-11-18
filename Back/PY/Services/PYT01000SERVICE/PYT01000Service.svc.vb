Imports System.ServiceModel
Imports R_Common
Imports PYT01000Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT01000Service" in code, svc and config file together.
Public Class PYT01000Service
    Implements IPYT01000Service

    Public Sub Svc_R_Delete(poEntity As PYT01000Back.PYT01000DTO) Implements R_BackEnd.R_IServicebase(Of PYT01000Back.PYT01000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT01000Back.PYT01000DTO) As PYT01000Back.PYT01000DTO Implements R_BackEnd.R_IServicebase(Of PYT01000Back.PYT01000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls
        Dim loRtn As PYT01000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT01000Back.PYT01000DTO, poCRUDMode As R_Common.eCRUDMode) As PYT01000Back.PYT01000DTO Implements R_BackEnd.R_IServicebase(Of PYT01000Back.PYT01000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls
        Dim loRtn As PYT01000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub AssignEmployee(poParam As PYT01000Back.PYT01000DTO) Implements IPYT01000Service.AssignEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls

        Try
            loCls.AssignEmployee(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub RemoveEmployee(poParam As PYT01000Back.PYT01000DTO) Implements IPYT01000Service.RemoveEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls

        Try
            loCls.RemoveEmployee(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub recalcDtpProcess(poParam As PYT01000Back.PYT01000DTO) Implements IPYT01000Service.recalcDtpProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls

        Try
            loCls.recalcDtpProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub UpdateDTPProcess(poParam As PYT01000Back.PYT01000DTO) Implements IPYT01000Service.UpdateDTPProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls

        Try
            loCls.UpdateDTPProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

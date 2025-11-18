' NOTE: You can use the "Rename" command on the context menu to change the class name "ATB00100Service" in code, svc and config file together.
Imports R_Common
Imports R_BackEnd
Imports SIAPP_DAL
Imports ServerHelper
Imports ATB00100Back
Imports SIAPP_PUB_DTO
Imports ATB00100Common

Public Class ATB00100Service
    Implements IATB00100Service

    Public Sub Svc_R_Delete(poEntity As ATB00100Back.ATB00100DTO) Implements R_BackEnd.R_IServicebase(Of ATB00100Back.ATB00100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATB00100Back.ATB00100DTO) As ATB00100Back.ATB00100DTO Implements R_BackEnd.R_IServicebase(Of ATB00100Back.ATB00100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATB00100Back.ATB00100DTO, poCRUDMode As R_Common.eCRUDMode) As ATB00100Back.ATB00100DTO Implements R_BackEnd.R_IServicebase(Of ATB00100Back.ATB00100DTO).Svc_R_Save

    End Function

    Public Sub Validation(poParam As ATB00100Back.ATB00100DTO) Implements IATB00100Service.Validation

        Dim loEx As New R_Exception
        Dim loCls As New ATB00100CLS
        Dim loRtn As ATB00100DTO

        Try
            loCls.Validation(poParam)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function GetProcessFromDate(poParam As ATB00100Back.ATB00100DTO) As String Implements IATB00100Service.GetProcessFromDate
        Dim loEx As New R_Exception
        Dim loCls As New ATB00100CLS
        Dim lcRtn As String

        Try
            lcRtn = loCls.GetProcessFromDate(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function

    Public Function ValidateMachineType(pcCompId As String, pcMachineType As String) As ATB00100Back.ATB00100DTO Implements IATB00100Service.ValidateMachineType
        Dim loCls As New ATB00100CLS
        Dim loEx As New R_Exception
        Dim loRtn As New ATB00100DTO

        Try
            loRtn = loCls.ValidateMachineType(pcCompId, pcMachineType)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getMachineTable(pcCompId As String) As System.Collections.Generic.List(Of ATB00100Common.ATM_MACHINE_TABLEDTO) Implements IATB00100Service.getMachineTable
        Dim loEx As New R_Exception
        Dim loCls As New ATB00100CLS
        Dim loRtn As New List(Of ATM_MACHINE_TABLEDTO)

        Try
            loRtn = loCls.getMachineTable(pcCompId)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

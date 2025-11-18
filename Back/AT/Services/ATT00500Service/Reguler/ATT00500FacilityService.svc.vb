Imports System.ServiceModel
Imports R_Common
Imports ATT00500Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00500facilityService" in code, svc and config file together.
Public Class ATT00500FacilityService
    Implements IATT00500FacilityService


    Public Sub DoWork() Implements IATT00500FacilityService.DoWork
    End Sub

    Public Sub Svc_R_Delete(poEntity As ATT00500Back.ATT00500FacilityDTO) Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500FacilityDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500FacilityCLS
        Dim loRtn As ATT00500FacilityDTO
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00500Back.ATT00500FacilityDTO) As ATT00500Back.ATT00500FacilityDTO Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500FacilityDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500FacilityCLS
        Dim loRtn As ATT00500FacilityDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT00500Back.ATT00500FacilityDTO, poCRUDMode As R_Common.eCRUDMode) As ATT00500Back.ATT00500FacilityDTO Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500FacilityDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500FacilityCLS
        Dim loRtn As ATT00500FacilityDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

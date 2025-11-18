Imports System.ServiceModel
Imports R_Common
Imports ATM00600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00610SPService" in code, svc and config file together.
Public Class ATM00610ShiftPatternService
    Implements IATM00610ShiftPatternService

    Public Sub Svc_R_Delete(poEntity As ATM00600Back.ATM00610ShiftPatternDTO) Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00610ShiftPatternDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATM00610ShiftPatternCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00600Back.ATM00610ShiftPatternDTO) As ATM00600Back.ATM00610ShiftPatternDTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00610ShiftPatternDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00610ShiftPatternCLS
        Dim loRtn As ATM00610ShiftPatternDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00600Back.ATM00610ShiftPatternDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00600Back.ATM00610ShiftPatternDTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00610ShiftPatternDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00610ShiftPatternCLS
        Dim loRtn As ATM00610ShiftPatternDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkINO_USED_MNT(poParam As ATM00600Back.ATM00610ShiftPatternDTO) As Integer Implements IATM00610ShiftPatternService.checkINO_USED_MNT
        Dim loEx As New R_Exception
        Dim loCls As New ATM00610ShiftPatternCLS
        Dim liRtn As Int64
        Try
            liRtn = loCls.checkINO_USED_MNT(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return liRtn
    End Function
End Class

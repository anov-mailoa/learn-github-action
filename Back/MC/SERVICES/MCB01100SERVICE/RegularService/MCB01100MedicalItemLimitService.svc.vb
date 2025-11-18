Imports R_BackEnd
Imports R_Common
Imports MCB01100Back
Imports System.ServiceModel

Public Class MCB01100MedicalItemLimitService
    Implements IMCB01100MedicalItemLimitService

    Public Sub Svc_R_Delete(poEntity As MCB01100Back.MCB01100MedicalItemLimitDto) Implements R_BackEnd.R_IServicebase(Of MCB01100Back.MCB01100MedicalItemLimitDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCB01100Back.MCB01100MedicalItemLimitDto) As MCB01100Back.MCB01100MedicalItemLimitDto Implements R_BackEnd.R_IServicebase(Of MCB01100Back.MCB01100MedicalItemLimitDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As MCB01100Back.MCB01100MedicalItemLimitDto, poCRUDMode As R_Common.eCRUDMode) As MCB01100Back.MCB01100MedicalItemLimitDto Implements R_BackEnd.R_IServicebase(Of MCB01100Back.MCB01100MedicalItemLimitDto).Svc_R_Save

    End Function
End Class

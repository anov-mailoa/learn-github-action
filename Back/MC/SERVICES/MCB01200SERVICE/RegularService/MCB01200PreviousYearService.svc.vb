Imports R_BackEnd
Imports R_Common
Imports MCB01200Back
Imports System.ServiceModel

Public Class MCB01200PreviousYearService
    Implements IMCB01200PreviousYearService

    Public Sub Svc_R_Delete(poEntity As MCB01200Back.MCB01200PreviousYearDto) Implements R_BackEnd.R_IServicebase(Of MCB01200Back.MCB01200PreviousYearDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCB01200Back.MCB01200PreviousYearDto) As MCB01200Back.MCB01200PreviousYearDto Implements R_BackEnd.R_IServicebase(Of MCB01200Back.MCB01200PreviousYearDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As MCB01200Back.MCB01200PreviousYearDto, poCRUDMode As R_Common.eCRUDMode) As MCB01200Back.MCB01200PreviousYearDto Implements R_BackEnd.R_IServicebase(Of MCB01200Back.MCB01200PreviousYearDto).Svc_R_Save

    End Function

End Class

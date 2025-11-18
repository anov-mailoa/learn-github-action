' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00800Service" in code, svc and config file together.
Public Class ATT00800Service
    Implements IATT00800Service


    Public Sub Svc_R_Delete(poEntity As ATT00800Back.ATT00800DTO) Implements R_BackEnd.R_IServicebase(Of ATT00800Back.ATT00800DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00800Back.ATT00800DTO) As ATT00800Back.ATT00800DTO Implements R_BackEnd.R_IServicebase(Of ATT00800Back.ATT00800DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATT00800Back.ATT00800DTO, poCRUDMode As R_Common.eCRUDMode) As ATT00800Back.ATT00800DTO Implements R_BackEnd.R_IServicebase(Of ATT00800Back.ATT00800DTO).Svc_R_Save

    End Function
End Class

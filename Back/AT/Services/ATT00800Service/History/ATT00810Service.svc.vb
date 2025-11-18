' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00810Service" in code, svc and config file together.
Public Class ATT00810Service
    Implements IATT00810Service

    Public Sub Svc_R_Delete(ByVal poEntity As ATT00800Back.ATT00810DTO) Implements R_BackEnd.R_IServicebase(Of ATT00800Back.ATT00810DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As ATT00800Back.ATT00810DTO) As ATT00800Back.ATT00810DTO Implements R_BackEnd.R_IServicebase(Of ATT00800Back.ATT00810DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(ByVal poEntity As ATT00800Back.ATT00810DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As ATT00800Back.ATT00810DTO Implements R_BackEnd.R_IServicebase(Of ATT00800Back.ATT00810DTO).Svc_R_Save

    End Function
End Class

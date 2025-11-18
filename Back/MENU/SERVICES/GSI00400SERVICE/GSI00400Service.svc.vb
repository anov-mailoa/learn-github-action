' NOTE: You can use the "Rename" command on the context menu to change the class name "GSI00400Service" in code, svc and config file together.
Public Class GSI00400Service
    Implements IGSI00400Service

    Public Sub Svc_R_Delete(poEntity As GSI00400Back.GSI00400DTO) Implements R_BackEnd.R_IServicebase(Of GSI00400Back.GSI00400DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSI00400Back.GSI00400DTO) As GSI00400Back.GSI00400DTO Implements R_BackEnd.R_IServicebase(Of GSI00400Back.GSI00400DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As GSI00400Back.GSI00400DTO, poCRUDMode As R_Common.eCRUDMode) As GSI00400Back.GSI00400DTO Implements R_BackEnd.R_IServicebase(Of GSI00400Back.GSI00400DTO).Svc_R_Save

    End Function
End Class

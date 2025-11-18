' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00550Service" in code, svc and config file together.
Public Class ATR00550Service
    Implements IATR00550Service

    Public Sub Svc_R_Delete(poEntity As ATR00550Back.ATR00550DTO) Implements R_BackEnd.R_IServicebase(Of ATR00550Back.ATR00550DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00550Back.ATR00550DTO) As ATR00550Back.ATR00550DTO Implements R_BackEnd.R_IServicebase(Of ATR00550Back.ATR00550DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00550Back.ATR00550DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00550Back.ATR00550DTO Implements R_BackEnd.R_IServicebase(Of ATR00550Back.ATR00550DTO).Svc_R_Save

    End Function
End Class

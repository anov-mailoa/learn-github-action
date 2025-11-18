' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00400Service" in code, svc and config file together.
Public Class ATR00400Service
    Implements IATR00400Service

    Public Sub Svc_R_Delete(poEntity As ATR00400Back.ATR00400DTO) Implements R_BackEnd.R_IServicebase(Of ATR00400Back.ATR00400DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00400Back.ATR00400DTO) As ATR00400Back.ATR00400DTO Implements R_BackEnd.R_IServicebase(Of ATR00400Back.ATR00400DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00400Back.ATR00400DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00400Back.ATR00400DTO Implements R_BackEnd.R_IServicebase(Of ATR00400Back.ATR00400DTO).Svc_R_Save

    End Function
End Class

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00540Service" in code, svc and config file together.
Public Class ATR00540Service
    Implements IATR00540Service

    Public Sub Svc_R_Delete(poEntity As ATR00540Back.ATR00540DTO) Implements R_BackEnd.R_IServicebase(Of ATR00540Back.ATR00540DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00540Back.ATR00540DTO) As ATR00540Back.ATR00540DTO Implements R_BackEnd.R_IServicebase(Of ATR00540Back.ATR00540DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00540Back.ATR00540DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00540Back.ATR00540DTO Implements R_BackEnd.R_IServicebase(Of ATR00540Back.ATR00540DTO).Svc_R_Save

    End Function
End Class

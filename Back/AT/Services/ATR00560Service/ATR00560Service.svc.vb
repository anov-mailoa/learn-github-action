' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00560Service" in code, svc and config file together.
Public Class ATR00560Service
    Implements IATR00560Service

    Public Sub Svc_R_Delete(poEntity As ATR00560Back.ATR00560DTO) Implements R_BackEnd.R_IServicebase(Of ATR00560Back.ATR00560DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00560Back.ATR00560DTO) As ATR00560Back.ATR00560DTO Implements R_BackEnd.R_IServicebase(Of ATR00560Back.ATR00560DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00560Back.ATR00560DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00560Back.ATR00560DTO Implements R_BackEnd.R_IServicebase(Of ATR00560Back.ATR00560DTO).Svc_R_Save

    End Function
End Class

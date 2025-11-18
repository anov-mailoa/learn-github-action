' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00510Service" in code, svc and config file together.
Public Class ATR00510Service
    Implements IATR00510Service

    Public Sub Svc_R_Delete(poEntity As ATR00510Back.ATR00510DTO) Implements R_BackEnd.R_IServicebase(Of ATR00510Back.ATR00510DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00510Back.ATR00510DTO) As ATR00510Back.ATR00510DTO Implements R_BackEnd.R_IServicebase(Of ATR00510Back.ATR00510DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00510Back.ATR00510DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00510Back.ATR00510DTO Implements R_BackEnd.R_IServicebase(Of ATR00510Back.ATR00510DTO).Svc_R_Save

    End Function
End Class

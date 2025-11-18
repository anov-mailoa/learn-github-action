' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00580Service" in code, svc and config file together.
Public Class ATR00580Service
    Implements IATR00580Service

    Public Sub Svc_R_Delete(poEntity As ATR00580Back.ATR00580DTO) Implements R_BackEnd.R_IServicebase(Of ATR00580Back.ATR00580DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00580Back.ATR00580DTO) As ATR00580Back.ATR00580DTO Implements R_BackEnd.R_IServicebase(Of ATR00580Back.ATR00580DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00580Back.ATR00580DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00580Back.ATR00580DTO Implements R_BackEnd.R_IServicebase(Of ATR00580Back.ATR00580DTO).Svc_R_Save

    End Function
End Class

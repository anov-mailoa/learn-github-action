' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00520Service" in code, svc and config file together.
Public Class ATR00520Service
    Implements IATR00520Service

    Public Sub Svc_R_Delete(poEntity As ATR00520Back.ATR00520DTO) Implements R_BackEnd.R_IServicebase(Of ATR00520Back.ATR00520DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00520Back.ATR00520DTO) As ATR00520Back.ATR00520DTO Implements R_BackEnd.R_IServicebase(Of ATR00520Back.ATR00520DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00520Back.ATR00520DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00520Back.ATR00520DTO Implements R_BackEnd.R_IServicebase(Of ATR00520Back.ATR00520DTO).Svc_R_Save

    End Function
End Class

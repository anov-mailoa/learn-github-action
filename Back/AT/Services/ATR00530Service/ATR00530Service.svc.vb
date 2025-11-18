' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00530Service" in code, svc and config file together.
Public Class ATR00530Service
    Implements IATR00530Service

    Public Sub Svc_R_Delete(poEntity As ATR00530Back.ATR00530DTO) Implements R_BackEnd.R_IServicebase(Of ATR00530Back.ATR00530DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00530Back.ATR00530DTO) As ATR00530Back.ATR00530DTO Implements R_BackEnd.R_IServicebase(Of ATR00530Back.ATR00530DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00530Back.ATR00530DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00530Back.ATR00530DTO Implements R_BackEnd.R_IServicebase(Of ATR00530Back.ATR00530DTO).Svc_R_Save

    End Function
End Class

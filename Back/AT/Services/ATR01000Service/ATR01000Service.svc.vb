' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01000Service" in code, svc and config file together.
Public Class ATR01000Service
    Implements IATR01000Service

    Public Sub Svc_R_Delete(poEntity As ATR01000Back.ATR01000DTO) Implements R_BackEnd.R_IServicebase(Of ATR01000Back.ATR01000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR01000Back.ATR01000DTO) As ATR01000Back.ATR01000DTO Implements R_BackEnd.R_IServicebase(Of ATR01000Back.ATR01000DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR01000Back.ATR01000DTO, poCRUDMode As R_Common.eCRUDMode) As ATR01000Back.ATR01000DTO Implements R_BackEnd.R_IServicebase(Of ATR01000Back.ATR01000DTO).Svc_R_Save

    End Function

End Class

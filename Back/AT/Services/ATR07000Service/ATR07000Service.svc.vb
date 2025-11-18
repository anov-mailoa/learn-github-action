' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR07000Service" in code, svc and config file together.
Public Class ATR07000Service
    Implements IATR07000Service

    Public Sub Svc_R_Delete(poEntity As ATR07000Back.ATR07000DTO) Implements R_BackEnd.R_IServicebase(Of ATR07000Back.ATR07000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR07000Back.ATR07000DTO) As ATR07000Back.ATR07000DTO Implements R_BackEnd.R_IServicebase(Of ATR07000Back.ATR07000DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR07000Back.ATR07000DTO, poCRUDMode As R_Common.eCRUDMode) As ATR07000Back.ATR07000DTO Implements R_BackEnd.R_IServicebase(Of ATR07000Back.ATR07000DTO).Svc_R_Save

    End Function
End Class

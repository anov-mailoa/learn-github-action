' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00590Service" in code, svc and config file together.
Public Class ATR00590Service
    Implements IATR00590Service

    Public Sub Svc_R_Delete(poEntity As ATR00590Back.ATR00590DTO) Implements R_BackEnd.R_IServicebase(Of ATR00590Back.ATR00590DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00590Back.ATR00590DTO) As ATR00590Back.ATR00590DTO Implements R_BackEnd.R_IServicebase(Of ATR00590Back.ATR00590DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00590Back.ATR00590DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00590Back.ATR00590DTO Implements R_BackEnd.R_IServicebase(Of ATR00590Back.ATR00590DTO).Svc_R_Save

    End Function
End Class

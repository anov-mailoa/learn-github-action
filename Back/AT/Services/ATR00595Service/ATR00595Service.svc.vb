' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00595Service" in code, svc and config file together.
Public Class ATR00595Service
    Implements IATR00595Service

    Public Sub Svc_R_Delete(poEntity As ATR00595Back.ATR00595DTO) Implements R_BackEnd.R_IServicebase(Of ATR00595Back.ATR00595DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00595Back.ATR00595DTO) As ATR00595Back.ATR00595DTO Implements R_BackEnd.R_IServicebase(Of ATR00595Back.ATR00595DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00595Back.ATR00595DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00595Back.ATR00595DTO Implements R_BackEnd.R_IServicebase(Of ATR00595Back.ATR00595DTO).Svc_R_Save

    End Function
End Class

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01050Service" in code, svc and config file together.
Public Class ATR01050Service
    Implements IATR01050Service

    Public Sub Svc_R_Delete(poEntity As ATR01050Back.ATR01050DTO) Implements R_BackEnd.R_IServicebase(Of ATR01050Back.ATR01050DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR01050Back.ATR01050DTO) As ATR01050Back.ATR01050DTO Implements R_BackEnd.R_IServicebase(Of ATR01050Back.ATR01050DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR01050Back.ATR01050DTO, poCRUDMode As R_Common.eCRUDMode) As ATR01050Back.ATR01050DTO Implements R_BackEnd.R_IServicebase(Of ATR01050Back.ATR01050DTO).Svc_R_Save

    End Function

End Class

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR10700Service" in code, svc and config file together.
Public Class ATR10700Service
    Implements IATR10700Service

    Public Sub Svc_R_Delete(poEntity As ATR10700Back.ATR10700DTO) Implements R_BackEnd.R_IServicebase(Of ATR10700Back.ATR10700DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR10700Back.ATR10700DTO) As ATR10700Back.ATR10700DTO Implements R_BackEnd.R_IServicebase(Of ATR10700Back.ATR10700DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR10700Back.ATR10700DTO, poCRUDMode As R_Common.eCRUDMode) As ATR10700Back.ATR10700DTO Implements R_BackEnd.R_IServicebase(Of ATR10700Back.ATR10700DTO).Svc_R_Save

    End Function
End Class

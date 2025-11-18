' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00570Service" in code, svc and config file together.
Public Class ATR00570Service
    Implements IATR00570Service

    Public Sub Svc_R_Delete(poEntity As ATR00570Back.ATR00570DTO) Implements R_BackEnd.R_IServicebase(Of ATR00570Back.ATR00570DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00570Back.ATR00570DTO) As ATR00570Back.ATR00570DTO Implements R_BackEnd.R_IServicebase(Of ATR00570Back.ATR00570DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00570Back.ATR00570DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00570Back.ATR00570DTO Implements R_BackEnd.R_IServicebase(Of ATR00570Back.ATR00570DTO).Svc_R_Save

    End Function
End Class

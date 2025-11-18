Imports R_Common
Imports ATR00800Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00800Service" in code, svc and config file together.
Public Class ATR00800Service
    Implements IATR00800Service

    Public Sub Svc_R_Delete(poEntity As ATR00800Back.ATR00800DTO) Implements R_BackEnd.R_IServicebase(Of ATR00800Back.ATR00800DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00800Back.ATR00800DTO) As ATR00800Back.ATR00800DTO Implements R_BackEnd.R_IServicebase(Of ATR00800Back.ATR00800DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00800Back.ATR00800DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00800Back.ATR00800DTO Implements R_BackEnd.R_IServicebase(Of ATR00800Back.ATR00800DTO).Svc_R_Save

    End Function
End Class

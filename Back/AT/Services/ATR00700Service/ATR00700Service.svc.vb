Imports R_BackEnd
Imports R_Common
Imports ATR00700Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00700Service" in code, svc and config file together.
Public Class ATR00700Service
    Implements IATR00700Service

    Public Sub Svc_R_Delete(poEntity As ATR00700Back.ATR00700DTO) Implements R_BackEnd.R_IServicebase(Of ATR00700Back.ATR00700DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00700Back.ATR00700DTO) As ATR00700Back.ATR00700DTO Implements R_BackEnd.R_IServicebase(Of ATR00700Back.ATR00700DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00700Back.ATR00700DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00700Back.ATR00700DTO Implements R_BackEnd.R_IServicebase(Of ATR00700Back.ATR00700DTO).Svc_R_Save

    End Function

End Class

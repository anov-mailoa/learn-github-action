Imports R_BackEnd
Imports R_Common
Imports ATR02100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR02100Service" in code, svc and config file together.
Public Class ATR02100Service
    Implements IATR02100Service

    Public Sub Svc_R_Delete(poEntity As ATR02100Back.ATR02100DTO) Implements R_BackEnd.R_IServicebase(Of ATR02100Back.ATR02100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR02100Back.ATR02100DTO) As ATR02100Back.ATR02100DTO Implements R_BackEnd.R_IServicebase(Of ATR02100Back.ATR02100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR02100Back.ATR02100DTO, poCRUDMode As R_Common.eCRUDMode) As ATR02100Back.ATR02100DTO Implements R_BackEnd.R_IServicebase(Of ATR02100Back.ATR02100DTO).Svc_R_Save

    End Function

End Class

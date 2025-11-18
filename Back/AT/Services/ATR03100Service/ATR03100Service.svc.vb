Imports R_BackEnd
Imports R_Common
Imports ATR03100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR03100Service" in code, svc and config file together.
Public Class ATR03100Service
    Implements IATR03100Service

    Public Sub Svc_R_Delete(poEntity As ATR03100Back.ATR03100DTO) Implements R_BackEnd.R_IServicebase(Of ATR03100Back.ATR03100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR03100Back.ATR03100DTO) As ATR03100Back.ATR03100DTO Implements R_BackEnd.R_IServicebase(Of ATR03100Back.ATR03100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR03100Back.ATR03100DTO, poCRUDMode As R_Common.eCRUDMode) As ATR03100Back.ATR03100DTO Implements R_BackEnd.R_IServicebase(Of ATR03100Back.ATR03100DTO).Svc_R_Save

    End Function

End Class

Imports R_BackEnd
Imports R_Common
Imports ATR02200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR02200Service" in code, svc and config file together.
Public Class ATR02200Service
    Implements IATR02200Service

    Public Sub Svc_R_Delete(poEntity As ATR02200Back.ATR02200DTO) Implements R_BackEnd.R_IServicebase(Of ATR02200Back.ATR02200DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR02200Back.ATR02200DTO) As ATR02200Back.ATR02200DTO Implements R_BackEnd.R_IServicebase(Of ATR02200Back.ATR02200DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR02200Back.ATR02200DTO, poCRUDMode As R_Common.eCRUDMode) As ATR02200Back.ATR02200DTO Implements R_BackEnd.R_IServicebase(Of ATR02200Back.ATR02200DTO).Svc_R_Save

    End Function

End Class

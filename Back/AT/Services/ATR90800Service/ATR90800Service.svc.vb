Imports System.ServiceModel
Imports R_Common
Imports ATR90800Back
Imports ATR90800Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR90800Service" in code, svc and config file together.
Public Class ATR90800Service
    Implements IATR90800Service

    Public Sub Svc_R_Delete(poEntity As ATR90800Back.ATR90800DTO) Implements R_BackEnd.R_IServicebase(Of ATR90800Back.ATR90800DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR90800Back.ATR90800DTO) As ATR90800Back.ATR90800DTO Implements R_BackEnd.R_IServicebase(Of ATR90800Back.ATR90800DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR90800Back.ATR90800DTO, poCRUDMode As R_Common.eCRUDMode) As ATR90800Back.ATR90800DTO Implements R_BackEnd.R_IServicebase(Of ATR90800Back.ATR90800DTO).Svc_R_Save

    End Function
End Class

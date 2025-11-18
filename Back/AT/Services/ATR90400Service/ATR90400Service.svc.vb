Imports System.ServiceModel
Imports R_Common
Imports ATR90400Back
Imports ATR90400Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR90400Service" in code, svc and config file together.
Public Class ATR90400Service
    Implements IATR90400Service

    Public Sub Svc_R_Delete(poEntity As ATR90400Back.ATR90400DTO) Implements R_BackEnd.R_IServicebase(Of ATR90400Back.ATR90400DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR90400Back.ATR90400DTO) As ATR90400Back.ATR90400DTO Implements R_BackEnd.R_IServicebase(Of ATR90400Back.ATR90400DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR90400Back.ATR90400DTO, poCRUDMode As R_Common.eCRUDMode) As ATR90400Back.ATR90400DTO Implements R_BackEnd.R_IServicebase(Of ATR90400Back.ATR90400DTO).Svc_R_Save

    End Function
End Class

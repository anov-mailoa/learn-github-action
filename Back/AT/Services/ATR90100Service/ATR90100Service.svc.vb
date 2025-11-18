Imports System.ServiceModel
Imports R_Common
Imports ATR90100Back
Imports ATR90100Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR90100Service" in code, svc and config file together.
Public Class ATR90100Service
    Implements IATR90100Service

    Public Sub Svc_R_Delete(poEntity As ATR90100Back.ATR90100DTO) Implements R_BackEnd.R_IServicebase(Of ATR90100Back.ATR90100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR90100Back.ATR90100DTO) As ATR90100Back.ATR90100DTO Implements R_BackEnd.R_IServicebase(Of ATR90100Back.ATR90100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR90100Back.ATR90100DTO, poCRUDMode As R_Common.eCRUDMode) As ATR90100Back.ATR90100DTO Implements R_BackEnd.R_IServicebase(Of ATR90100Back.ATR90100DTO).Svc_R_Save

    End Function
End Class

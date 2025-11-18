' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00100Service" in code, svc and config file together.
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00100Back
Imports ATR00100Common
Imports R_BackEnd

Public Class ATR00100Service
    Implements IATR00100Service


    Public Sub Svc_R_Delete(poEntity As ATR00100Back.ATR00100DTO) Implements R_BackEnd.R_IServicebase(Of ATR00100Back.ATR00100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR00100Back.ATR00100DTO) As ATR00100Back.ATR00100DTO Implements R_BackEnd.R_IServicebase(Of ATR00100Back.ATR00100DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR00100Back.ATR00100DTO, poCRUDMode As R_Common.eCRUDMode) As ATR00100Back.ATR00100DTO Implements R_BackEnd.R_IServicebase(Of ATR00100Back.ATR00100DTO).Svc_R_Save

    End Function
End Class

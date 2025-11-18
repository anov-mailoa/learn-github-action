Imports System.ServiceModel
Imports R_Common
Imports ATT00500Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00500MultipleService" in code, svc and config file together.
Public Class ATT00500MultipleService
    Implements IATT00500MultipleService


    Public Sub DoWork() Implements IATT00500MultipleService.DoWork
    End Sub

    Public Sub Svc_R_Delete(poEntity As ATT00500Back.ATT00500MultipleDTO) Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500MultipleDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00500Back.ATT00500MultipleDTO) As ATT00500Back.ATT00500MultipleDTO Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500MultipleDTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATT00500Back.ATT00500MultipleDTO, poCRUDMode As R_Common.eCRUDMode) As ATT00500Back.ATT00500MultipleDTO Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500MultipleDTO).Svc_R_Save

    End Function
End Class

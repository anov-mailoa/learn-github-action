Imports R_BackEnd
Imports R_Common
Imports ATT90200Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90220Service" in code, svc and config file together.
Public Class ATT90220Service
    Implements IATT90220Service


    Public Sub Svc_R_Delete(poEntity As ATT90200Back.ATT90220DTO) Implements R_BackEnd.R_IServicebase(Of ATT90200Back.ATT90220DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT90200Back.ATT90220DTO) As ATT90200Back.ATT90220DTO Implements R_BackEnd.R_IServicebase(Of ATT90200Back.ATT90220DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATT90200Back.ATT90220DTO, poCRUDMode As R_Common.eCRUDMode) As ATT90200Back.ATT90220DTO Implements R_BackEnd.R_IServicebase(Of ATT90200Back.ATT90220DTO).Svc_R_Save

    End Function
End Class

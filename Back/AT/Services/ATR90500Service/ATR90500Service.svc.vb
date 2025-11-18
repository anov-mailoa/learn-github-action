Imports System.ServiceModel
Imports R_Common
Imports ATR90500Back
Imports ATR90500Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR90500Service" in code, svc and config file together.
Public Class ATR90500Service
    Implements IATR90500Service

    Public Sub Svc_R_Delete(poEntity As ATR90500Back.ATR90500DTO) Implements R_BackEnd.R_IServicebase(Of ATR90500Back.ATR90500DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATR90500Back.ATR90500DTO) As ATR90500Back.ATR90500DTO Implements R_BackEnd.R_IServicebase(Of ATR90500Back.ATR90500DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATR90500Back.ATR90500DTO, poCRUDMode As R_Common.eCRUDMode) As ATR90500Back.ATR90500DTO Implements R_BackEnd.R_IServicebase(Of ATR90500Back.ATR90500DTO).Svc_R_Save

    End Function

  
End Class

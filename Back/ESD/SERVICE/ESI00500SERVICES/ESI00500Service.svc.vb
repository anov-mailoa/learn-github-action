Imports R_Common
Imports ESI00500Back
Imports ESI00500Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESI00500Service" in code, svc and config file together.
Public Class ESI00500Service
    Implements IESI00500Service

    Public Sub Svc_R_Delete1(poEntity As ESI00500Back.ParameterDTO) Implements R_BackEnd.R_IServicebase(Of ESI00500Back.ParameterDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord1(poEntity As ESI00500Back.ParameterDTO) As ESI00500Back.ParameterDTO Implements R_BackEnd.R_IServicebase(Of ESI00500Back.ParameterDTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save1(poEntity As ESI00500Back.ParameterDTO, poCRUDMode As R_Common.eCRUDMode) As ESI00500Back.ParameterDTO Implements R_BackEnd.R_IServicebase(Of ESI00500Back.ParameterDTO).Svc_R_Save

    End Function
End Class

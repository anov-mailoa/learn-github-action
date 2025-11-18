Imports R_Common
Imports ESM01400Back
Imports ESM01400Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01400Service" in code, svc and config file together.
Public Class ESM01400Service
    Implements IESM01400Service

    Public Sub Svc_R_Delete(poEntity As ESM01400Back.ESM01400ParameterDTO) Implements R_BackEnd.R_IServicebase(Of ESM01400Back.ESM01400ParameterDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM01400Back.ESM01400ParameterDTO) As ESM01400Back.ESM01400ParameterDTO Implements R_BackEnd.R_IServicebase(Of ESM01400Back.ESM01400ParameterDTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ESM01400Back.ESM01400ParameterDTO, poCRUDMode As R_Common.eCRUDMode) As ESM01400Back.ESM01400ParameterDTO Implements R_BackEnd.R_IServicebase(Of ESM01400Back.ESM01400ParameterDTO).Svc_R_Save

    End Function
End Class

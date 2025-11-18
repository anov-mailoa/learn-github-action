Imports R_BackEnd
Imports R_Common
Imports MCR05000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR05000Service" in code, svc and config file together.
Public Class MCR05000Service
    Implements IMCR05000Service

    Public Sub Svc_R_Delete(poEntity As MCR05000Back.MCR05000DTO) Implements R_BackEnd.R_IServicebase(Of MCR05000Back.MCR05000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCR05000Back.MCR05000DTO) As MCR05000Back.MCR05000DTO Implements R_BackEnd.R_IServicebase(Of MCR05000Back.MCR05000DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As MCR05000Back.MCR05000DTO, poCRUDMode As R_Common.eCRUDMode) As MCR05000Back.MCR05000DTO Implements R_BackEnd.R_IServicebase(Of MCR05000Back.MCR05000DTO).Svc_R_Save

    End Function

    Public Function getMcmLimitPolicy(pcCompId As String) As MCR05000Back.MCR05000DTO Implements IMCR05000Service.getMcmLimitPolicy
        Dim loException As New R_Exception
        Dim loCls As New MCR05000Cls
        Dim loRtn As New MCR05000DTO

        Try
            loRtn = loCls.getMcmLimitPolicy(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

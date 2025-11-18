Imports R_Common
Imports R_BackEnd
Imports PNI04000Back
Imports PNI04000Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNI04000Service" in code, svc and config file together.
Public Class PNI04000Service
    Implements IPNI04000Service

    Public Sub Svc_R_Delete(poEntity As PNI04000Back.PNI04000DTO) Implements R_BackEnd.R_IServicebase(Of PNI04000Back.PNI04000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNI04000CLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNI04000Back.PNI04000DTO) As PNI04000Back.PNI04000DTO Implements R_BackEnd.R_IServicebase(Of PNI04000Back.PNI04000DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PNI04000Back.PNI04000DTO, poCRUDMode As R_Common.eCRUDMode) As PNI04000Back.PNI04000DTO Implements R_BackEnd.R_IServicebase(Of PNI04000Back.PNI04000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNI04000CLS
        Dim loRtn As New PNI04000DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

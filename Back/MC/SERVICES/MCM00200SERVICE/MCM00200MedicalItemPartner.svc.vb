Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
Imports MCM00200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM00200MedicalItemPartner" in code, svc and config file together.
Public Class MCM00200MedicalItemPartner
    Implements IMCM00200MedicalItemPartner

    Public Sub Svc_R_Delete(poEntity As MCM00200Back.MCM00200GridMedicalPartnerDTO) Implements R_BackEnd.R_IServicebase(Of MCM00200Back.MCM00200GridMedicalPartnerDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM00200MedicalPartnerCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM00200Back.MCM00200GridMedicalPartnerDTO) As MCM00200Back.MCM00200GridMedicalPartnerDTO Implements R_BackEnd.R_IServicebase(Of MCM00200Back.MCM00200GridMedicalPartnerDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New MCM00200MedicalPartnerCls
        Dim loRtn As New MCM00200GridMedicalPartnerDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM00200Back.MCM00200GridMedicalPartnerDTO, poCRUDMode As R_Common.eCRUDMode) As MCM00200Back.MCM00200GridMedicalPartnerDTO Implements R_BackEnd.R_IServicebase(Of MCM00200Back.MCM00200GridMedicalPartnerDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM00200MedicalPartnerCls
        Dim loRtn As New MCM00200GridMedicalPartnerDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

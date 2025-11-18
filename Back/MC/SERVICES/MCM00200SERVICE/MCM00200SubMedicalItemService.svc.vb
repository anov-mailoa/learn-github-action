Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
Imports MCM00200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM00200SubMedicalItemService" in code, svc and config file together.
Public Class MCM00200SubMedicalItemService
    Implements IMCM00200SubMedicalItemService

    Public Sub Svc_R_Delete(poEntity As MCM00200Back.MCM00200GridSubMedItemDTO) Implements R_BackEnd.R_IServicebase(Of MCM00200Back.MCM00200GridSubMedItemDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM00200SubMedicalItemCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM00200Back.MCM00200GridSubMedItemDTO) As MCM00200Back.MCM00200GridSubMedItemDTO Implements R_BackEnd.R_IServicebase(Of MCM00200Back.MCM00200GridSubMedItemDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New MCM00200SubMedicalItemCls
        Dim loRtn As New MCM00200GridSubMedItemDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM00200Back.MCM00200GridSubMedItemDTO, poCRUDMode As R_Common.eCRUDMode) As MCM00200Back.MCM00200GridSubMedItemDTO Implements R_BackEnd.R_IServicebase(Of MCM00200Back.MCM00200GridSubMedItemDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM00200SubMedicalItemCls
        Dim loRtn As New MCM00200GridSubMedItemDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

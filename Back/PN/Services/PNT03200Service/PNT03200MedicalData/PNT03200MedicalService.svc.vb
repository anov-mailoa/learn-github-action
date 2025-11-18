Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03200MedicalService" in code, svc and config file together.
Public Class PNT03200MedicalService
    Implements IPNT03200MedicalService

    Public Sub Svc_R_Delete(poEntity As PNT03200Back.PNT03200MedicalDTO) Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200MedicalDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200MedicalCls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT03200Back.PNT03200MedicalDTO) As PNT03200Back.PNT03200MedicalDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200MedicalDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200MedicalCls
        Dim loRtn As PNT03200MedicalDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT03200Back.PNT03200MedicalDTO, poCRUDMode As R_Common.eCRUDMode) As PNT03200Back.PNT03200MedicalDTO Implements R_BackEnd.R_IServicebase(Of PNT03200Back.PNT03200MedicalDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200MedicalCls
        Dim loRtn As New PNT03200MedicalDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function removeDocument(poParameter As PNT03200Back.PNT03200MedicalDTO) As PNT03200Back.PNT03200MedicalDTO Implements IPNT03200MedicalService.removeDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200MedicalCls
        Dim loRtn As PNT03200MedicalDTO

        Try
            loRtn = loCls.removeDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function saveDocument(poParameter As PNT03200Back.PNT03200MedicalDTO) As PNT03200Back.PNT03200MedicalDTO Implements IPNT03200MedicalService.saveDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT03200MedicalCls
        Dim loRtn As PNT03200MedicalDTO

        Try
            loRtn = loCls.saveDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

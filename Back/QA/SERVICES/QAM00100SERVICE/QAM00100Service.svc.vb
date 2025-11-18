Imports R_BackEnd
Imports R_Common
Imports QAM00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00100Service" in code, svc and config file together.
Public Class QAM00100Service
    Implements IQAM00100Service


    Public Sub Svc_R_Delete(ByVal poEntity As QAM00100Back.QAM00100DTO) Implements R_BackEnd.R_IServicebase(Of QAM00100Back.QAM00100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAM00100Back.QAM00100DTO) As QAM00100Back.QAM00100DTO Implements R_BackEnd.R_IServicebase(Of QAM00100Back.QAM00100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAM00100CLS
        Dim loRtn As New QAM00100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAM00100Back.QAM00100DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAM00100Back.QAM00100DTO Implements R_BackEnd.R_IServicebase(Of QAM00100Back.QAM00100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAM00100CLS
        Dim loRtn As New QAM00100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetValidationOwnerDeptLevel(ByVal poPar As QAM00100Back.QAM00100DTO) As Boolean Implements IQAM00100Service.GetValidationOwnerDeptLevel
        Dim loEx As New R_Exception
        Dim loCls As New QAM00100CLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.GetValidationOwnerDeptLevel(poPar)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

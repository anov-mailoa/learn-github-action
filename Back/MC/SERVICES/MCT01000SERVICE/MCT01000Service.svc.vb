Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
Imports MCT01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT01000Service" in code, svc and config file together.
Public Class MCT01000Service
    Implements IMCT01000Service

    Public Sub Svc_R_Delete(poEntity As MCT01000Back.MCT01000DTO) Implements R_BackEnd.R_IServicebase(Of MCT01000Back.MCT01000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCT01000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT01000Back.MCT01000DTO) As MCT01000Back.MCT01000DTO Implements R_BackEnd.R_IServicebase(Of MCT01000Back.MCT01000DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New MCT01000Cls
        Dim loRtn As New MCT01000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCT01000Back.MCT01000DTO, poCRUDMode As R_Common.eCRUDMode) As MCT01000Back.MCT01000DTO Implements R_BackEnd.R_IServicebase(Of MCT01000Back.MCT01000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCT01000Cls
        Dim loRtn As New MCT01000DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getMcmLimitPolicy(pcCompId As String) As MCT01000Back.MCT01000DTO Implements IMCT01000Service.getMcmLimitPolicy
        Dim loException As New R_Exception
        Dim loCls As New MCT01000Cls
        Dim loRtn As New MCT01000DTO

        Try
            loRtn = loCls.getMcmLimitPolicy(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getMcmMedicalRestriction(pcCompId As String) As MCT01000Back.MCT01000DTO Implements IMCT01000Service.getMcmMedicalRestriction
        Dim loException As New R_Exception
        Dim loCls As New MCT01000Cls
        Dim loRtn As New MCT01000DTO

        Try
            loRtn = loCls.getMcmMedicalRestriction(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As MCT01000Back.MCT01000DTO) As MCT01000Back.MCT01000DTO Implements IMCT01000Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loCls As New MCT01000Cls
        Dim loRtn As New MCT01000DTO

        Try
            loRtn = loCls.DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As MCT01000Back.MCT01000DTO) As MCT01000Back.MCT01000DTO Implements IMCT01000Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New MCT01000Cls
        Dim loRtn As New MCT01000DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function CheckEmployeeMedicalBank(poParam As MCT01000Back.MCT01000DTO) As String Implements IMCT01000Service.CheckEmployeeMedicalBank
        Dim loEx As New R_Exception
        Dim loCls As New MCT01000Cls
        Dim lcRtn As String
        Try
            lcRtn = loCls.CheckEmployeeMedicalBank(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function

End Class

Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
Imports MCB01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCB01000Service" in code, svc and config file together.
Public Class MCB01000Service
    Implements IMCB01000Service

    Public Sub Svc_R_Delete(poEntity As MCB01000Back.MCB01000DTO) Implements R_BackEnd.R_IServicebase(Of MCB01000Back.MCB01000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCB01000Back.MCB01000DTO) As MCB01000Back.MCB01000DTO Implements R_BackEnd.R_IServicebase(Of MCB01000Back.MCB01000DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As MCB01000Back.MCB01000DTO, poCRUDMode As R_Common.eCRUDMode) As MCB01000Back.MCB01000DTO Implements R_BackEnd.R_IServicebase(Of MCB01000Back.MCB01000DTO).Svc_R_Save

    End Function

    Public Function getMcmLimitPolicy(pcCompId As String) As MCB01000Back.MCB01000DTO Implements IMCB01000Service.getMcmLimitPolicy
        Dim loException As New R_Exception
        Dim loCls As New MCB01000Cls
        Dim loRtn As New MCB01000DTO

        Try
            loRtn = loCls.getMcmLimitPolicy(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function cekMcmLimitPolicy(pcCompId As String) As MCB01000Back.MCB01000DTO Implements IMCB01000Service.cekMcmLimitPolicy
        Dim loException As New R_Exception
        Dim loCls As New MCB01000Cls
        Dim loRtn As New MCB01000DTO

        Try
            loRtn = loCls.cekMcmLimitPolicy(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getInit(pcCompid As String) As MCB01000Back.MCB01000DTO Implements IMCB01000Service.getInit
        Dim loException As New R_Exception
        Dim loCls As New MCB01000Cls
        Dim loRtn As New MCB01000DTO

        Try
            loRtn = loCls.getInit(pcCompid)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function UpdateValidation(pcCompid As MCB01000Back.MCB01000DTO) As MCB01000Back.MCB01000DTO Implements IMCB01000Service.UpdateValidation
        Dim loException As New R_Exception
        Dim loCls As New MCB01000Cls
        Dim loRtn As New MCB01000DTO

        Try
            loRtn = loCls.UpdateValidation(pcCompid)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

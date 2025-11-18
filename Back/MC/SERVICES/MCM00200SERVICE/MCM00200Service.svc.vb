Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
Imports MCM00200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM00200Service" in code, svc and config file together.
Public Class MCM00200Service
    Implements IMCM00200Service

    Public Sub Svc_R_Delete(poEntity As MCM00200Back.MCM00200DTO) Implements R_BackEnd.R_IServicebase(Of MCM00200Back.MCM00200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM00200Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM00200Back.MCM00200DTO) As MCM00200Back.MCM00200DTO Implements R_BackEnd.R_IServicebase(Of MCM00200Back.MCM00200DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New MCM00200Cls
        Dim loRtn As New MCM00200DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM00200Back.MCM00200DTO, poCRUDMode As R_Common.eCRUDMode) As MCM00200Back.MCM00200DTO Implements R_BackEnd.R_IServicebase(Of MCM00200Back.MCM00200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM00200Cls
        Dim loRtn As New MCM00200DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    'Public Sub checkMcmRuleDtItem(pcCompId As String, pcItemId As String) Implements IMCM00200Service.checkMcmRuleDtItem
    '    Dim loException As New R_Exception
    '    Dim loCls As New MCM00200Cls

    '    Try
    '        loCls.checkMcmRuleDtItem(pcCompId, pcItemId)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub

    'Public Sub checkMctClaimHd(pcCompId As String, pcItemId As String) Implements IMCM00200Service.checkMctClaimHd
    '    Dim loException As New R_Exception
    '    Dim loCls As New MCM00200Cls

    '    Try
    '        loCls.checkMcmRuleDtItem(pcCompId, pcItemId)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub

    Public Function getActive(poParam As MCM00200Back.MCM00200DTO) As MCM00200Back.MCM00200DTO Implements IMCM00200Service.getActive
        Dim loEx As New R_Exception
        Dim loCls As New MCM00200Cls
        Dim loRtn As New MCM00200DTO

        Try
            loRtn = loCls.getActive(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkMcmRuleDtItem(pcCompId As String, pcItemId As String) As MCM00200Back.MCM00200DTO Implements IMCM00200Service.checkMcmRuleDtItem
        Dim loException As New R_Exception
        Dim loCls As New MCM00200Cls
        Dim loRtn As New MCM00200DTO

        Try
            loRtn = loCls.checkMcmRuleDtItem(pcCompId, pcItemId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function checkMctClaimHd(pcCompId As String, pcItemId As String) As MCM00200Back.MCM00200DTO Implements IMCM00200Service.checkMctClaimHd
        Dim loException As New R_Exception
        Dim loCls As New MCM00200Cls
        Dim loRtn As New MCM00200DTO

        Try
            loRtn = loCls.checkMctClaimHd(pcCompId, pcItemId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

End Class

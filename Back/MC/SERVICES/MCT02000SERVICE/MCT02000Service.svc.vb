Imports R_Common
Imports R_BackEnd
Imports MCT02000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT02000Service" in code, svc and config file together.
Public Class MCT02000Service
    Implements IMCT02000Service

    Public Sub Svc_R_Delete(poEntity As MCT02000Back.MCT02000DTO) Implements R_BackEnd.R_IServicebase(Of MCT02000Back.MCT02000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCT02000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT02000Back.MCT02000DTO) As MCT02000Back.MCT02000DTO Implements R_BackEnd.R_IServicebase(Of MCT02000Back.MCT02000DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New MCT02000Cls
        Dim loRtn As New MCT02000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCT02000Back.MCT02000DTO, poCRUDMode As R_Common.eCRUDMode) As MCT02000Back.MCT02000DTO Implements R_BackEnd.R_IServicebase(Of MCT02000Back.MCT02000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCT02000Cls
        Dim loRtn As New MCT02000DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As MCT02000Back.MCT02000DTO) As MCT02000Back.MCT02000DTO Implements IMCT02000Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loCls As New MCT02000Cls
        Dim loRtn As New MCT02000DTO

        Try
            loRtn = loCls.DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As MCT02000Back.MCT02000DTO) As MCT02000Back.MCT02000DTO Implements IMCT02000Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New MCT02000Cls
        Dim loRtn As New MCT02000DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String) Implements IMCT02000Service.chekStatusDelete
        Dim loException As New R_Exception
        Dim loCls As New MCT02000Cls

        Try
            loCls.chekStatusDelete(pcCompId, pcTransCode, pcDeptCode, pcRefNo)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String) Implements IMCT02000Service.chekStatusEdit
        Dim loException As New R_Exception
        Dim loCls As New MCT02000Cls

        Try
            loCls.chekStatusEdit(pcCompId, pcTransCode, pcDeptCode, pcRefNo)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getMcmLimitPolicy(pcCompId As String) As MCT02000Back.MCT02000DTO Implements IMCT02000Service.getMcmLimitPolicy
        Dim loException As New R_Exception
        Dim loCls As New MCT02000Cls
        Dim loRtn As New MCT02000DTO

        Try
            loRtn = loCls.getMcmLimitPolicy(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getMcmLimitPolicy2(pcCompId As String, pcYear As String) As MCT02000Back.MCT02000DTO Implements IMCT02000Service.getMcmLimitPolicy2
        Dim loException As New R_Exception
        Dim loCls As New MCT02000Cls
        Dim loRtn As New MCT02000DTO

        Try
            loRtn = loCls.getMcmLimitPolicy2(pcCompId, pcYear)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function CheckLimitCorrection(pcCompanyId As String) As Integer Implements IMCT02000Service.CheckLimitCorrection
        Dim iRtn As Integer
        Dim loCls As New MCT02000Cls
        Dim loEx As New R_Exception

        Try
            iRtn = loCls.CheckLimitCorrection(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return iRtn
    End Function

    Public Function GetOriginalAmount(poParam As MCT02000Back.MCT02000DTO) As Decimal Implements IMCT02000Service.GetOriginalAmount
        Dim nRtn As Decimal
        Dim loCls As New MCT02000Cls
        Dim loEx As New R_Exception

        Try
            nRtn = loCls.GetOriginalAmount(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return nRtn
    End Function


    Public Function getDownloadHeader(poParam As MCT02000Back.MCT02000DTO) As MCT02000Back.MCT02000DTO Implements IMCT02000Service.getDownloadHeader
        Dim loEx As New R_Exception
        Dim loCls As New MCT02000Cls
        Dim loRtn As New MCT02000DTO

        Try
            loRtn = loCls.getDownloadHeader(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

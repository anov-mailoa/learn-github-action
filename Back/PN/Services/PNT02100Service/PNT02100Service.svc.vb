Imports R_Common
Imports R_BackEnd
Imports PNT02100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT02100Service" in code, svc and config file together.
Public Class PNT02100Service
    Implements IPNT02100Service


    Public Sub Svc_R_Delete(poEntity As PNT02100Back.PNT02100DTO) Implements R_BackEnd.R_IServicebase(Of PNT02100Back.PNT02100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT02100Cls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT02100Back.PNT02100DTO) As PNT02100Back.PNT02100DTO Implements R_BackEnd.R_IServicebase(Of PNT02100Back.PNT02100DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PNT02100Cls
        Dim loRtn As PNT02100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT02100Back.PNT02100DTO, poCRUDMode As R_Common.eCRUDMode) As PNT02100Back.PNT02100DTO Implements R_BackEnd.R_IServicebase(Of PNT02100Back.PNT02100DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New PNT02100Cls
        Dim loRtn As PNT02100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As PNT02100Back.PNT02100DTO) As PNT02100Back.PNT02100DTO Implements IPNT02100Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loCls As New PNT02100Cls
        Dim loRtn As New PNT02100DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT02100Back.PNT02100DTO) As PNT02100Back.PNT02100DTO Implements IPNT02100Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT02100Cls
        Dim loRtn As New PNT02100DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String) Implements IPNT02100Service.chekStatusDelete
        Dim loException As New R_Exception
        Dim loCls As New PNT02100Cls

        Try
            loCls.chekStatusDelete(pcCompId, pcTransCode, pcDeptCode, pcRefNo, pcTransacStatus)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String) Implements IPNT02100Service.chekStatusEdit
        Dim loException As New R_Exception
        Dim loCls As New PNT02100Cls

        Try
            loCls.chekStatusEdit(pcCompId, pcTransCode, pcDeptCode, pcRefNo, pcTransacStatus)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function checkAllowedResources(poParam As PNT02100Back.PNT02100DTO) As Boolean Implements IPNT02100Service.checkAllowedResources
        Dim loException As New R_Exception
        Dim loCls As New PNT02100Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkAllowedResources(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function CekAttendance(poParam As PNT02100DTO) As Boolean Implements IPNT02100Service.CekAttendance
        Dim loEx As New R_Exception
        Dim loCls As New PNT02100Cls

        Dim loResult As Boolean

        Try
            loResult = loCls.CekAttendance(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loResult
    End Function

    Public Function CekLeave(poParam As PNT02100DTO) As Boolean Implements IPNT02100Service.CekLeave
        Dim loEx As New R_Exception
        Dim loCls As New PNT02100Cls

        Dim loResult As Boolean

        Try
            loResult = loCls.CekLeave(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loResult
    End Function

    Public Function CekLoan(poParam As PNT02100DTO) As Boolean Implements IPNT02100Service.CekLoan
        Dim loEx As New R_Exception
        Dim loCls As New PNT02100Cls

        Dim loResult As Boolean

        Try
            loResult = loCls.CekLoan(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loResult
    End Function

    Public Function CekMedical(poParam As PNT02100DTO) As Boolean Implements IPNT02100Service.CekMedical
        Dim loEx As New R_Exception
        Dim loCls As New PNT02100Cls

        Dim loResult As Boolean

        Try
            loResult = loCls.CekMedical(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loResult
    End Function

    Public Function CekPayroll(poParam As PNT02100DTO) As Boolean Implements IPNT02100Service.CekPayroll
        Dim loEx As New R_Exception
        Dim loCls As New PNT02100Cls

        Dim loResult As Boolean

        Try
            loResult = loCls.CekPayroll(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loResult
    End Function
End Class

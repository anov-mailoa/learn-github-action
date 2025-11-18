Imports R_Common
Imports PNT04100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT04100Service" in code, svc and config file together.
Public Class PNT04100Service
    Implements IPNT04100Service

    Public Sub Svc_R_Delete(poEntity As PNT04100Back.PNT04100DTO) Implements R_BackEnd.R_IServicebase(Of PNT04100Back.PNT04100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT04100Cls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT04100Back.PNT04100DTO) As PNT04100Back.PNT04100DTO Implements R_BackEnd.R_IServicebase(Of PNT04100Back.PNT04100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT04100Cls
        Dim loRtn As New PNT04100DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT04100Back.PNT04100DTO, poCRUDMode As R_Common.eCRUDMode) As PNT04100Back.PNT04100DTO Implements R_BackEnd.R_IServicebase(Of PNT04100Back.PNT04100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT04100Cls
        Dim loRtn As New PNT04100DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PNT04100Back.PNT04100DTO) As PNT04100Back.PNT04100DTO Implements IPNT04100Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT04100Cls
        Dim loRtn As New PNT04100DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT04100Back.PNT04100DTO) As PNT04100Back.PNT04100DTO Implements IPNT04100Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT04100Cls
        Dim loRtn As New PNT04100DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poCurrent As PNT04100Back.PNT04100DTO) As PNT04100Back.PNT04100DTO Implements IPNT04100Service.Reject
        Dim loEx As New R_Exception
        Dim loCls As New PNT04100Cls
        Dim loRtn As New PNT04100DTO

        Try
            loRtn = loCls.Reject(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function maxYearsContractValidate(poParam As PNT04100Back.PNT04100DTO) As Boolean Implements IPNT04100Service.maxYearsContractValidate
        Dim loEx As New R_Exception
        Dim loCls As New PNT04100Cls
        Dim loRtn As Boolean
        Try
            loRtn = loCls.maxYearsContractValidate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function maxYearsContractValidate1(poParam As PNT04100Back.PNT04100DTO) As Boolean Implements IPNT04100Service.maxYearsContractValidate1
        Dim loEx As New R_Exception
        Dim loCls As New PNT04100Cls
        Dim loRtn As Boolean
        Try
            loRtn = loCls.maxYearsContractValidate1(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getContractTimes(pcCompId As String, pcEmployeeId As String) As PNT04100Back.PNT04100DTO Implements IPNT04100Service.getContractTimes
        Dim loEx As New R_Exception
        Dim loCls As New PNT04100Cls
        Dim loRtn As PNT04100DTO
        Try
            loRtn = loCls.getContractTimes(pcCompId, pcEmployeeId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String) Implements IPNT04100Service.chekStatusDelete
        Dim loException As New R_Exception
        Dim loCls As New PNT04100Cls

        Try
            loCls.chekStatusDelete(pcCompId, pcTransCode, pcDeptCode, pcRefNo, pcTransacStatus)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String) Implements IPNT04100Service.chekStatusEdit
        Dim loException As New R_Exception
        Dim loCls As New PNT04100Cls

        Try
            loCls.chekStatusEdit(pcCompId, pcTransCode, pcDeptCode, pcRefNo, pcTransacStatus)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function checkInterface(pcCompanyId As String) As PNT04100Back.PNT04100DTO Implements IPNT04100Service.checkInterface
        Dim loEx As New R_Exception
        Dim loCls As New PNT04100Cls
        Dim loRtn As New PNT04100DTO

        Try
            loRtn = loCls.checkInterface(pcCompanyId)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

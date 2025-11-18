Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCT00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT00100Service" in code, svc and config file together.
Public Class MCT00100HdService
    Implements IMCT00100HdService

    Public Sub Svc_R_Delete(poEntity As MCT00100Back.MCT00100HdDTO) Implements R_BackEnd.R_IServicebase(Of MCT00100Back.MCT00100HdDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT00100Back.MCT00100HdDTO) As MCT00100Back.MCT00100HdDTO Implements R_BackEnd.R_IServicebase(Of MCT00100Back.MCT00100HdDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New MCT00100HdDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCT00100Back.MCT00100HdDTO, poCRUDMode As R_Common.eCRUDMode) As MCT00100Back.MCT00100HdDTO Implements R_BackEnd.R_IServicebase(Of MCT00100Back.MCT00100HdDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New MCT00100HdDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DisplayValidation(poParam As MCT00100Back.MCT00100HdDTO) As MCT00100Back.MCT00100HdDTO Implements IMCT00100HdService.DisplayValidation
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New MCT00100HdDTO

        Try
            loRtn = loCls.DisplayValidation(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLimitPolicyYear(poParam As MCT00100Back.MCT00100HdDTO) As MCT00100Back.MCT00100HdDTO Implements IMCT00100HdService.GetLimitPolicyYear
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New MCT00100HdDTO

        Try
            loRtn = loCls.GetLimitPolicyYear(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEmployeeInfo(poParam As MCT00100Back.MCT00100HdDTO) As MCT00100Back.MCT00100HdDTO Implements IMCT00100HdService.GetEmployeeInfo
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New MCT00100HdDTO

        Try
            loRtn = loCls.GetEmployeeInfo(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLimitPolicy(poParam As MCT00100Back.MCT00100HdDTO) As MCT00100Back.MCT00100HdDTO Implements IMCT00100HdService.GetLimitPolicy
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New MCT00100HdDTO

        Try
            loRtn = loCls.GetLimitPolicy(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMedicalRestriction(poParam As MCT00100Back.MCT00100HdDTO) As MCT00100Back.MCT00100HdDTO Implements IMCT00100HdService.GetMedicalRestriction
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New MCT00100HdDTO

        Try
            loRtn = loCls.GetMedicalRestriction(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ReDraftProcess(poParam As MCT00100Back.MCT00100HdDTO) As MCT00100Back.MCT00100HdDTO Implements IMCT00100HdService.ReDraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New MCT00100HdDTO

        Try
            loRtn = loCls.ReDraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As MCT00100Back.MCT00100HdDTO) As MCT00100Back.MCT00100HdDTO Implements IMCT00100HdService.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New MCT00100HdDTO

        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ValidatePayMethod(pcCompId As String, pcEmployeeId As String) As Integer Implements IMCT00100HdService.ValidatePayMethod
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As Integer

        Try
            loRtn = loCls.ValidatePayMethod(pcCompId, pcEmployeeId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLocalTypeCurrency(poParam As MCT00100Back.MCT00100HdDTO) As MCT00100Back.MCT00100HdDTO Implements IMCT00100HdService.GetLocalTypeCurrency
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New MCT00100HdDTO

        Try
            loRtn = loCls.GetLocalTypeCurrency(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCurrencyRate(poParam As MCT00100Back.MCT00100HdDTO) As Decimal Implements IMCT00100HdService.GetCurrencyRate
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackHDCLS
        Dim loRtn As New Decimal

        Try
            loRtn = loCls.GetCurrencyRate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
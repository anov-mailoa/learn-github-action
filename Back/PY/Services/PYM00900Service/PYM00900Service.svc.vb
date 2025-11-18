Imports R_Common
Imports PYM00900Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00900Service" in code, svc and config file together.
Public Class PYM00900Service
    Implements IPYM00900Service

#Region "PERIOD MANAGEMENT (INTERFACE PERIOD TAB)"
    Public Function getPymSalaryGroupHd(ByVal poEntity As PYM00900Back.PYM00900DTO) As PYM00900Back.PYM00900DTO Implements IPYM00900Service.getPymSalaryGroupHd
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As New PYM00900DTO

        Try
            loRtn = loCls.getPymSalaryGroupHd(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

    Public Sub Svc_R_Delete(ByVal poEntity As PYM00900Back.PYM00900DTO) Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As PYM00900Back.PYM00900DTO) As PYM00900Back.PYM00900DTO Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As PYM00900DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(ByVal poEntity As PYM00900Back.PYM00900DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As PYM00900Back.PYM00900DTO Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As PYM00900DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkExistPeriods(ByVal poParam As PYM00900Back.PYM00900DTO) As Integer Implements IPYM00900Service.checkExistPeriods
        Dim loException As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.checkExistPeriods(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub UpdateActive(ByVal poParam As PYM00900Back.PYM00900DTO) Implements IPYM00900Service.UpdateActive
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls

        Try
            loCls.UpdateActive(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub cloneSaving(ByVal poParam As PYM00900Back.PYM00900DTO) Implements IPYM00900Service.cloneSaving
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls

        Try
            loCls.cloneSaving(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GeneratePeriod(ByVal poParam As PYM00900Back.PYM00900DTO) As Boolean Implements IPYM00900Service.GeneratePeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.GeneratePeriod(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkPymSalaryGroupDt(ByVal poEntity As PYM00900Back.PYM00900DTO) As PYM00900Back.PYM00900DTO Implements IPYM00900Service.checkPymSalaryGroupDt
        Dim loException As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As PYM00900DTO

        Try
            loRtn = loCls.checkPymSalaryGroupDt(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub UndoPeriod(ByVal poParam As PYM00900Back.PYM00900DTO) Implements IPYM00900Service.UndoPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls

        Try
            loCls.UndoPeriod(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function ValidasiUndoPeriod(ByVal poParam As PYM00900Back.PYM00900DTO) As Integer Implements IPYM00900Service.ValidasiUndoPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.ValidasiUndoPeriod(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDefaultValueGeneratePeriod(ByVal poParam As PYM00900Back.PYM00900DTO) As PYM00900Back.PYM00900DTO Implements IPYM00900Service.getDefaultValueGeneratePeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As New PYM00900DTO

        Try
            loRtn = loCls.getDefaultValueGeneratePeriod(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckPeriodicSalaryProcess(poParam As PYM00900Back.PYM00900DTO) As Integer Implements IPYM00900Service.CheckPeriodicSalaryProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.CheckPeriodicSalaryProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ValidationEnabledDelete(poParam As PYM00900Back.PYM00900DTO) As Integer Implements IPYM00900Service.ValidationEnabledDelete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.ValidationEnabledDelete(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub checkSyntax(poParam As PYM00900Back.PYM00900DTO) Implements IPYM00900Service.checkSyntax
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As New PYM00900DTO

        Try
            loCls.checkSyntax(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub GenerateProcess(poEntity As PYM00900Back.PYM00900DTO) Implements IPYM00900Service.GenerateProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls

        Try
            loCls.GenerateProcess(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function CheckPeriodExist(poEntity As PYM00900Back.PYM00900DTO) As Boolean Implements IPYM00900Service.CheckPeriodExist
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.CheckPeriodExist(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function updateBackdateInterface(poParam As PYM00900Back.PYM00900DTO) As PYM00900Back.PYM00900DTO Implements IPYM00900Service.updateBackdateInterface
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtn As New PYM00900DTO

        Try
            loRtn = loCls.updateBackdateInterface(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

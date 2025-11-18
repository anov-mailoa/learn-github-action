Imports R_Common
Imports PYT00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00100Service" in code, svc and config file together.
Public Class PYT00100Service
    Implements IPYT00100Service

    Public Sub Svc_R_Delete(poEntity As PYT00100Back.PYT00100DTO) Implements R_BackEnd.R_IServicebase(Of PYT00100Back.PYT00100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT00100Back.PYT00100DTO) As PYT00100Back.PYT00100DTO Implements R_BackEnd.R_IServicebase(Of PYT00100Back.PYT00100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim loRtn As PYT00100DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT00100Back.PYT00100DTO, poCRUDMode As R_Common.eCRUDMode) As PYT00100Back.PYT00100DTO Implements R_BackEnd.R_IServicebase(Of PYT00100Back.PYT00100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim loRtn As PYT00100DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function getPytTransactionHd(poParam As PYT00100Back.PYT00100DTO) As System.Collections.Generic.List(Of PYT00100Back.PYT00100DTO) Implements IPYT00100Service.getPytTransactionHd
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00100Cls
    '    Dim loRtn As List(Of PYT00100DTO) = Nothing

    '    Try
    '        loRtn = loCls.getPytTransactionHd(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function getEmpStatus(poParam As PYT00100Back.PYT00100DTO) As PYT00100Back.PYT00100DTO Implements IPYT00100Service.getEmpStatus
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00100Cls
    '    Dim loRtn As PYT00100DTO

    '    Try
    '        loRtn = loCls.getEmpStatus(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function getSalaryGroupStatus(poParam As PYT00100Back.PYT00100DTO) As PYT00100Back.PYT00100DTO Implements IPYT00100Service.getSalaryGroupStatus
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00100Cls
    '    Dim loRtn As PYT00100DTO

    '    Try
    '        loRtn = loCls.getSalaryGroupStatus(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function cekTransactionPeriod(poParam As PYT00100Back.PYT00100DTO) As PYT00100Back.PYT00100DTO Implements IPYT00100Service.cekTransactionPeriod
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00100Cls
    '    Dim loRtn As PYT00100DTO

    '    Try
    '        loRtn = loCls.cekTransactionPeriod(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function cekTransActivePeriod(poParam As PYT00100Back.PYT00100DTO) As PYT00100Back.PYT00100DTO Implements IPYT00100Service.cekTransActivePeriod
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00100Cls
    '    Dim loRtn As PYT00100DTO

    '    Try
    '        loRtn = loCls.cekTransActivePeriod(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function DraftOpenProcess(poParam As PYT00100Back.PYT00100DTO) As PYT00100Back.PYT00100DTO Implements IPYT00100Service.DraftOpenProcess
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00100Cls
    '    Dim loRtn As PYT00100DTO

    '    Try
    '        loRtn = loCls.DraftOpenProcess(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function getCmbCurrencyRateType(poParam As PYT00100Back.PYT00100DTO) As System.Collections.Generic.List(Of PYT00100Back.PYT00100CmbDTO) Implements IPYT00100Service.getCmbCurrencyRateType
        Dim loException As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim loRtn As List(Of PYT00100CmbDTO) = Nothing

        Try
            loRtn = loCls.getCmbCurrencyRateType(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function UpdatePytTransDt(poParam As PYT00100Back.PYT00100DTO) As Boolean Implements IPYT00100Service.UpdatePytTransDt
        'Dim loException As New R_Exception
        'Dim loCls As New PYT00100Cls
        'Dim loRtn As Boolean

        'Try
        '    loRtn = loCls.UpdatePytTransDt(poParam)
        'Catch ex As Exception
        '    loException.Add(ex)
        'End Try

        'loException.ConvertAndThrowToServiceExceptionIfErrors()

        'Return loRtn
    End Function

    'Public Function CheckTransactionProcess(poParam As PYT00100Back.PYT00100DTO) As Boolean Implements IPYT00100Service.CheckTransactionProcess
    '    Dim loException As New R_Exception
    '    Dim loCls As New PYT00100Cls
    '    Dim loRtn As Boolean

    '    Try
    '        loRtn = loCls.CheckTransactionProcess(poParam)
    '    Catch ex As Exception
    '        loException.Add(ex)
    '    End Try

    '    loException.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function DraftProcess(poParam As PYT00100Back.PYT00100DTO) As PYT00100Back.PYT00100DTO Implements IPYT00100Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim loRtn As PYT00100DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function OpenProcess(poParam As PYT00100Back.PYT00100DTO) As PYT00100Back.PYT00100DTO Implements IPYT00100Service.OpenProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim loRtn As PYT00100DTO
        Try
            loRtn = loCls.OpenProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function LostFocusEmployeeId(poParam As PYT00100Back.PYT00100DTO) As PYT00100Back.PYT00100DTO Implements IPYT00100Service.LostFocusEmployeeId
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim loRtn As New PYT00100DTO

        Try
            loRtn = loCls.LostFocusEmployeeId(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function validateBySubGrade(poParam As PYT00100Back.PYT00100DTO) As Boolean Implements IPYT00100Service.validateBySubGrade
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim llRtn As Boolean
        Try
            llRtn = loCls.validateBySubGrade(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return llRtn
    End Function

    Public Function cekSalaryEffectiveDate(poParam As PYT00100Back.PYT00100DTO) As String Implements IPYT00100Service.cekSalaryEffectiveDate
        Dim loEx As New R_Exception
        Dim loCls As New PYT00100Cls
        Dim lcRtn As String = ""
        Try
            lcRtn = loCls.cekSalaryEffectiveDate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function
End Class

Imports R_Common
Imports ATM00100Back
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00100Service" in code, svc and config file together.
Public Class ATM00100Service
    Implements IATM00100Service

    Public Sub Svc_R_Delete(poEntity As ATM00100Back.ATM00100DTO) Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00100DTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New ATM00100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00100Back.ATM00100DTO) As ATM00100Back.ATM00100DTO Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00100DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ATM00100Cls
        Dim loRtn As ATM00100DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00100Back.ATM00100DTO, poCRUDMode As R_Common.eCRUDMode) As ATM00100Back.ATM00100DTO Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00100DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New ATM00100Cls
        Dim loRtn As ATM00100DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function validationMaxBreakTimes(poParam As ATM00100Back.ATM00100DTO) As Boolean Implements IATM00100Service.validationMaxBreakTimes
        Dim loException As New R_Exception
        Dim loCls As New ATM00100Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.validationMaxBreakTimes(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function CheckWorkGroup(pcCompId As Object) As Boolean Implements IATM00100Service.CheckWorkGroup
        Dim loException As New R_Exception
        Dim loCls As New ATM00100Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.CheckWorkGroup(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class






'Public Sub Svc_R_Delete(poEntity As ATM00100Back.ATM00100DTO) Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00100DTO).Svc_R_Delete
'    Dim loException As New R_Exception
'    Dim loCls As New ATM00100Cls

'    Try
'        loCls.R_Delete(poEntity)
'    Catch ex As Exception
'        loException.Add(ex)
'    End Try

'    loException.ConvertAndThrowToServiceExceptionIfErrors()
'End Sub

'Public Function Svc_R_GetRecord(poEntity As ATM00100Back.ATM00100DTO) As ATM00100Back.ATM00100DTO Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00100DTO).Svc_R_GetRecord
'    Dim loException As New R_Exception
'    Dim loCls As New ATM00100Cls
'    Dim loRtn As ATM00100DTO = Nothing

'    Try
'        loRtn = loCls.R_GetRecord(poEntity)
'    Catch ex As Exception
'        loException.Add(ex)
'    End Try

'    loException.ConvertAndThrowToServiceExceptionIfErrors()

'    Return loRtn
'End Function

'Public Function Svc_R_Save(poEntity As ATM00100Back.ATM00100DTO, poCRUDMode As R_Common.eCRUDMode) As ATM00100Back.ATM00100DTO Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00100DTO).Svc_R_Save
'    Dim loException As New R_Exception
'    Dim loCls As New ATM00100Cls
'    Dim loRtn As ATM00100DTO = Nothing

'    Try
'        loRtn = loCls.R_Save(poEntity, poCRUDMode)
'    Catch ex As Exception
'        loException.Add(ex)
'    End Try

'    loException.ConvertAndThrowToServiceExceptionIfErrors()

'    Return loRtn
'End Function

'Public Function getAttStatus(poParam As SIAPP_PUB_DTO.ParameterDTO) As System.Collections.Generic.List(Of ATM00100DTO) Implements IATM00100Service.getAttStatus
'    Dim loException As New R_Exception
'    Dim loCls As New ATM00100Cls
'    Dim loRtn As New List(Of ATM00100DTO)

'    Try
'        loRtn = loCls.getAttStatus(poParam)
'    Catch ex As Exception
'        loException.Add(ex)
'    End Try

'    loException.ConvertAndThrowToServiceExceptionIfErrors()

'    Return loRtn
'End Function

'Public Function getRBModeDescription(poParam As SIAPP_PUB_DTO.ParameterDTO) As System.Collections.Generic.List(Of ATM00100DTO) Implements IATM00100Service.getRBModeDescription
'    Dim loException As New R_Exception
'    Dim loCls As New ATM00100Cls
'    Dim loRtn As New List(Of ATM00100DTO)

'    Try
'        loRtn = loCls.getRBModeDescription(poParam)
'    Catch ex As Exception
'        loException.Add(ex)
'    End Try

'    loException.ConvertAndThrowToServiceExceptionIfErrors()

'    Return loRtn
'End Function

'Public Function getRBTypeDescription(poParam As SIAPP_PUB_DTO.ParameterDTO) As System.Collections.Generic.List(Of ATM00100DTO) Implements IATM00100Service.getRBTypeDescription
'    Dim loException As New R_Exception
'    Dim loCls As New ATM00100Cls
'    Dim loRtn As New List(Of ATM00100DTO)

'    Try
'        loRtn = loCls.getRBTypeDescription(poParam)
'    Catch ex As Exception
'        loException.Add(ex)
'    End Try

'    loException.ConvertAndThrowToServiceExceptionIfErrors()

'    Return loRtn
'End Function

'Public Function getTransactionMethod(poParam As SIAPP_PUB_DTO.ParameterDTO) As System.Collections.Generic.List(Of ATM00100DTO) Implements IATM00100Service.getTransactionMethod
'    Dim loException As New R_Exception
'    Dim loCls As New ATM00100Cls
'    Dim loRtn As New List(Of ATM00100DTO)

'    Try
'        loRtn = loCls.getTransactionMethod(poParam)
'    Catch ex As Exception
'        loException.Add(ex)
'    End Try

'    loException.ConvertAndThrowToServiceExceptionIfErrors()

'    Return loRtn
'End Function


'Public Function validationMaxBreakTimes(poParam As ATM00100Back.ATM00100DTO) As Boolean Implements IATM00100Service.validationMaxBreakTimes
'    Dim loException As New R_Exception
'    Dim loCls As New ATM00100Cls
'    Dim loRtn As Boolean

'    Try
'        loRtn = loCls.validationMaxBreakTimes(poParam)
'    Catch ex As Exception
'        loException.Add(ex)
'    End Try

'    loException.ConvertAndThrowToServiceExceptionIfErrors()
'    Return loRtn
'End Function
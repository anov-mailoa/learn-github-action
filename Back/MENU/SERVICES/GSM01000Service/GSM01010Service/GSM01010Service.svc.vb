Imports R_Common
Imports GSM01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01010Service" in code, svc and config file together.
Public Class GSM01010Service
    Implements IGSM01010Service

    Public Sub Svc_R_Delete(poEntity As GSM01000Back.GSM01010DTO) Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01010DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM01010Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM01000Back.GSM01010DTO) As GSM01000Back.GSM01010DTO Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01010DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM01010Cls
        Dim loRtn As GSM01010DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM01000Back.GSM01010DTO, poCRUDMode As R_Common.eCRUDMode) As GSM01000Back.GSM01010DTO Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01010DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM01010Cls
        Dim loRtn As GSM01010DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbDeptCode(poParam As GSM01000Back.GSM01010DTO) As System.Collections.Generic.List(Of GSM01000Back.GSM01010CmbDTO) Implements IGSM01010Service.getCmbDeptCode
        Dim loException As New R_Exception
        Dim loCls As New GSM01010Cls
        Dim loRtn As List(Of GSM01010CmbDTO)

        Try
            loRtn = loCls.getCmbDeptCode(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbPeriodNo(poParam As GSM01000Back.GSM01010DTO) As System.Collections.Generic.List(Of GSM01000Back.GSM01010CmbDTO) Implements IGSM01010Service.getCmbPeriodNo
        Dim loException As New R_Exception
        Dim loCls As New GSM01010Cls
        Dim loRtn As List(Of GSM01010CmbDTO)

        Try
            loRtn = loCls.getCmbPeriodNo(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekDeptMode(poParam As GSM01000Back.GSM01010DTO) As Boolean Implements IGSM01010Service.cekDeptMode
        Dim loException As New R_Exception
        Dim loCls As New GSM01010Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.cekDeptMode(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekPeriodNo(poParam As GSM01000Back.GSM01010DTO) As Boolean Implements IGSM01010Service.cekPeriodNo
        Dim loException As New R_Exception
        Dim loCls As New GSM01010Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.cekPeriodNo(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekTransCode(poParam As GSM01000Back.GSM01010DTO) As Boolean Implements IGSM01010Service.cekTransCode
        Dim loException As New R_Exception
        Dim loCls As New GSM01010Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.cekTransCode(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

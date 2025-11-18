Imports R_Common
Imports ATM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00110Service" in code, svc and config file together.
Public Class ATM00110Service
    Implements IATM00110Service

    Public Sub Svc_R_Delete(poEntity As ATM00100Back.ATM00110DTO) Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00110DTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New ATM00110Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00100Back.ATM00110DTO) As ATM00100Back.ATM00110DTO Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00110DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ATM00110Cls
        Dim loRtn As ATM00110DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00100Back.ATM00110DTO, poCRUDMode As R_Common.eCRUDMode) As ATM00100Back.ATM00110DTO Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00110DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New ATM00110Cls
        Dim loRtn As ATM00110DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCheckATM0110(poEntity As ATM00100Back.ATM00110DTO) As ATM00100Back.ATM00110DTO Implements IATM00110Service.getCheckATM0110
        Dim loException As New R_Exception
        Dim loCls As New ATM00110Cls
        Dim loRtn As ATM00110DTO = Nothing

        Try
            loRtn = loCls.getCheckATM0110(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSystemParam(poEntity As ATM00100Back.ATM00110DTO) As ATM00100Back.ATM00110DTO Implements IATM00110Service.getSystemParam
        Dim loException As New R_Exception
        Dim loCls As New ATM00110Cls
        Dim loRtn As ATM00110DTO = Nothing

        Try
            loRtn = loCls.getSystemParam(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getFieldsSetupPosition(poParam As ATM00100Back.ATM00110DTO) As System.Collections.Generic.List(Of ATM00100Back.ATM00110DTO) Implements IATM00110Service.getFieldsSetupPosition
        Dim loException As New R_Exception
        Dim loCls As New ATM00110Cls
        Dim loRtn As List(Of ATM00110DTO) = Nothing

        Try
            loRtn = loCls.getFieldsSetupPosition(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkSyntax(poParam As ATM00100Back.ATM00110DTO) As Boolean Implements IATM00110Service.checkSyntax
        Dim loException As New R_Exception
        Dim loCls As New ATM00110Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkSyntax(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkPath(poParam As ATM00100Back.ATM00110DTO) As System.Collections.Generic.List(Of ATM00100Back.ATM00110DTO) Implements IATM00110Service.checkPath
        Dim loException As New R_Exception
        Dim loCls As New ATM00110Cls
        Dim loRtn As List(Of ATM00110DTO)

        Try
            loRtn = loCls.checkPath(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

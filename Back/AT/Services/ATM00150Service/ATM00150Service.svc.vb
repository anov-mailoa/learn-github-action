Imports R_Common
Imports ATM00150Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00150Service" in code, svc and config file together.
Public Class ATM00150Service
    Implements IATM00150Service

    Public Sub Svc_R_Delete(poEntity As ATM00150Back.ATM00150DTO) Implements R_BackEnd.R_IServicebase(Of ATM00150Back.ATM00150DTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New ATM00150CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00150Back.ATM00150DTO) As ATM00150Back.ATM00150DTO Implements R_BackEnd.R_IServicebase(Of ATM00150Back.ATM00150DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ATM00150CLS
        Dim loRtn As ATM00150DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00150Back.ATM00150DTO, poCRUDMode As R_Common.eCRUDMode) As ATM00150Back.ATM00150DTO Implements R_BackEnd.R_IServicebase(Of ATM00150Back.ATM00150DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New ATM00150CLS
        Dim loRtn As ATM00150DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkPath(poParam As ATM00150Back.ATM00150DTO) As System.Collections.Generic.List(Of ATM00150Back.ATM00150DTO) Implements IATM00150Service.checkPath
        Dim loException As New R_Exception
        Dim loCls As New ATM00150CLS
        Dim loRtn As List(Of ATM00150DTO)

        Try
            loRtn = loCls.checkPath(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkSyntax(poParam As ATM00150Back.ATM00150DTO) As Boolean Implements IATM00150Service.checkSyntax
        Dim loException As New R_Exception
        Dim loCls As New ATM00150CLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkSyntax(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCheckATM0150(poEntity As ATM00150Back.ATM00150DTO) As ATM00150Back.ATM00150DTO Implements IATM00150Service.getCheckATM0150
        Dim loException As New R_Exception
        Dim loCls As New ATM00150CLS
        Dim loRtn As ATM00150DTO = Nothing

        Try
            loRtn = loCls.getCheckATM0150(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getFieldsSetupPosition(poParam As ATM00150Back.ATM00150DTO) As System.Collections.Generic.List(Of ATM00150Back.ATM00150DTO) Implements IATM00150Service.getFieldsSetupPosition
        Dim loException As New R_Exception
        Dim loCls As New ATM00150CLS
        Dim loRtn As List(Of ATM00150DTO) = Nothing

        Try
            loRtn = loCls.getFieldsSetupPosition(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSystemParam(poEntity As ATM00150Back.ATM00150DTO) As ATM00150Back.ATM00150DTO Implements IATM00150Service.getSystemParam
        Dim loException As New R_Exception
        Dim loCls As New ATM00150CLS
        Dim loRtn As ATM00150DTO = Nothing

        Try
            loRtn = loCls.getSystemParam(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function activation(poEntity As ATM00150Back.ATM00150DTO) As ATM00150Back.ATM00150DTO Implements IATM00150Service.activation
        Dim loException As New R_Exception
        Dim loCls As New ATM00150CLS
        Dim loRtn As ATM00150DTO = Nothing

        Try
            loRtn = loCls.activation(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

Imports R_Common
Imports ATM00150Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00150DetailService" in code, svc and config file together.
Public Class ATM00150DetailService
    Implements IATM00150DetailService

    Public Sub Svc_R_Delete(poEntity As ATM00150Back.ATM00150DetailDTO) Implements R_BackEnd.R_IServicebase(Of ATM00150Back.ATM00150DetailDTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New ATM00150DetailCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00150Back.ATM00150DetailDTO) As ATM00150Back.ATM00150DetailDTO Implements R_BackEnd.R_IServicebase(Of ATM00150Back.ATM00150DetailDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ATM00150DetailCLS
        Dim loRtn As ATM00150DetailDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00150Back.ATM00150DetailDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00150Back.ATM00150DetailDTO Implements R_BackEnd.R_IServicebase(Of ATM00150Back.ATM00150DetailDTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New ATM00150DetailCLS
        Dim loRtn As ATM00150DetailDTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCheckATM0150Detail(poEntity As ATM00150Back.ATM00150DetailDTO) As ATM00150Back.ATM00150DetailDTO Implements IATM00150DetailService.getCheckATM0150Detail
        Dim loException As New R_Exception
        Dim loCls As New ATM00150DetailCLS
        Dim loRtn As ATM00150DetailDTO = Nothing

        Try
            loRtn = loCls.getCheckATM0150Detail(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

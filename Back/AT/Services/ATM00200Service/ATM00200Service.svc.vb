Imports R_Common
Imports ATM00200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00200Service" in code, svc and config file together.
Public Class ATM00200Service
    Implements IATM00200Service

    Public Sub Svc_R_Delete(poEntity As ATM00200Back.ATM00200DTO) Implements R_BackEnd.R_IServicebase(Of ATM00200Back.ATM00200DTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New ATM00200Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00200Back.ATM00200DTO) As ATM00200Back.ATM00200DTO Implements R_BackEnd.R_IServicebase(Of ATM00200Back.ATM00200DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ATM00200Cls
        Dim loRtn As ATM00200DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00200Back.ATM00200DTO, poCRUDMode As R_Common.eCRUDMode) As ATM00200Back.ATM00200DTO Implements R_BackEnd.R_IServicebase(Of ATM00200Back.ATM00200DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New ATM00200Cls
        Dim loRtn As ATM00200DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkATM00200List(poEntity As ATM00200Back.ATM00200DTO) As System.Collections.Generic.List(Of ATM00200Back.ATM00200DTO) Implements IATM00200Service.checkATM00200List
        'Dim loException As New R_Exception
        'Dim loCls As New ATM00200Cls
        'Dim loRtn As New List(Of ATM00200DTO)

        'Try
        '    loRtn = loCls.checkATM00200List(poEntity)
        'Catch ex As Exception
        '    loException.Add(ex)
        'End Try

        'loException.ConvertAndThrowToServiceExceptionIfErrors()

        'Return loRtn
    End Function

    Public Function checkSyntax(poEntity As ATM00200Back.ATM00200DTO) As Boolean Implements IATM00200Service.checkSyntax
        Dim loException As New R_Exception
        Dim loCls As New ATM00200Cls
        Dim loRtn As New Boolean

        Try
            loRtn = loCls.checkSyntax(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ProcessSequenceCheck(poParam As ATM00200Back.ATM00200DTO) As Integer Implements IATM00200Service.ProcessSequenceCheck
        Dim loEx As New R_Exception
        Dim loCls As New ATM00200Cls
        Dim liRtn As New Integer
        Try
            liRtn = loCls.ProcessSequenceCheck(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return liRtn
    End Function

    Public Function GetExitPermit(poEntity As ATM00200Back.ATM00200DTO) As ATM00200Back.ATM00200DTO Implements IATM00200Service.GetExitPermit
        Dim loException As New R_Exception
        Dim loCls As New ATM00200Cls
        Dim loRtn As ATM00200DTO = Nothing
        Try
            loRtn = loCls.GetExitPermit(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub UpdateExitPermit(poEntity As ATM00200Back.ATM00200DTO) Implements IATM00200Service.UpdateExitPermit
        Dim loException As New R_Exception
        Dim loCls As New ATM00200Cls
        Dim loRtn As ATM00200DTO = Nothing
        Try
            loCls.UpdateExitPermit(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

Imports R_Common
Imports ATM00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00110DetailService" in code, svc and config file together.
Public Class ATM00110DetailService
    Implements IATM00110DetailService
    'biar bisa commit
    Public Sub Svc_R_Delete(poEntity As ATM00100Back.ATM00110DetailDTO) Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00110DetailDTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New ATM00110DetailCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00100Back.ATM00110DetailDTO) As ATM00100Back.ATM00110DetailDTO Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00110DetailDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ATM00110DetailCls
        Dim loRtn As ATM00110DetailDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00100Back.ATM00110DetailDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00100Back.ATM00110DetailDTO Implements R_BackEnd.R_IServicebase(Of ATM00100Back.ATM00110DetailDTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New ATM00110DetailCls
        Dim loRtn As ATM00110DetailDTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCheckATM0110Detail(poEntity As ATM00100Back.ATM00110DetailDTO) As ATM00100Back.ATM00110DetailDTO Implements IATM00110DetailService.getCheckATM0110Detail
        Dim loException As New R_Exception
        Dim loCls As New ATM00110DetailCls
        Dim loRtn As ATM00110DetailDTO = Nothing

        Try
            loRtn = loCls.getCheckATM0110Detail(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

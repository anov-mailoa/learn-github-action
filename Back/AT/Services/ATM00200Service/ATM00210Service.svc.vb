Imports R_Common
Imports ATM00200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00210Service" in code, svc and config file together.
Public Class ATM00210Service
    Implements IATM00210Service

    Public Sub Svc_R_Delete(poEntity As ATM00200Back.ATM00210DTO) Implements R_BackEnd.R_IServicebase(Of ATM00200Back.ATM00210DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00200Back.ATM00210DTO) As ATM00200Back.ATM00210DTO Implements R_BackEnd.R_IServicebase(Of ATM00200Back.ATM00210DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ATM00210Cls
        Dim loRtn As ATM00210DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00200Back.ATM00210DTO, poCRUDMode As R_Common.eCRUDMode) As ATM00200Back.ATM00210DTO Implements R_BackEnd.R_IServicebase(Of ATM00200Back.ATM00210DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New ATM00210Cls
        Dim loRtn As ATM00210DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

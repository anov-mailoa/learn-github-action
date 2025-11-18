Imports R_Common
Imports PYM01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01000Service" in code, svc and config file together.
Public Class PYM01000Service
    Implements IPYM01000Service

    Public Sub Svc_R_Delete(poEntity As PYM01000Back.PYM01000DTO) Implements R_BackEnd.R_IServicebase(Of PYM01000Back.PYM01000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM01000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM01000Back.PYM01000DTO) As PYM01000Back.PYM01000DTO Implements R_BackEnd.R_IServicebase(Of PYM01000Back.PYM01000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM01000Cls
        Dim loRtn As PYM01000DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM01000Back.PYM01000DTO, poCRUDMode As R_Common.eCRUDMode) As PYM01000Back.PYM01000DTO Implements R_BackEnd.R_IServicebase(Of PYM01000Back.PYM01000DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New PYM01000Cls
        Dim loRtn As PYM01000DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

Imports R_Common
Imports PYM01400Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01400Service" in code, svc and config file together.
Public Class PYT01400Service
    Implements IPYT01400Service

    Public Function Svc_R_GetRecord1(poEntity As PYM01400Back.PYT01400Dto) As PYM01400Back.PYT01400Dto Implements R_BackEnd.R_IServicebase(Of PYM01400Back.PYT01400Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT01400Cls
        Dim loRtn As PYT01400Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save1(poEntity As PYM01400Back.PYT01400Dto, poCRUDMode As R_Common.eCRUDMode) As PYM01400Back.PYT01400Dto Implements R_BackEnd.R_IServicebase(Of PYM01400Back.PYT01400Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT01400Cls
        Dim loRtn As PYT01400Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Svc_R_Delete(poEntity As PYM01400Back.PYT01400Dto) Implements R_BackEnd.R_IServicebase(Of PYM01400Back.PYT01400Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYT01400Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class

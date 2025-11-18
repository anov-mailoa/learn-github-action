' NOTE: You can use the "Rename" command on the context menu to change the class name "PQM00400Service" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select PQM00400Service.svc or PQM00400Service.svc.vb at the Solution Explorer and start debugging.
Imports PQM00400Back
Imports R_BackEnd
Imports R_Common
Imports REALTA_SERVICES

Public Class PQM00400Service
    Implements IPQM00400Service

    Public Sub Svc_R_Delete(poEntity As PQM00400Dto) Implements R_IServicebase(Of PQM00400Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PQM00400Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PQM00400Dto) As PQM00400Dto Implements R_IServicebase(Of PQM00400Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PQM00400Cls
        Dim loRtn As PQM00400Dto = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PQM00400Dto, poCRUDMode As eCRUDMode) As PQM00400Dto Implements R_IServicebase(Of PQM00400Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PQM00400Cls
        Dim loRtn As PQM00400Dto = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ValidateService(poParam As PQM00400Dto) As PQM00400Dto Implements IPQM00400Service.ValidateService
        Dim loEx As New R_Exception
        Dim loCls As New PQM00400Cls
        Dim loRtn As PQM00400Dto = Nothing

        Try
            loRtn = loCls.ValidateService(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

' NOTE: You can use the "Rename" command on the context menu to change the class name "PQM00100Service" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select PQM00100Service.svc or PQM00100Service.svc.vb at the Solution Explorer and start debugging.
Imports PQM00100Back
Imports R_BackEnd
Imports R_Common

Public Class PQM00100Service
    Implements IPQM00100Service

    Public Sub Svc_R_Delete(poEntity As PQM00100Dto) Implements R_IServicebase(Of PQM00100Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PQM00100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PQM00100Dto) As PQM00100Dto Implements R_IServicebase(Of PQM00100Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PQM00100Cls
        Dim loRtn As PQM00100Dto = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PQM00100Dto, poCRUDMode As eCRUDMode) As PQM00100Dto Implements R_IServicebase(Of PQM00100Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PQM00100Cls
        Dim loRtn As PQM00100Dto = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

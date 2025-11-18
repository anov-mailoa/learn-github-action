' NOTE: You can use the "Rename" command on the context menu to change the class name "PQM00300Service" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select PQM00300Service.svc or PQM00300Service.svc.vb at the Solution Explorer and start debugging.
Imports PQM00300Back
Imports R_BackEnd
Imports R_Common

Public Class PQM00300Service
    Implements IPQM00300Service

    Public Sub Svc_R_Delete(poEntity As PQM00300Dto) Implements R_IServicebase(Of PQM00300Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PQM00300Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PQM00300Dto) As PQM00300Dto Implements R_IServicebase(Of PQM00300Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PQM00300Cls
        Dim loRtn As PQM00300Dto = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PQM00300Dto, poCRUDMode As eCRUDMode) As PQM00300Dto Implements R_IServicebase(Of PQM00300Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PQM00300Cls
        Dim loRtn As PQM00300Dto = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

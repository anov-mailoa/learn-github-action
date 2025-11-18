Imports R_Common
Imports SAM00100Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM0100Service" in code, svc and config file together.
Public Class SAM00100Service
    Implements ISAM00100Service

    Public Sub Svc_R_Delete(poEntity As SAM00100Back.SAM00100DTO) Implements R_BackEnd.R_IServicebase(Of SAM00100Back.SAM00100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New SAM00100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As SAM00100Back.SAM00100DTO) As SAM00100Back.SAM00100DTO Implements R_BackEnd.R_IServicebase(Of SAM00100Back.SAM00100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New SAM00100Cls
        Dim loRtn As SAM00100DTO = Nothing

        Try

            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As SAM00100Back.SAM00100DTO, poCRUDMode As R_Common.eCRUDMode) As SAM00100Back.SAM00100DTO Implements R_BackEnd.R_IServicebase(Of SAM00100Back.SAM00100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New SAM00100Cls
        Dim loRtn As SAM00100DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkCurr(pcCurrCode As String) As Boolean Implements ISAM00100Service.checkCurr
        Dim loEx As New R_Exception
        Dim loCls As New SAM00100Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkCurr(pcCurrCode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkDel(pcCurrCode As String) As Boolean Implements ISAM00100Service.checkDel
        Dim loEx As New R_Exception
        Dim loCls As New SAM00100Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkDel(pcCurrCode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

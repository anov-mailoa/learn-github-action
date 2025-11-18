Imports R_BackEnd
Imports R_Common
Imports PNT03100Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03100Service" in code, svc and config file together.
Public Class PNT03100Service
    Implements IPNT03100Service

    Public Sub Svc_R_Delete(poEntity As PNT03100Back.PNT03100DTO) Implements R_BackEnd.R_IServicebase(Of PNT03100Back.PNT03100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03100Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT03100Back.PNT03100DTO) As PNT03100Back.PNT03100DTO Implements R_BackEnd.R_IServicebase(Of PNT03100Back.PNT03100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT03100Cls
        Dim loRtn As PNT03100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT03100Back.PNT03100DTO, poCRUDMode As R_Common.eCRUDMode) As PNT03100Back.PNT03100DTO Implements R_BackEnd.R_IServicebase(Of PNT03100Back.PNT03100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT03100Cls
        Dim loRtn As PNT03100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As PNT03100Back.PNT03100DTO) As PNT03100Back.PNT03100DTO Implements IPNT03100Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loRtn As PNT03100DTO = Nothing

        Try
            loRtn = New PNT03100Cls().DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As PNT03100Back.PNT03100DTO) As PNT03100Back.PNT03100DTO Implements IPNT03100Service.Submit
        Dim loEx As New R_Exception
        Dim loRtn As PNT03100DTO = Nothing

        Try
            loRtn = New PNT03100Cls().Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poParam As PNT03100Back.PNT03100DTO) As PNT03100Back.PNT03100DTO Implements IPNT03100Service.Reject
        Dim loEx As New R_Exception
        Dim loRtn As PNT03100DTO = Nothing

        Try
            loRtn = New PNT03100Cls().Reject(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkActiveLoanTrx(poParam As PNT03100Back.PNT03100DTO) As String Implements IPNT03100Service.checkActiveLoanTrx
        Dim loEx As New R_Exception
        Dim loCls As New PNT03100Cls
        Dim lcRtn As String = ""
        Try
            lcRtn = loCls.checkActiveLoanTrx(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function
End Class

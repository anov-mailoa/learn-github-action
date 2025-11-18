Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT05100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT05100Service" in code, svc and config file together.
Public Class PNT05100Service
    Implements IPNT05100Service

    Public Sub Svc_R_Delete(poEntity As PNT05100Back.PNT05100DTO) Implements R_BackEnd.R_IServicebase(Of PNT05100Back.PNT05100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT05100Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT05100Back.PNT05100DTO) As PNT05100Back.PNT05100DTO Implements R_BackEnd.R_IServicebase(Of PNT05100Back.PNT05100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT05100Cls
        Dim loRtn As PNT05100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT05100Back.PNT05100DTO, poCRUDMode As R_Common.eCRUDMode) As PNT05100Back.PNT05100DTO Implements R_BackEnd.R_IServicebase(Of PNT05100Back.PNT05100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT05100Cls
        Dim loRtn As PNT05100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As PNT05100Back.PNT05100DTO) As PNT05100Back.PNT05100DTO Implements IPNT05100Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loRtn As PNT05100DTO = Nothing

        Try
            loRtn = New PNT05100Cls().DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As PNT05100Back.PNT05100DTO) As PNT05100Back.PNT05100DTO Implements IPNT05100Service.Submit
        Dim loEx As New R_Exception
        Dim loRtn As PNT05100DTO = Nothing

        Try
            loRtn = New PNT05100Cls().Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poParam As PNT05100Back.PNT05100DTO) As PNT05100Back.PNT05100DTO Implements IPNT05100Service.Reject
        Dim loEx As New R_Exception
        Dim loRtn As PNT05100DTO = Nothing

        Try
            loRtn = New PNT05100Cls().Reject(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getDetailPosition(poParam As PNT05100Back.PNT05100DTO) As PNT05100Back.PNT05100DTO Implements IPNT05100Service.getDetailPosition
        Dim loEx As New R_Exception
        Dim loCls As New PNT05100Cls
        Dim loRtn As PNT05100DTO

        Try
            loRtn = loCls.getDetailPosition(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getDetailEmployee(poParam As PNT05100Back.PNT05100DTO) As PNT05100Back.PNT05100DTO Implements IPNT05100Service.getDetailEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PNT05100Cls
        Dim loRtn As PNT05100DTO

        Try
            loRtn = loCls.getDetailEmployee(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

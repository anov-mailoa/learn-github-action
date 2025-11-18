Imports R_BackEnd
Imports R_Common
Imports PNT03400Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03400Service" in code, svc and config file together.
Public Class PNT03400Service
    Implements IPNT03400Service

    Public Sub Svc_R_Delete(poEntity As PNT03400Back.PNT03400DTO) Implements R_BackEnd.R_IServicebase(Of PNT03400Back.PNT03400DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT03400Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT03400Back.PNT03400DTO) As PNT03400Back.PNT03400DTO Implements R_BackEnd.R_IServicebase(Of PNT03400Back.PNT03400DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT03400Cls
        Dim loRtn As PNT03400DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT03400Back.PNT03400DTO, poCRUDMode As R_Common.eCRUDMode) As PNT03400Back.PNT03400DTO Implements R_BackEnd.R_IServicebase(Of PNT03400Back.PNT03400DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT03400Cls
        Dim loRtn As PNT03400DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As PNT03400Back.PNT03400DTO) As PNT03400Back.PNT03400DTO Implements IPNT03400Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loRtn As PNT03400DTO = Nothing
        Dim loCls = New PNT03400Cls

        Try
            loRtn = loCls.DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As PNT03400Back.PNT03400DTO) As PNT03400Back.PNT03400DTO Implements IPNT03400Service.Submit
        Dim loEx As New R_Exception
        Dim loRtn As PNT03400DTO = Nothing
        Dim loCls = New PNT03400Cls

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poParam As PNT03400Back.PNT03400DTO) As PNT03400Back.PNT03400DTO Implements IPNT03400Service.Reject
        Dim loEx As New R_Exception
        Dim loRtn As PNT03400DTO = Nothing

        Try
            loRtn = New PNT03400Cls().Reject(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub checkStatus(poParam As PNT03400Back.PNT03400DTO) Implements IPNT03400Service.checkStatus
        Dim loEx As New R_Exception
        Dim loCls As New PNT03400Cls

        Try
            loCls.checkStatus(poParam)
        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function checkInterface(pcCompanyId As String) As PNT03400Back.PNT03400DTO Implements IPNT03400Service.checkInterface
        Dim loEx As New R_Exception
        Dim loCls As New PNT03400Cls
        Dim loRtn As New PNT03400DTO

        Try
            loRtn = loCls.checkInterface(pcCompanyId)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRefNo(poParam As PNT03400Back.PNT03400DTO) As String Implements IPNT03400Service.getRefNo
        Dim loEx As New R_Exception
        Dim loCls As New PNT03400Cls
        Dim lcRtn As String

        Try
            lcRtn = loCls.getRefNo(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcRtn
    End Function
End Class

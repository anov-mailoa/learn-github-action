Imports R_Common
Imports PYT00500Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00500Service" in code, svc and config file together.
Public Class PYT00500Service
    Implements IPYT00500Service

    Public Sub Svc_R_Delete(poEntity As PYT00500Back.PYT00500DTO) Implements R_BackEnd.R_IServicebase(Of PYT00500Back.PYT00500DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT00500Back.PYT00500DTO) As PYT00500Back.PYT00500DTO Implements R_BackEnd.R_IServicebase(Of PYT00500Back.PYT00500DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtn As PYT00500DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT00500Back.PYT00500DTO, poCRUDMode As R_Common.eCRUDMode) As PYT00500Back.PYT00500DTO Implements R_BackEnd.R_IServicebase(Of PYT00500Back.PYT00500DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtn As PYT00500DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEndPeriod(poParam As PYT00500Back.PYT00500DTO) As PYT00500Back.PYT00500DTO Implements IPYT00500Service.getEndPeriod
        Dim loException As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtn As PYT00500DTO

        Try
            loRtn = loCls.getEndPeriod(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkTransStatus(poParam As PYT00500Back.PYT00500DTO) As String Implements IPYT00500Service.checkTransStatus
        Dim loException As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtn As String

        Try
            loRtn = loCls.checkTransStatus(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PYT00500Back.PYT00500DTO) As PYT00500Back.PYT00500DTO Implements IPYT00500Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtn As PYT00500DTO

        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function OpenProcess(poParam As PYT00500Back.PYT00500DTO) As PYT00500Back.PYT00500DTO Implements IPYT00500Service.OpenProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtn As PYT00500DTO

        Try
            loRtn = loCls.OpenProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getExistPeriod(poParam As PYT00500Back.PYT00500DTO) As Boolean Implements IPYT00500Service.getExistPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.getExistPeriod(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub createRapidTransHeader(poParam As PYT00500Back.PYT00500DTO) Implements IPYT00500Service.createRapidTransHeader
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtn As Boolean

        Try
            loCls.createRapidTransHeader(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function checkResult(poParam As PYT00500Back.PYT00500DTO) As Boolean Implements IPYT00500Service.checkResult
        Dim loEx As New R_Exception
        Dim loCls As New PYT00500Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkResult(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

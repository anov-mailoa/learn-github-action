Imports R_Common
Imports PYT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00600Service" in code, svc and config file together.
Public Class PYT00600Service
    Implements IPYT00600Service


    Public Sub Svc_R_Delete(poEntity As PYT00600Back.PYT00600CancellationDTO) Implements R_BackEnd.R_IServicebase(Of PYT00600Back.PYT00600CancellationDTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New PYT00600Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT00600Back.PYT00600CancellationDTO) As PYT00600Back.PYT00600CancellationDTO Implements R_BackEnd.R_IServicebase(Of PYT00600Back.PYT00600CancellationDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT00600Cls
        Dim loRtn As PYT00600CancellationDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT00600Back.PYT00600CancellationDTO, poCRUDMode As R_Common.eCRUDMode) As PYT00600Back.PYT00600CancellationDTO Implements R_BackEnd.R_IServicebase(Of PYT00600Back.PYT00600CancellationDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT00600Cls
        Dim loRtn As PYT00600CancellationDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PYT00600Back.PYT00600CancellationDTO) As PYT00600Back.PYT00600CancellationDTO Implements IPYT00600Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT00600Cls
        Dim loRtn As New PYT00600CancellationDTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function OpenProcess(poParam As PYT00600Back.PYT00600CancellationDTO) As PYT00600Back.PYT00600CancellationDTO Implements IPYT00600Service.OpenProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT00600Cls
        Dim loRtn As New PYT00600CancellationDTO
        Try
            loRtn = loCls.OpenProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of PYT00600Back.PYT00600DetailDTO)) Implements IPYT00600Service.Dummy

    End Sub

    Public Sub Dummy1(poPar2 As System.Collections.Generic.List(Of PYT00600Back.PYT00600CancellableDTO)) Implements IPYT00600Service.Dummy1

    End Sub

End Class

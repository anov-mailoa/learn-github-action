Imports R_Common
Imports PNM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM00100FullNameService" in code, svc and config file together.
Public Class PNM00100FullNameService
    Implements IPNM00100FullNameService

    Public Sub Svc_R_Delete(poEntity As PNM00100Back.PNM00100FullNameDTO) Implements R_BackEnd.R_IServicebase(Of PNM00100Back.PNM00100FullNameDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100FullNameCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM00100Back.PNM00100FullNameDTO) As PNM00100Back.PNM00100FullNameDTO Implements R_BackEnd.R_IServicebase(Of PNM00100Back.PNM00100FullNameDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100FullNameCLS
        Dim loRtn As PNM00100FullNameDTO

        Try

            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM00100Back.PNM00100FullNameDTO, poCRUDMode As R_Common.eCRUDMode) As PNM00100Back.PNM00100FullNameDTO Implements R_BackEnd.R_IServicebase(Of PNM00100Back.PNM00100FullNameDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100FullNameCLS
        Dim loRtn As New PNM00100FullNameDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PNM00100Back.PNM00100gridFullNameDTO)) Implements IPNM00100FullNameService.Dummy

    End Sub

    Public Sub saveFullNameParam(poParam As System.Collections.Generic.List(Of PNM00100Back.PNM00100FullNameDTO)) Implements IPNM00100FullNameService.saveFullNameParam
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100FullNameCLS
        Try
            loCls.saveFullNameParam(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Sub SaveNameSequence(poParam As System.Collections.Generic.List(Of PNM00100Back.PNM00100FullNameDTO)) Implements IPNM00100FullNameService.SaveNameSequence
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100FullNameCLS
        Try
            loCls.SaveNameSequence(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

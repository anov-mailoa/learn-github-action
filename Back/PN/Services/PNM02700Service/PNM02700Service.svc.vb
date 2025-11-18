' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02700Service" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports PNM02700Back
Imports R_BackEnd


Public Class PNM02700Service
    Implements IPNM02700Service


    Public Sub Svc_R_Delete(poEntity As PNM02700Back.PNM02700FormDTO) Implements R_BackEnd.R_IServicebase(Of PNM02700Back.PNM02700FormDTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCLS As New PNM02700CLS

        Try
            loCLS.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02700Back.PNM02700FormDTO) As PNM02700Back.PNM02700FormDTO Implements R_BackEnd.R_IServicebase(Of PNM02700Back.PNM02700FormDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCLS As New PNM02700CLS
        Dim loRtn As New PNM02700FormDTO

        Try
            loRtn = loCLS.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM02700Back.PNM02700FormDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02700Back.PNM02700FormDTO Implements R_BackEnd.R_IServicebase(Of PNM02700Back.PNM02700FormDTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCLS As New PNM02700CLS
        Dim loRtn As New PNM02700FormDTO

        Try
            loRtn = loCLS.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Activate(poParam As PNM02700Back.PNM02700FormDTO) As PNM02700Back.PNM02700FormDTO Implements IPNM02700Service.Activate
        Dim loEx As New R_Exception
        Dim loRtn As PNM02700FormDTO = Nothing

        Try
            loRtn = New PNM02700CLS().Activate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

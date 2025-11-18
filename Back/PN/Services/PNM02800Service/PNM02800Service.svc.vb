Imports System.ServiceModel
Imports R_Common
Imports PNM02800Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02800Service" in code, svc and config file together.
Public Class PNM02800Service
    Implements IPNM02800Service

    Public Sub Svc_R_Delete(poEntity As PNM02800Back.PNM02800FormDTO) Implements R_BackEnd.R_IServicebase(Of PNM02800Back.PNM02800FormDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02800Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02800Back.PNM02800FormDTO) As PNM02800Back.PNM02800FormDTO Implements R_BackEnd.R_IServicebase(Of PNM02800Back.PNM02800FormDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM02800Cls
        Dim loRtn As PNM02800FormDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM02800Back.PNM02800FormDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02800Back.PNM02800FormDTO Implements R_BackEnd.R_IServicebase(Of PNM02800Back.PNM02800FormDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM02800Cls
        Dim loRtn As PNM02800FormDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ActivateData(poParam As PNM02800Back.PNM02800FormDTO) As PNM02800Back.PNM02800FormDTO Implements IPNM02800Service.ActivateData
        Dim loEx As New R_Exception
        Dim loCls As New PNM02800Cls
        Dim loRtn As New PNM02800FormDTO

        Try
            loRtn = loCls.ActivateData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

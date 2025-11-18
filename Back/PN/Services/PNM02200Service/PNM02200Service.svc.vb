' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02200Service" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNM02200Back
Imports System.ServiceModel

Public Class PNM02200Service
    Implements IPNM02200Service

    Public Sub Svc_R_Delete(poEntity As PNM02200Back.PNM02200HeaderDTO) Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200HeaderDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02200CLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02200Back.PNM02200HeaderDTO) As PNM02200Back.PNM02200HeaderDTO Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200HeaderDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM02200CLS
        Dim loRtn As PNM02200HeaderDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As PNM02200Back.PNM02200HeaderDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02200Back.PNM02200HeaderDTO Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200HeaderDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM02200CLS
        Dim loRtn As PNM02200HeaderDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

End Class

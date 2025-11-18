Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05220Service" in code, svc and config file together.
Public Class PNM05220Service
    Implements IPNM05220Service



    Public Sub Svc_R_Delete(poEntity As PNM05200Back.PNM05220DTO) Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05220DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05200Back.PNM05220DTO) As PNM05200Back.PNM05220DTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05220DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05220Cls
        Dim loRtn As PNM05220DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM05200Back.PNM05220DTO, poCRUDMode As R_Common.eCRUDMode) As PNM05200Back.PNM05220DTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05220DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM05220Cls
        Dim loRtn As PNM05220DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

Imports System.ServiceModel
Imports R_Common
Imports PNM06200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM06200Service" in code, svc and config file together.
Public Class PNM06200Service
    Implements IPNM06200Service

    Public Sub Svc_R_Delete(poEntity As PNM06200Back.PNM06200DTO) Implements R_BackEnd.R_IServicebase(Of PNM06200Back.PNM06200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM06200HrdOfficialLetterCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM06200Back.PNM06200DTO) As PNM06200Back.PNM06200DTO Implements R_BackEnd.R_IServicebase(Of PNM06200Back.PNM06200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM06200HrdOfficialLetterCLS
        Dim loRtn As PNM06200DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM06200Back.PNM06200DTO, poCRUDMode As R_Common.eCRUDMode) As PNM06200Back.PNM06200DTO Implements R_BackEnd.R_IServicebase(Of PNM06200Back.PNM06200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM06200HrdOfficialLetterCLS
        Dim loRtn As PNM06200DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub checkDB(poParam As PNM06200Back.PNM06200DTO) Implements IPNM06200Service.checkDB
        Dim loEx As New R_Exception
        Dim loCls As New PNM06200HrdOfficialLetterCLS

        Try
            loCls.checkDB(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class

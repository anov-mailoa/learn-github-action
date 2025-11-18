Imports System.ServiceModel
Imports R_Common
Imports PNR11000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR11000Service" in code, svc and config file together.
Public Class PNR11000Service
    Implements IPNR11000Service

    Public Sub checkDB(poParam As PNR11000Back.PNR11000DTO) Implements IPNR11000Service.checkDB
        Dim loEx As New R_Exception
        Dim loCls As New PNR11000HrdOfficialLetterCLS

        Try
            loCls.checkDB(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub Svc_R_Delete(poEntity As PNR11000Back.PNR11000DTO) Implements R_BackEnd.R_IServicebase(Of PNR11000Back.PNR11000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNR11000HrdOfficialLetterCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNR11000Back.PNR11000DTO) As PNR11000Back.PNR11000DTO Implements R_BackEnd.R_IServicebase(Of PNR11000Back.PNR11000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNR11000HrdOfficialLetterCLS
        Dim loRtn As PNR11000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNR11000Back.PNR11000DTO, poCRUDMode As R_Common.eCRUDMode) As PNR11000Back.PNR11000DTO Implements R_BackEnd.R_IServicebase(Of PNR11000Back.PNR11000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNR11000HrdOfficialLetterCLS
        Dim loRtn As PNR11000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

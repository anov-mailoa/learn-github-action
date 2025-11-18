Imports System.ServiceModel
Imports R_Common
Imports MCR11000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR11000Service" in code, svc and config file together.
Public Class MCR11000Service
    Implements IMCR11000Service

    Public Sub checkDB(poParam As MCR11000Back.MCR11000DTO) Implements IMCR11000Service.checkDB
        Dim loEx As New R_Exception
        Dim loCls As New MCR11000HrdOfficialLetterCLS

        Try
            loCls.checkDB(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub Svc_R_Delete(poEntity As MCR11000Back.MCR11000DTO) Implements R_BackEnd.R_IServicebase(Of MCR11000Back.MCR11000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCR11000HrdOfficialLetterCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCR11000Back.MCR11000DTO) As MCR11000Back.MCR11000DTO Implements R_BackEnd.R_IServicebase(Of MCR11000Back.MCR11000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCR11000HrdOfficialLetterCLS
        Dim loRtn As MCR11000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCR11000Back.MCR11000DTO, poCRUDMode As R_Common.eCRUDMode) As MCR11000Back.MCR11000DTO Implements R_BackEnd.R_IServicebase(Of MCR11000Back.MCR11000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCR11000HrdOfficialLetterCLS
        Dim loRtn As MCR11000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedicalYear(poParam As MCR11000Back.MCR11000DTO) As String Implements IMCR11000Service.getMedicalYear
        Dim loEx As New R_Exception
        Dim loCls As New MCR11000HrdOfficialLetterCLS
        Dim lcRtn As String = ""

        Try
            lcRtn = loCls.getMedicalYear(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function

End Class

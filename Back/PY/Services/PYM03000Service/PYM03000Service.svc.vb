Imports R_Common
Imports R_BackEnd
Imports PYM03000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM03000Service" in code, svc and config file together.
Public Class PYM03000Service
    Implements IPYM03000Service

    Public Sub Svc_R_Delete(poEntity As PYM03000Back.PYM03000DTO) Implements R_BackEnd.R_IServicebase(Of PYM03000Back.PYM03000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM03000Back.PYM03000DTO) As PYM03000Back.PYM03000DTO Implements R_BackEnd.R_IServicebase(Of PYM03000Back.PYM03000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM03000CLS
        Dim loRtn As New PYM03000DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM03000Back.PYM03000DTO, poCRUDMode As R_Common.eCRUDMode) As PYM03000Back.PYM03000DTO Implements R_BackEnd.R_IServicebase(Of PYM03000Back.PYM03000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM03000CLS
        Dim loRtn As New PYM03000DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkRestrict(pcCompId As String) As Integer Implements IPYM03000Service.checkRestrict
        Dim loEx As New R_Exception
        Dim loCls As New PYM03000CLS
        Dim liRtn As Integer
        Try
            liRtn = loCls.checkRestrict(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return liRtn
    End Function

    Public Sub PYM03000Saving(poNewEntity As PYM03000Back.PYM03000DTO) Implements IPYM03000Service.PYM03000Saving
        Dim loEx As New R_Exception
        Dim loCls As New PYM03000CLS
        Dim loRtn As New PYM03000DTO

        Try
            loCls.PYM03000Saving(poNewEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function checkUsedSalaryRange(pcCompId As String) As Integer Implements IPYM03000Service.checkUsedSalaryRange
        Dim loEx As New R_Exception
        Dim loCls As New PYM03000CLS
        Dim liRtn As Integer
        Try
            liRtn = loCls.checkUsedSalaryRange(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return liRtn
    End Function

    Public Function getRecord(poParam As PYM03000Back.PYM03000DTO) As PYM03000Back.PYM03000DTO Implements IPYM03000Service.getRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM03000CLS
        Dim loRtn As New PYM03000DTO
        Try
            loRtn = loCls.getRecord(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

Imports R_Common
Imports PYM10000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM10000Service" in code, svc and config file together.
Public Class PYM10000Service
    Implements IPYM10000Service

    Public Sub Svc_R_Delete(poEntity As PYM10000Back.PYM10000DTO) Implements R_BackEnd.R_IServicebase(Of PYM10000Back.PYM10000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM10000Back.PYM10000DTO) As PYM10000Back.PYM10000DTO Implements R_BackEnd.R_IServicebase(Of PYM10000Back.PYM10000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM10000Cls
        Dim loRtn As PYM10000DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM10000Back.PYM10000DTO, poCRUDMode As R_Common.eCRUDMode) As PYM10000Back.PYM10000DTO Implements R_BackEnd.R_IServicebase(Of PYM10000Back.PYM10000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM10000Cls
        Dim loRtn As PYM10000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub getCheckSyntax(pcSyntax As String) Implements IPYM10000Service.getCheckSyntax
        Dim loCls As New PYM10000Cls
        Dim loEx As New R_Exception

        Try
            loCls.getCheckSyntax(pcSyntax)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub init(poParam As PYM10000Back.PYM10000DTO) Implements IPYM10000Service.init
        Dim loEx As New R_Exception
        Dim loCls As New PYM10000Cls

        Try
            loCls.init(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

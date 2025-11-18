Imports R_Common
Imports PYR01000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR01000Service" in code, svc and config file together.
Public Class PYR01000Service
    Implements IPYR01000Service

    Public Sub Svc_R_Delete(poEntity As PYR01000Back.PYR01000DTO) Implements R_BackEnd.R_IServicebase(Of PYR01000Back.PYR01000DTO).Svc_R_Delete
        'not used
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYR01000Back.PYR01000DTO) As PYR01000Back.PYR01000DTO Implements R_BackEnd.R_IServicebase(Of PYR01000Back.PYR01000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYR01000Cls
        Dim loRtn As PYR01000DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYR01000Back.PYR01000DTO, poCRUDMode As R_Common.eCRUDMode) As PYR01000Back.PYR01000DTO Implements R_BackEnd.R_IServicebase(Of PYR01000Back.PYR01000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYR01000Cls
        Dim loRtn As PYR01000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub init(poParam As PYR01000Back.PYR01000DTO) Implements IPYR01000Service.init
        Dim loEx As New R_Exception
        Dim loCls As New PYR01000Cls

        Try
            loCls.init(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub getCheckSyntax(pcSyntax As String) Implements IPYR01000Service.getCheckSyntax
        Dim loCls As New PYR01000Cls
        Dim loEx As New R_Exception

        Try
            loCls.getCheckSyntax(pcSyntax)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub
End Class

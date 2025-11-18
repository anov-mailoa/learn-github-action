Imports R_Common
Imports PYM02000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM02000Service" in code, svc and config file together.
Public Class PYM02000Service
    Implements IPYM02000Service

    Public Sub Svc_R_Delete(poEntity As PYM02000Back.PYM02000DTO) Implements R_BackEnd.R_IServicebase(Of PYM02000Back.PYM02000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM02000CLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM02000Back.PYM02000DTO) As PYM02000Back.PYM02000DTO Implements R_BackEnd.R_IServicebase(Of PYM02000Back.PYM02000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM02000CLS
        Dim loRtn As New PYM02000DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM02000Back.PYM02000DTO, poCRUDMode As R_Common.eCRUDMode) As PYM02000Back.PYM02000DTO Implements R_BackEnd.R_IServicebase(Of PYM02000Back.PYM02000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM02000CLS
        Dim loRtn As New PYM02000DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

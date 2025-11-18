' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00500PerusahaanService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PYM00500Back
Imports System.ServiceModel

Public Class PYM00500MappingService
    Implements IPYM00500MappingService

    Public Sub Svc_R_Delete(poEntity As PYM00500Back.PYM00500MappingDTO) Implements R_BackEnd.R_IServicebase(Of PYM00500Back.PYM00500MappingDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00500Back.PYM00500MappingDTO) As PYM00500Back.PYM00500MappingDTO Implements R_BackEnd.R_IServicebase(Of PYM00500Back.PYM00500MappingDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM00500MappingCLS
        Dim loRtn As New PYM00500MappingDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM00500Back.PYM00500MappingDTO, poCRUDMode As R_Common.eCRUDMode) As PYM00500Back.PYM00500MappingDTO Implements R_BackEnd.R_IServicebase(Of PYM00500Back.PYM00500MappingDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM00500MappingCLS
        Dim loRtn As New PYM00500MappingDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

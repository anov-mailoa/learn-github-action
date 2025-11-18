Imports R_Common
Imports ATM12000Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM12000Service" in code, svc and config file together.
Public Class ATM12000DetailService
    Implements IATM12000DetailService

    Public Sub Svc_R_Delete1(poEntity As ATM12000Back.ATM12000DetailDTO) Implements R_BackEnd.R_IServicebase(Of ATM12000Back.ATM12000DetailDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATM12000DetailCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord1(poEntity As ATM12000Back.ATM12000DetailDTO) As ATM12000Back.ATM12000DetailDTO Implements R_BackEnd.R_IServicebase(Of ATM12000Back.ATM12000DetailDTO).Svc_R_GetRecord
        Dim loCls As New ATM12000DetailCls
        Dim loRtn As New ATM12000DetailDTO
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save1(poEntity As ATM12000Back.ATM12000DetailDTO, poCRUDMode As R_Common.eCRUDMode) As ATM12000Back.ATM12000DetailDTO Implements R_BackEnd.R_IServicebase(Of ATM12000Back.ATM12000DetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM12000DetailCls
        Dim loRtn As ATM12000DetailDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

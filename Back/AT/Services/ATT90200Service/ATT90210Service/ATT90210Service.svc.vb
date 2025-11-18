Imports R_BackEnd
Imports R_Common
Imports ATT90200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90210Service" in code, svc and config file together.
Public Class ATT90210Service
    Implements IATT90210Service

    Public Sub Svc_R_Delete(poEntity As ATT90200Back.ATT90210DTO) Implements R_BackEnd.R_IServicebase(Of ATT90200Back.ATT90210DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT90200Back.ATT90210DTO) As ATT90200Back.ATT90210DTO Implements R_BackEnd.R_IServicebase(Of ATT90200Back.ATT90210DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT90210Cls
        Dim loRtn As ATT90210DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT90200Back.ATT90210DTO, poCRUDMode As R_Common.eCRUDMode) As ATT90200Back.ATT90210DTO Implements R_BackEnd.R_IServicebase(Of ATT90200Back.ATT90210DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT90210Cls
        Dim loRtn As ATT90210DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

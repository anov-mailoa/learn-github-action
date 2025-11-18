Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports MCT00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT00100DtService" in code, svc and config file together.
Public Class MCT00100DtService
    Implements IMCT00100DtService

    Public Sub Svc_R_Delete(poEntity As MCT00100Back.MCT00100DtDTO) Implements R_BackEnd.R_IServicebase(Of MCT00100Back.MCT00100DtDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackDTCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT00100Back.MCT00100DtDTO) As MCT00100Back.MCT00100DtDTO Implements R_BackEnd.R_IServicebase(Of MCT00100Back.MCT00100DtDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackDTCLS
        Dim loRtn As New MCT00100DtDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCT00100Back.MCT00100DtDTO, poCRUDMode As R_Common.eCRUDMode) As MCT00100Back.MCT00100DtDTO Implements R_BackEnd.R_IServicebase(Of MCT00100Back.MCT00100DtDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackDTCLS
        Dim loRtn As New MCT00100DtDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEmployeeLimitSubitem(poParam As MCT00100Back.MCT00100DtDTO) As MCT00100Back.MCT00100DtDTO Implements IMCT00100DtService.GetEmployeeLimitSubitem
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackDTCLS
        Dim loRtn As New MCT00100DtDTO

        Try
            loRtn = loCls.GetEmployeeLimitSubitem(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getValidateAvailable(poParam As MCT00100Back.MCT00100DtDTO) As Integer Implements IMCT00100DtService.getValidateAvailable
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackDTCLS
        Dim loRtn As Integer

        Try
            loRtn = loCls.getValidateAvailable(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkMedicalThreshold(poParam As MCT00100Back.MCT00100DtDTO) As MCT00100Back.MCT00100DtDTO Implements IMCT00100DtService.checkMedicalThreshold
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackDTCLS
        Dim loRtn As New MCT00100DtDTO

        Try
            loRtn = loCls.checkMedicalThreshold(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLimitInfo(poParam As MCT00100Back.MCT00100DtDTO) As MCT00100Back.MCT00100DtDTO Implements IMCT00100DtService.GetLimitInfo
        Dim loEx As New R_Exception
        Dim loCls As New MCT00100BackDTCLS
        Dim loRtn As New MCT00100DtDTO

        Try
            loRtn = loCls.GetLimitInfo(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00101Service" in code, svc and config file together.

Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports QAT00101Back

Public Class QAT00101Service
    Implements IQAT00101Service

    Public Sub Svc_R_Delete(poEntity As QAT00101Back.QAT00101DTO) Implements R_BackEnd.R_IServicebase(Of QAT00101Back.QAT00101DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT00101Back.QAT00101DTO) As QAT00101Back.QAT00101DTO Implements R_BackEnd.R_IServicebase(Of QAT00101Back.QAT00101DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New QAT00101DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAT00101Back.QAT00101DTO, poCRUDMode As R_Common.eCRUDMode) As QAT00101Back.QAT00101DTO Implements R_BackEnd.R_IServicebase(Of QAT00101Back.QAT00101DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New QAT00101DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getQaParameter(poParam As QAT00101Back.QAT00101DTO) As QAT00101Back.QAT00101DTO Implements IQAT00101Service.getQaParameter
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New QAT00101DTO
        Try
            loRtn = loCls.getQaParameter(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function EnableDisableDocType(poParam As QAT00101Back.QAT00101DTO) As Boolean Implements IQAT00101Service.EnableDisableDocType
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New Boolean
        Try
            loRtn = loCls.EnableDisableDocType(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function updateStatusSubmit(poParam As QAT00101Back.QAT00101DTO) As QAT00101Back.QAT00101DTO Implements IQAT00101Service.updateStatusSubmit
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New QAT00101DTO
        Try
            loRtn = loCls.updateStatusSubmit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function updateAll(poParam As QAT00101Back.QAT00101DTO) As QAT00101Back.QAT00101DTO Implements IQAT00101Service.updateAll
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New QAT00101DTO
        Try
            loRtn = loCls.updateAll(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Sub submitValidation(poParam As QAT00101Back.QAT00101DTO) Implements IQAT00101Service.submitValidation

        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS

        Try
            loCls.submitValidation(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function updateStatusConfirm(poParam As QAT00101Back.QAT00101DTO) As QAT00101Back.QAT00101DTO Implements IQAT00101Service.updateStatusConfirm
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New QAT00101DTO
        Try
            loRtn = loCls.updateStatusConfirm(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function updateStatusRedraft(poParam As QAT00101Back.QAT00101DTO) As QAT00101Back.QAT00101DTO Implements IQAT00101Service.updateStatusRedraft
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New QAT00101DTO
        Try
            loRtn = loCls.updateStatusRedraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function updateStatusUnverify(poParam As QAT00101Back.QAT00101DTO) As QAT00101Back.QAT00101DTO Implements IQAT00101Service.updateStatusUnverify
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New QAT00101DTO
        Try
            loRtn = loCls.updateStatusUnverify(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function updateStatusVerify(poParam As QAT00101Back.QAT00101DTO) As QAT00101Back.QAT00101DTO Implements IQAT00101Service.updateStatusVerify
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New QAT00101DTO
        Try
            loRtn = loCls.updateStatusVerify(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function updateStatusRevised(poParam As QAT00101Back.QAT00101DTO) As QAT00101Back.QAT00101DTO Implements IQAT00101Service.updateStatusRevised
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101CLS
        Dim loRtn As New QAT00101DTO

        Try
            loRtn = loCls.updateStatusRevised(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM00100Service" in code, svc and config file together.

Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports System.ServiceModel

Public Class PNT00100Service
    Implements IPNT00100Service

    Public Sub Svc_R_Delete(poEntity As PNT00100Back.PNT00100OfficialDTO) Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100OfficialDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100OfficialCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT00100Back.PNT00100OfficialDTO) As PNT00100Back.PNT00100OfficialDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100OfficialDTO).Svc_R_GetRecord


        Dim loEx As New R_Exception
        Dim loCls As New PNT00100OfficialCLS
        Dim loRtn As PNT00100OfficialDTO

        Try

            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function Svc_R_Save(poEntity As PNT00100Back.PNT00100OfficialDTO, poCRUDMode As R_Common.eCRUDMode) As PNT00100Back.PNT00100OfficialDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100OfficialDTO).Svc_R_Save


        Dim loEx As New R_Exception
        Dim loCls As New PNT00100OfficialCLS
        Dim loRtn As PNT00100OfficialDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Sub checkStatusValidate(poParameter As PNT00100Back.PNT00100OfficialDTO) Implements IPNT00100Service.checkStatusValidate
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100OfficialCLS

        Try
            loCls.checkStatusValidate(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function DraftUndraft(poParam As PNT00100Back.PNT00100OfficialDTO) As PNT00100Back.PNT00100OfficialDTO Implements IPNT00100Service.DraftUndraft


        Dim loEx As New R_Exception
        Dim loRtn As PNT00100OfficialDTO = Nothing
        Dim loCls As New PNT00100OfficialCLS

        Try
            loRtn = loCls.DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn


    End Function

    Public Sub checkStatusValidateDelete(poParameter As PNT00100Back.PNT00100OfficialDTO) Implements IPNT00100Service.checkStatusValidateDelete
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100OfficialCLS

        Try
            loCls.checkStatusValidateDelete(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub checkStatusValidateAdd(poParameter As PNT00100Back.PNT00100OfficialDTO) Implements IPNT00100Service.checkStatusValidateAdd
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100OfficialCLS

        Try
            loCls.checkStatusValidateAdd(poParameter)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Submit(poParam As PNT00100Back.PNT00100OfficialDTO) As PNT00100Back.PNT00100OfficialDTO Implements IPNT00100Service.Submit


        Dim loEx As New R_Exception
        Dim loRtn As PNT00100OfficialDTO = Nothing
        Dim loCls As New PNT00100OfficialCLS

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn



    End Function

    Public Function cekResources(poParam As PNT00100Back.PNT00100OfficialDTO) As Boolean Implements IPNT00100Service.cekResources
        Dim loEx As New R_Exception
        Dim loRtn As Boolean
        Dim loCls As New PNT00100OfficialCLS

        Try
            loRtn = loCls.cekResources(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function


    Public Function checkNPWP(pcNpwp As String) As Boolean Implements IPNT00100Service.checkNPWP
        Dim loEx As New R_Exception
        Dim loRtn As Boolean
        Dim loCls As New PNT00100OfficialCLS

        Try
            loRtn = loCls.checkNPWP(pcNpwp)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function RFT_GET_FULLNAME(poParam As PNT00100Back.PNT00100OfficialDTO) As String Implements IPNT00100Service.RFT_GET_FULLNAME
        Dim loEx As New R_Exception
        Dim lcRtn As String
        Dim loCls As New PNT00100OfficialCLS

        Try
            lcRtn = loCls.RFT_GET_FULLNAME(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function

    Public Function checkInterface(pcCompanyId As String) As PNT00100Back.PNT00100OfficialDTO Implements IPNT00100Service.checkInterface
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100OfficialCLS
        Dim loRtn As New PNT00100OfficialDTO

        Try
            loRtn = loCls.checkInterface(pcCompanyId)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPersonalDataEmployee(poParam As PNT00100Back.PNT00100OfficialDTO) As PNT00100Back.PNT00100OfficialDTO Implements IPNT00100Service.getPersonalDataEmployee
        Dim loEx As New R_Exception
        Dim loRtn As New PNT00100OfficialDTO
        Dim loCls As New PNT00100OfficialCLS

        Try
            loRtn = loCls.getPersonalDataEmployee(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub checkEmployeeId(pcCompId As String, pcEmpId As String) Implements IPNT00100Service.checkEmployeeId
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100OfficialCLS

        Try
            loCls.checkEmployeeId(pcCompId, pcEmpId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function regisApplicant(poParam As PNT00100Back.PNT00100OfficialDTO) As PNT00100Back.PNT00100OfficialDTO Implements IPNT00100Service.regisApplicant
        Dim loEx As New R_Exception
        Dim loRtn As PNT00100OfficialDTO = Nothing
        Dim loCls As New PNT00100OfficialCLS

        Try
            loRtn = loCls.regisApplicant(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

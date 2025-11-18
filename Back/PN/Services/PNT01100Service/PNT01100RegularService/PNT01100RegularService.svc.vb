Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT01100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT01100RegularService" in code, svc and config file together.
Public Class PNT01100RegularService
    Implements IPNT01100RegularService

    Public Sub Svc_R_Delete(poEntity As PNT01100Back.PNT01100DTO) Implements R_BackEnd.R_IServicebase(Of PNT01100Back.PNT01100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT01100Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT01100Back.PNT01100DTO) As PNT01100Back.PNT01100DTO Implements R_BackEnd.R_IServicebase(Of PNT01100Back.PNT01100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT01100Cls
        Dim loRtn As New PNT01100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT01100Back.PNT01100DTO, poCRUDMode As R_Common.eCRUDMode) As PNT01100Back.PNT01100DTO Implements R_BackEnd.R_IServicebase(Of PNT01100Back.PNT01100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT01100Cls
        Dim loRtn As New PNT01100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function CheckEmployeeAssignationResignation(poEntity As PNT01100Back.PNT01100DTO) As Boolean Implements IPNT01100RegularService.CheckEmployeeAssignationResignation
        Dim loEx As New R_Exception
        Dim loCls As New PNT01100Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.CheckEmployeeAssignationResignation(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetEmployeeOfficialData(poEntity As PNT01100Back.PNT01100DTO) As PNT01100Back.PNT01100DTO Implements IPNT01100RegularService.GetEmployeeOfficialData
        Dim loEx As New R_Exception
        Dim loCls As New PNT01100Cls
        Dim loRtn As New PNT01100DTO

        Try
            loRtn = loCls.GetEmployeeOfficialData(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function ProcessReDraft(poEntity As PNT01100Back.PNT01100DTO) As PNT01100Back.PNT01100DTO Implements IPNT01100RegularService.ProcessReDraft
        Dim loEx As New R_Exception
        Dim loCls As New PNT01100Cls
        Dim loRtn As New PNT01100DTO

        Try
            loRtn = loCls.ProcessReDraft(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function ProcessSubmit(poEntity As PNT01100Back.PNT01100DTO) As PNT01100Back.PNT01100DTO Implements IPNT01100RegularService.ProcessSubmit
        Dim loEx As New R_Exception
        Dim loCls As New PNT01100Cls
        Dim loRtn As New PNT01100DTO

        Try
            loRtn = loCls.ProcessSubmit(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poCurrent As PNT01100Back.PNT01100DTO) As PNT01100Back.PNT01100DTO Implements IPNT01100RegularService.Reject
        Dim loEx As New R_Exception
        Dim loCls As New PNT01100Cls
        Dim loRtn As New PNT01100DTO

        Try
            loRtn = loCls.Reject(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

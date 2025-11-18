' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM03100Service" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports System.ServiceModel
Imports SIAPP_PUB_DTO

Public Class PNM03100Service
    Implements IPNM03100Service

    Public Sub Svc_R_Delete(poEntity As PNM03100Back.PNM03100DTO) Implements R_BackEnd.R_IServicebase(Of PNM03100Back.PNM03100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM03100Back.PNM03100DTO) As PNM03100Back.PNM03100DTO Implements R_BackEnd.R_IServicebase(Of PNM03100Back.PNM03100DTO).Svc_R_GetRecord

        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As PNM03100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function Svc_R_Save(poEntity As PNM03100Back.PNM03100DTO, poCRUDMode As R_Common.eCRUDMode) As PNM03100Back.PNM03100DTO Implements R_BackEnd.R_IServicebase(Of PNM03100Back.PNM03100DTO).Svc_R_Save


        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As PNM03100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Sub saveJobDesc(poParam As PNM03100Back.PNM03100CopyFromDTO) Implements IPNM03100Service.saveJobDesc
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CopyFromCLS

        Try
            loCls.saveJobDesc(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Sub saveJobCompetency(poParam As PNM03100Back.PNM03100CopyFromDTO) Implements IPNM03100Service.saveJobCompetency
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CopyFromCLS

        Try
            loCls.saveJobCompetency(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub saveJobSpec(poParam As PNM03100Back.PNM03100CopyFromDTO) Implements IPNM03100Service.saveJobSpec
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CopyFromCLS

        Try
            loCls.saveJobSpec(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub saveTraining(poParam As PNM03100Back.PNM03100CopyFromDTO) Implements IPNM03100Service.saveTraining
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CopyFromCLS

        Try
            loCls.saveTraining(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub ActiveToInactive(poParam As PNM03100Back.PNM03100DTO) Implements IPNM03100Service.ActiveToInactive
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS

        Try
            loCls.ActiveToInactive(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getEditValidate(poParam As PNM03100Back.PNM03100DTO) As Boolean Implements IPNM03100Service.getEditValidate
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As Boolean
        Try
            loRtn = loCls.getEditValidate(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function validateNoChild(poParam As PNM03100Back.PNM03100DTO) As Boolean Implements IPNM03100Service.validateNoChild


        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As Boolean
        Try
            loRtn = loCls.validateNoChild(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Sub RSP_PNM_ORG_STRUCTURE_MOVE_POSITION(poParam As PNM03100Back.PNM03100DTO) Implements IPNM03100Service.RSP_PNM_ORG_STRUCTURE_MOVE_POSITION

        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS

        Try
            loCls.RSP_PNM_ORG_STRUCTURE_MOVE_POSITION(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function validateJCandiNoResources(poParam As PNM03100Back.PNM03100DTO) As Boolean Implements IPNM03100Service.validateJCandiNoResources

        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As Boolean
        Try
            loRtn = loCls.validateJCandiNoResources(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function RFN_GET_NO_OF_RESOURCES(poParam As PNM03100Back.PNM03100DTO) As Boolean Implements IPNM03100Service.RFN_GET_NO_OF_RESOURCES


        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As Boolean
        Try
            loRtn = loCls.RFN_GET_NO_OF_RESOURCES(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn


    End Function

    Public Function validateParentResources(poParam As PNM03100Back.PNM03100DTO) As Object Implements IPNM03100Service.validateParentResources

        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS

        Try
            loCls.validateParentResources(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Function

    Public Sub RSP_UPLOAD_ORG_STRUCTURE(poParam As PNM03100Back.PNM03100DTO) Implements IPNM03100Service.RSP_UPLOAD_ORG_STRUCTURE

        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS

        Try
            loCls.RSP_UPLOAD_ORG_STRUCTURE(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()


    End Sub

    Public Function getLevelParent(poParam As PNM03100Back.PNM03100DTO) As Integer Implements IPNM03100Service.getLevelParent

        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As Integer

        Try
            loRtn = loCls.getLevelParent(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getParentPositionCode(poParam As PNM03100Back.PNM03100DTO) As String Implements IPNM03100Service.getParentPositionCode
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As String

        Try
            loRtn = loCls.getParentPositionCode(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function MemberOfEmployee(poParam As PNM03100Back.PNM03100DTO) As Boolean Implements IPNM03100Service.MemberOfEmployee

        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.MemberOfEmployee(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function UsePosition(poParam As PNM03100Back.PNM03100DTO) As Integer Implements IPNM03100Service.UsePosition


        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As Int64

        Try
            loRtn = loCls.UsePosition(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Sub EditTree(poParam As PNM03100Back.PNM03100DTO) Implements IPNM03100Service.EditTree

        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS

        Try
            loCls.EditTree(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()


    End Sub

    Public Function getMinResources(poParam As PNM03100Back.PNM03100DTO) As Integer Implements IPNM03100Service.getMinResources


        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As New Integer

        Try
            loRtn = loCls.getMinResources(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    'Public Sub RSP_GET_POSITION_RIGHTS(poParam As PNM03100Back.PNM03100DTO) Implements IPNM03100Service.RSP_GET_POSITION_RIGHTS
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PNM03100CLS
    '    Try
    '        loCls.RSP_GET_POSITION_RIGHTS(poParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub

    Public Function validateHistoryEmployee(poParam As PNM03100Back.PNM03100DTO) As Boolean Implements IPNM03100Service.validateHistoryEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.validateHistoryEmployee(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkHasPosition(pcCompId As String) As Boolean Implements IPNM03100Service.checkHasPosition
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100CLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkHasPosition(pcCompId)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

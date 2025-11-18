Imports R_Common
Imports EST10000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "EST10000PersonalDataService" in code, svc and config file together.
Public Class EST10000PersonalDataService
    Implements IEST10000PersonalDataService

    Public Sub Svc_R_Delete(poEntity As EST10000Back.EST10000PersonalDataDTO) Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000PersonalDataDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As EST10000Back.EST10000PersonalDataDTO) As EST10000Back.EST10000PersonalDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000PersonalDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New EST10000PersonalDataCls
        Dim loRtn As New EST10000PersonalDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As EST10000Back.EST10000PersonalDataDTO, poCRUDMode As R_Common.eCRUDMode) As EST10000Back.EST10000PersonalDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000PersonalDataDTO).Svc_R_Save

    End Function

    Public Sub ApprovalPesonalData(poParam As EST10000Back.EST10000PersonalDataDTO) Implements IEST10000PersonalDataService.ApprovalPesonalData
        Dim loEx As New R_Exception
        Dim loCls As New EST10000PersonalDataCls
        Try
            loCls.ApprovalPesonalData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GetRecord(poParam As EST10000Back.EST10000PersonalDataDTO) As EST10000Back.EST10000PersonalDataDTO Implements IEST10000PersonalDataService.GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New EST10000PersonalDataCls
        Dim loRtn As New EST10000PersonalDataDTO

        Try
            loRtn = loCls.GetRecord(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

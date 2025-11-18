Imports R_Common
Imports PNM04100Back
Imports System.ServiceModel
Imports R_BackEnd
Imports PNM04100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM04100BatchService" in code, svc and config file together.
Public Class PNM04100BatchService
    'Implements IPNM04100BatchService


    'Public Function Svc_R_GetRecord(poEntity As PNM04100Common.PNM04100BatchDto) As PNM04100Common.PNM04100BatchDto Implements R_BackEnd.R_IServicebase(Of PNM04100Common.PNM04100BatchDto).Svc_R_GetRecord
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PNM04100BatchCls
    '    Dim loRtn As New PNM04100BatchDto
    '    Try
    '        loRtn = loCls.R_GetRecord(poEntity)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    '    Return loRtn
    'End Function

    'Public Function Svc_R_Save(poEntity As PNM04100Common.PNM04100BatchDto, poCRUDMode As R_Common.eCRUDMode) As PNM04100Common.PNM04100BatchDto Implements R_BackEnd.R_IServicebase(Of PNM04100Common.PNM04100BatchDto).Svc_R_Save

    'End Function

    'Public Function Activate(poParam As PNM04100Common.PNM04100BatchDto) As PNM04100Common.PNM04100BatchDto Implements IPNM04100BatchService.Activate

    'End Function
End Class

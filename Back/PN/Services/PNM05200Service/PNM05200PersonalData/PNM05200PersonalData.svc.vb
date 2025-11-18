Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05200PersonalData" in code, svc and config file together.
Public Class PNM05200PersonalData
    Implements IPNM05200PersonalData


    Public Sub Svc_R_Delete(poEntity As PNM05200Back.PNM05200PersonalDataDTO) Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200PersonalDataDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05200Back.PNM05200PersonalDataDTO) As PNM05200Back.PNM05200PersonalDataDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200PersonalDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200PersonalDataCls
        Dim loRtn As New PNM05200PersonalDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
    Public Function Svc_R_Save(poEntity As PNM05200Back.PNM05200PersonalDataDTO, poCRUDMode As R_Common.eCRUDMode) As PNM05200Back.PNM05200PersonalDataDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200PersonalDataDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200PersonalDataCls
        Dim loRtn As New PNM05200PersonalDataDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getBooleanPersonalChange(poParam As PNM05200Back.PNM05200PersonalDataDTO) As Boolean Implements IPNM05200PersonalData.getBooleanPersonalChange
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200PersonalDataCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.getBooleanPersonalData(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

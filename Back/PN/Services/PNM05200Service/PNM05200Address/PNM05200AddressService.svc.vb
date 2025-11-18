Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05200AddressService" in code, svc and config file together.
Public Class PNM05200AddressService
    Implements IPNM05200AddressService

    Public Sub Svc_R_Delete(poEntity As PNM05200Back.PNM05200AddressDTO) Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200AddressDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05200Back.PNM05200AddressDTO) As PNM05200Back.PNM05200AddressDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200AddressDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200AddressCls
        Dim loRtn As New PNM05200AddressDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM05200Back.PNM05200AddressDTO, poCRUDMode As R_Common.eCRUDMode) As PNM05200Back.PNM05200AddressDTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05200AddressDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM05200AddressCls
        Dim loRtn As New PNM05200AddressDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

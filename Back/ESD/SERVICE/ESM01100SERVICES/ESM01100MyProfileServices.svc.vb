Imports R_Common
Imports ESM01100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01100Services" in code, svc and config file together.
Public Class ESM01100MyProfileServices
    Implements IESM01100MyProfileServices

    Public Sub Svc_R_Delete(poEntity As ESM01100Back.ESM01100MyProfileDTO) Implements R_BackEnd.R_IServicebase(Of ESM01100Back.ESM01100MyProfileDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM01100Back.ESM01100MyProfileDTO) As ESM01100Back.ESM01100MyProfileDTO Implements R_BackEnd.R_IServicebase(Of ESM01100Back.ESM01100MyProfileDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100CLS
        Dim loRtn As New ESM01100MyProfileDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM01100Back.ESM01100MyProfileDTO, poCRUDMode As R_Common.eCRUDMode) As ESM01100Back.ESM01100MyProfileDTO Implements R_BackEnd.R_IServicebase(Of ESM01100Back.ESM01100MyProfileDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100CLS
        Dim loRtn As New ESM01100MyProfileDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poPar2 As System.Collections.Generic.List(Of ESM01100Back.ESM01100ParamDTO)) Implements IESM01100MyProfileServices.Dummy

    End Sub

    Public Function getOfficialData(poParam As ESM01100Back.ESM01100MyProfileDTO) As ESM01100Back.ESM0110OfficialDataDTO Implements IESM01100MyProfileServices.getOfficialData
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100CLS
        Dim loRtn As New ESM0110OfficialDataDTO

        Try
            loRtn = loCls.getOfficialData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

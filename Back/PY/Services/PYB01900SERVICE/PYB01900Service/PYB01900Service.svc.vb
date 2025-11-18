Imports R_Common
Imports PYB01900Back
Imports System.ServiceModel.Channels
Imports PYB01900Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB01900Service" in code, svc and config file together.
Public Class PYB01900Service
    Implements IPYB01900Service

    Public Function RFN_PYB01900_GET_PDF_PASSWORD(poParam As PYB01900SPTDTO) As String Implements IPYB01900Service.RFN_PYB01900_GET_PDF_PASSWORD
        Dim loEx As New R_Exception
        Dim loRtn As String
        Dim loCls As New PYB01900Cls

        Try
            loRtn = loCls.RFN_PYB01900_GET_PDF_PASSWORD(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub RSP_PYB01900_SAVE_SPT_FILE_EMP(poParam As PYB01900SPTDTO) Implements IPYB01900Service.RSP_PYB01900_SAVE_SPT_FILE_EMP
        Dim loEx As New R_Exception
        Dim loCls As New PYB01900Cls

        Try
            loCls.RSP_PYB01900_SAVE_SPT_FILE_EMP(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub Svc_R_Delete(poEntity As PYB01900Back.PYB01900DTO) Implements R_BackEnd.R_IServicebase(Of PYB01900Back.PYB01900DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYB01900Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYB01900Back.PYB01900DTO) As PYB01900Back.PYB01900DTO Implements R_BackEnd.R_IServicebase(Of PYB01900Back.PYB01900DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PYB01900Back.PYB01900DTO, poCRUDMode As R_Common.eCRUDMode) As PYB01900Back.PYB01900DTO Implements R_BackEnd.R_IServicebase(Of PYB01900Back.PYB01900DTO).Svc_R_Save

    End Function
End Class

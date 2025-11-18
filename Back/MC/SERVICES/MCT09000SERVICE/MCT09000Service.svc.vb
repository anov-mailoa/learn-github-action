Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCT09000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT09000Service" in code, svc and config file together.
Public Class MCT09000Service
    Implements IMCT09000Service

    Public Sub Svc_R_Delete(poEntity As MCT09000Back.MCT09000Dto) Implements R_BackEnd.R_IServicebase(Of MCT09000Back.MCT09000Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT09000Back.MCT09000Dto) As MCT09000Back.MCT09000Dto Implements R_BackEnd.R_IServicebase(Of MCT09000Back.MCT09000Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As MCT09000Back.MCT09000Dto, poCRUDMode As R_Common.eCRUDMode) As MCT09000Back.MCT09000Dto Implements R_BackEnd.R_IServicebase(Of MCT09000Back.MCT09000Dto).Svc_R_Save

    End Function

    Public Function GetYear(pcCompId As String) As String Implements IMCT09000Service.GetYear
        Dim loEx As New R_Exception
        Dim loCls As New MCT09000Cls
        Dim loRtn As String

        Try
            loRtn = loCls.GetYear(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub CancelClaimProcess(ByRef poParam As MCT09000Back.MCT09000Dto) Implements IMCT09000Service.CancelClaimProcess
        Dim loEx As New R_Exception
        Dim loCls As New MCT09000Cls

        Try
            loCls.CancelClaimProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function CheckAllowCancel(pcCompanyId As String) As Integer Implements IMCT09000Service.CheckAllowCancel
        Dim iRtn As Integer
        Dim loCls As New MCT09000Cls
        Dim loEx As New R_Exception

        Try
            iRtn = loCls.CheckAllowCancel(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return iRtn
    End Function
End Class

Imports R_Common
Imports R_BackEnd
Imports PNT05200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT05200Service" in code, svc and config file together.
Public Class PNT05200Service
    Implements IPNT05200Service

    Public Sub Svc_R_Delete(poEntity As PNT05200Back.PNT05200DTO) Implements R_BackEnd.R_IServicebase(Of PNT05200Back.PNT05200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT05200Cls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT05200Back.PNT05200DTO) As PNT05200Back.PNT05200DTO Implements R_BackEnd.R_IServicebase(Of PNT05200Back.PNT05200DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PNT05200Cls
        Dim loRtn As PNT05200DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT05200Back.PNT05200DTO, poCRUDMode As R_Common.eCRUDMode) As PNT05200Back.PNT05200DTO Implements R_BackEnd.R_IServicebase(Of PNT05200Back.PNT05200DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New PNT05200Cls
        Dim loRtn As PNT05200DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PNT05200Back.PNT05200DTO) As PNT05200Back.PNT05200DTO Implements IPNT05200Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT05200Cls
        Dim loRtn As New PNT05200DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT05200Back.PNT05200DTO) As PNT05200Back.PNT05200DTO Implements IPNT05200Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT05200Cls
        Dim loRtn As New PNT05200DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkInterface(pcCompanyId As String) As PNT05200Back.PNT05200DTO Implements IPNT05200Service.checkInterface
        Dim loEx As New R_Exception
        Dim loCls As New PNT05200Cls
        Dim loRtn As New PNT05200DTO

        Try
            loRtn = loCls.checkInterface(pcCompanyId)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

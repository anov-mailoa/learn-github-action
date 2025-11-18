Imports R_BackEnd
Imports R_Common
Imports JCT01000Back
Imports JCT01000Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "JCT01000Service" in code, svc and config file together.
Public Class JCT01000Service
    Implements IJCT01000Service

    Public Sub Svc_R_Delete(poEntity As JCT01000Back.JCT01000Dto) Implements R_BackEnd.R_IServicebase(Of JCT01000Back.JCT01000Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As JCT01000Back.JCT01000Dto) As JCT01000Back.JCT01000Dto Implements R_BackEnd.R_IServicebase(Of JCT01000Back.JCT01000Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As JCT01000Back.JCT01000Dto, poCRUDMode As R_Common.eCRUDMode) As JCT01000Back.JCT01000Dto Implements R_BackEnd.R_IServicebase(Of JCT01000Back.JCT01000Dto).Svc_R_Save

    End Function

    Public Sub CloseEvaluationProcess(poParam As JCT01000Back.JCT01000Dto) Implements IJCT01000Service.CloseEvaluationProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000Cls

        Try
            loCls.CloseEvaluationProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub RejectEvaluationProcess(poParam As JCT01000Back.JCT01000Dto) Implements IJCT01000Service.RejectEvaluationProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000Cls

        Try
            loCls.RejectEvaluationProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub SendEmail(poParam As JCT01000Back.JCT01000Dto) Implements IJCT01000Service.SendEmail
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000Cls

        Try
            loCls.SendEmail(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function CheckExist(poParam As JCT01000Back.JCT01000Dto) As Integer Implements IJCT01000Service.CheckExist
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000Cls
        Dim iRtn As Integer = 0

        Try

            iRtn = loCls.CheckExist(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return iRtn
    End Function

    Public Function CheckCompetencies(poParam As JCT01000Back.JCT01000Dto) As Integer Implements IJCT01000Service.CheckCompetencies
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000Cls
        Dim iRtn As Integer = 0

        Try

            iRtn = loCls.CheckCompetencies(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return iRtn
    End Function
End Class

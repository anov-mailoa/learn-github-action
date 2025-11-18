Imports R_BackEnd
Imports R_Common
Imports JCM00200BACK
Imports JCM00200COMMON
' NOTE: You can use the "Rename" command on the context menu to change the class name "JCM00200Service" in code, svc and config file together.
Public Class JCM00200Service
    Implements IJCM00200Service

    Public Sub Svc_R_Delete(poEntity As JCM00200BACK.JCM00200DTO) Implements R_BackEnd.R_IServicebase(Of JCM00200BACK.JCM00200DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As JCM00200BACK.JCM00200DTO) As JCM00200BACK.JCM00200DTO Implements R_BackEnd.R_IServicebase(Of JCM00200BACK.JCM00200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New JCM00200Cls
        Dim loRtn As New JCM00200DTO

        Try

            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As JCM00200BACK.JCM00200DTO, poCRUDMode As R_Common.eCRUDMode) As JCM00200BACK.JCM00200DTO Implements R_BackEnd.R_IServicebase(Of JCM00200BACK.JCM00200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New JCM00200Cls
        Dim loRtn As New JCM00200DTO

        Try

            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetViewTemplate(poParam As JCM00200BACK.JCM00200DTO) As JCM00200BACK.JCM00200DTO Implements IJCM00200Service.GetViewTemplate
        Dim loEx As New R_Exception
        Dim loCls As New JCM00200Cls
        Dim loRtn As New JCM00200DTO

        Try

            loRtn = loCls.GetViewTemplate(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub UpdateFlag(poParam As JCM00200BACK.JCM00200DTO) Implements IJCM00200Service.UpdateFlag
        Dim loEx As New R_Exception
        Dim loCls As New JCM00200Cls

        Try

            loCls.UpdateFlag(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

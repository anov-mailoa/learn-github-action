Imports R_BackEnd
Imports R_Common
Imports QAM02000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM02000Service" in code, svc and config file together.
Public Class QAM02000Service
    Implements IQAM02000Service






    Public Sub Svc_R_Delete(poEntity As QAM02000Back.QAM02000DTO) Implements R_BackEnd.R_IServicebase(Of QAM02000Back.QAM02000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAM02000Back.QAM02000DTO) As QAM02000Back.QAM02000DTO Implements R_BackEnd.R_IServicebase(Of QAM02000Back.QAM02000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAM02000CLS

        Dim loRtn As New QAM02000DTO

        Try

            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAM02000Back.QAM02000DTO, poCRUDMode As R_Common.eCRUDMode) As QAM02000Back.QAM02000DTO Implements R_BackEnd.R_IServicebase(Of QAM02000Back.QAM02000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAM02000CLS

        Dim loRtn As New QAM02000DTO

        Try

            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetViewTemplate(poParam As QAM02000Back.QAM02000DTO) As QAM02000Back.QAM02000DTO Implements IQAM02000Service.GetViewTemplate
        Dim loEx As New R_Exception
        Dim loCls As New QAM02000CLS

        Dim loRtn As New QAM02000DTO

        Try

            loRtn = loCls.GetViewTemplate(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function



  
    Public Sub UpdateFlag(poParam As QAM02000Back.QAM02000DTO) Implements IQAM02000Service.UpdateFlag
        Dim loEx As New R_Exception
        Dim loCls As New QAM02000CLS



        Try

            loCls.UpdateFlag(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub
End Class

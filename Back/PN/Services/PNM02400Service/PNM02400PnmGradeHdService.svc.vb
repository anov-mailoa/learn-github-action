Imports R_Common
Imports R_BackEnd
Imports PNM02400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02400PnmGradeHdService" in code, svc and config file together.
Public Class PNM02400PnmGradeHdService
    Implements IPNM02400PnmGradeHdService

    Public Sub Svc_R_Delete(poEntity As PNM02400Back.PNM02400PnmGradeHdDTO) Implements R_BackEnd.R_IServicebase(Of PNM02400Back.PNM02400PnmGradeHdDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02400PnmGradeHdCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02400Back.PNM02400PnmGradeHdDTO) As PNM02400Back.PNM02400PnmGradeHdDTO Implements R_BackEnd.R_IServicebase(Of PNM02400Back.PNM02400PnmGradeHdDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PNM02400PnmGradeHdCls
        Dim loRtn As PNM02400PnmGradeHdDTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM02400Back.PNM02400PnmGradeHdDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02400Back.PNM02400PnmGradeHdDTO Implements R_BackEnd.R_IServicebase(Of PNM02400Back.PNM02400PnmGradeHdDTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New PNM02400PnmGradeHdCls
        Dim loRtn As PNM02400PnmGradeHdDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkDetail(poParam As PNM02400Back.PNM02400PnmGradeHdDTO) As Boolean Implements IPNM02400PnmGradeHdService.checkDetail
        Dim loException As New R_Exception
        Dim loCls As New PNM02400PnmGradeHdCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkDetail(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

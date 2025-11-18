Imports R_BackEnd
Imports R_Common
Imports ESM01500Back
Imports ESM01500Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01500Service" in code, svc and config file together.
Public Class ESM01500Service
    Implements IESM01500Service
    Public Sub Svc_R_Delete(poEntity As ESM01500Back.ESM01500DTO) Implements R_BackEnd.R_IServicebase(Of ESM01500Back.ESM01500DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM01500CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM01500Back.ESM01500DTO) As ESM01500Back.ESM01500DTO Implements R_BackEnd.R_IServicebase(Of ESM01500Back.ESM01500DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM01500CLS
        Dim loRtn As New ESM01500DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM01500Back.ESM01500DTO, poCRUDMode As R_Common.eCRUDMode) As ESM01500Back.ESM01500DTO Implements R_BackEnd.R_IServicebase(Of ESM01500Back.ESM01500DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM01500CLS
        Dim loRtn As New ESM01500DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getEmployeeName(poParam As ESM01500Back.ESM01500ParamDTO) As String Implements IESM01500Service.getEmployeeName
        Dim loEx As New R_Exception
        Dim loCls As New ESM01500CLS
        Dim loTemp As New List(Of ESM01500StreamingDTO)
        Dim loParam As New ESM01500ParamDTO
        Dim lcRtn As String = ""

        Try
            loTemp = loCls.getDelegateList(poParam)

            loTemp = (From x In loTemp
                    Where x.CEMPLOYEE_ID.Trim = poParam.CEMPLOYEE_ID.Trim
                    Select x).ToList

            If loTemp.Count > 0 Then
                lcRtn = loTemp.FirstOrDefault.CEMPLOYEE_NAME
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function

End Class

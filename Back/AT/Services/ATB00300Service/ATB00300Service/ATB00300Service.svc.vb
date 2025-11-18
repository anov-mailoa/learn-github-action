' NOTE: You can use the "Rename" command on the context menu to change the class name "ATB00300Service" in code, svc and config file together.
Imports R_Common
Imports R_BackEnd
Imports ATB00300Back
Imports ATB00300Common
Imports SIAPP_PUB_DTO
Public Class ATB00300Service
    Implements IATB00300Service


    Public Sub Svc_R_Delete(poEntity As ATB00300Back.ATB00300DTO) Implements R_BackEnd.R_IServicebase(Of ATB00300Back.ATB00300DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATB00300Back.ATB00300DTO) As ATB00300Back.ATB00300DTO Implements R_BackEnd.R_IServicebase(Of ATB00300Back.ATB00300DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATB00300Back.ATB00300DTO, poCRUDMode As R_Common.eCRUDMode) As ATB00300Back.ATB00300DTO Implements R_BackEnd.R_IServicebase(Of ATB00300Back.ATB00300DTO).Svc_R_Save

    End Function


    Public Function getDate(poParam As ATB00300Back.ATB00300DTO) As String Implements IATB00300Service.getDate
        Dim loEx As New R_Exception
        Dim loCLS As New ATB00300CLS
        Dim loRtn As String = Nothing

        Try

            loRtn = loCLS.getDate(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class

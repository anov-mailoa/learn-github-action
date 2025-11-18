Imports System.ServiceModel
Imports ATB00700Back
Imports R_Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATB00700Service" in code, svc and config file together.
Public Class ATB00700Service
    Implements IATB00700Service

    Public Sub Svc_R_Delete(poEntity As ATB00700Back.ATB00700DTO) Implements R_BackEnd.R_IServicebase(Of ATB00700Back.ATB00700DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATB00700Back.ATB00700DTO) As ATB00700Back.ATB00700DTO Implements R_BackEnd.R_IServicebase(Of ATB00700Back.ATB00700DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATB00700Back.ATB00700DTO, poCRUDMode As R_Common.eCRUDMode) As ATB00700Back.ATB00700DTO Implements R_BackEnd.R_IServicebase(Of ATB00700Back.ATB00700DTO).Svc_R_Save

    End Function

    Public Function getActualDt(pcCompId As String) As ATB00700Back.ATB00700DTO Implements IATB00700Service.getActualDt
        Dim loException As New R_Exception

        Try
            Dim loClass As New ATB00700Cls

            Return loClass.getActualDt(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class

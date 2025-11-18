' NOTE: You can use the "Rename" command on the context menu to change the class name "ATI00100Service" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports ATI00100Back
Imports R_Common
Imports R_Common.R_Utility
Public Class ATI00100Service
    Implements IATI00100Service



    Public Sub Svc_R_Delete(poEntity As ATI00100Back.ATI00100DTO) Implements R_BackEnd.R_IServicebase(Of ATI00100Back.ATI00100DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATI00100Back.ATI00100DTO) As ATI00100Back.ATI00100DTO Implements R_BackEnd.R_IServicebase(Of ATI00100Back.ATI00100DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ATI00100CLS
        Dim loRtn As ATI00100DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function Svc_R_Save(poEntity As ATI00100Back.ATI00100DTO, poCRUDMode As R_Common.eCRUDMode) As ATI00100Back.ATI00100DTO Implements R_BackEnd.R_IServicebase(Of ATI00100Back.ATI00100DTO).Svc_R_Save

    End Function
End Class

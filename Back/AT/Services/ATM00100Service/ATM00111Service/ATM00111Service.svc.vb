' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00111Service" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports ATM00100Back
Imports R_BackEnd
Imports R_Common
Imports R_Common.R_Utility
Imports ATM00100Common

Public Class ATM00111Service
    Implements IATM00111Service

    Public Sub DoWork() Implements IATM00111Service.DoWork
    End Sub

    Public Function getFormData(poparam As ATM00100Back.ATM00111DTO) As ATM00100Back.ATM00111NavDTO Implements IATM00111Service.getFormData
        Dim loEx As New R_Exception
        Dim loCLS As New ATM00111Cls
        Dim loRtn As Object
        Dim loEntity As New ATM00111DTO
        Dim loAtm0111Detail As New ATM00111NavDTO
        Dim loList As List(Of Byte())
        Try
            'With loEntity
            '    .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            '    .cEditDate = R_Utility.R_GetStreamingContext("cEditDate")
            'End With

            loAtm0111Detail = loCLS.getFormData(poparam)

            'If loAtm0111Detail IsNot Nothing Then
            '    loList = R_Utility.R_GetChunkData(Of ATM00111NavDTO)(loAtm0111Detail, R_BackGlobalVar.CHUNK_SIZE)
            '    loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getFormData")

            'End If

            loRtn = loAtm0111Detail
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Function
End Class

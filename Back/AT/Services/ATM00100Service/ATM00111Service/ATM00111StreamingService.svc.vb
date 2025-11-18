Imports System.ServiceModel.Channels
Imports ATM00100Back
Imports R_BackEnd
Imports R_Common
Imports R_Common.R_Utility
Imports ATM00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00111StreamingService" in code, svc and config file together.
Public Class ATM00111StreamingService
    Implements IATM00111StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATM00111StreamingService.getData
        Dim loEx As New R_Exception
        Dim loCLS As New ATM00111Cls
        Dim loRtn As Message = Nothing
        Dim loEntity As New ATM00111DTO
        Dim loAtm0111grid As List(Of ATM00111StreamingDTO)
        Dim loList As List(Of Byte())
        Try
            loEntity.cCompanyId = R_GetStreamingContext("cCompanyId")

            loAtm0111grid = loCLS.getData(loEntity)
            If loAtm0111grid IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of ATM00111StreamingDTO)(loAtm0111grid, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getData")
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    'Public Function getFormData() As System.ServiceModel.Channels.Message Implements IATM00111StreamingService.getFormData
    '    Dim loEx As New R_Exception
    '    Dim loCLS As New ATM00111Cls
    '    Dim loRtn As Object
    '    Dim loEntity As New ATM00111DTO
    '    Dim loAtm0111Detail As List(Of ATM00111NavDTO)
    '    Dim loList As List(Of Byte())
    '    Try
    '        With loEntity
    '            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
    '            .cEditDate = R_Utility.R_GetStreamingContext("cEditDate")
    '        End With

    '        loAtm0111Detail = loCLS.getFormData(loEntity)

    '        If loAtm0111Detail IsNot Nothing Then
    '            loList = R_Utility.R_GetChunkData(Of ATM00111NavDTO)(loAtm0111Detail, R_BackGlobalVar.CHUNK_SIZE)
    '            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getFormData")

    '        End If
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    Return loRtn
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Function

    'Public Sub Dummy(poParam2 As ATM00100Back.ATM00111DTO) Implements IATM00111StreamingService.Dummy

    'End Sub


End Class

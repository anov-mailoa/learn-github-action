Imports System.ServiceModel.Channels
Imports ATM00100Back
Imports ATM00100Common
Imports R_Common
Imports R_BackEnd
Imports R_Common.R_Utility
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00110StreamingService" in code, svc and config file together.
Public Class ATM00110StreamingService
    Implements IATM00110StreamingService

    Public Function getATM0110DetailList() As System.ServiceModel.Channels.Message Implements IATM00110StreamingService.getATM0110DetailList
        Dim loEx As New R_Exception
        Dim loAtm0110Detail As New List(Of ATM00110DetailStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEntity As New ATM00110DetailDTO
        Dim loList As List(Of Byte())

        Try

            Dim lcCoId As String = R_GetStreamingContext("CoId").ToString()
            Dim lcMachineType As String = R_GetStreamingContext("cMachineType").ToString()
            Dim loCls As New ATM00110DetailCls
            loEntity.cCompanyId = lcCoId
            loEntity.cMachineType = lcMachineType
            loAtm0110Detail = loCls.getATM0110DetailList(loEntity)

            If loAtm0110Detail IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of ATM00110DetailStreamingDTO)(loAtm0110Detail, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "ATM0110Detail")
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function

    Public Function getATM0110List() As System.ServiceModel.Channels.Message Implements IATM00110StreamingService.getATM0110List
        Dim loEx As New R_Exception
        Dim loAtm0110 As New List(Of ATM00110StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEntity As New ATM00110DTO
        Dim loList As List(Of Byte())

        Try

            Dim lcCoId As String = R_GetStreamingContext("CoId").ToString()
            Dim loCls As New ATM00110Cls
            loEntity.cCompanyId = lcCoId
            loAtm0110 = loCls.getATM0110List(loEntity)

            If loAtm0110 IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of ATM00110StreamingDTO)(loAtm0110, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "ATM0110")
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function

End Class

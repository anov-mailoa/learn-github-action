Imports System.ServiceModel.Channels
Imports ATM00150Back
Imports ATM00150Common
Imports R_Common
Imports R_Common.R_Utility
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00150StreamingService" in code, svc and config file together.
Public Class ATM00150StreamingService
    Implements IATM00150StreamingService

    Public Function getATM0150DetailList() As System.ServiceModel.Channels.Message Implements IATM00150StreamingService.getATM0150DetailList
        Dim loEx As New R_Exception
        Dim loAtm0150Detail As New List(Of ATM00150DetailStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEntity As New ATM00150DetailDTO
        Dim loList As List(Of Byte())


        Try

            Dim lcCoId As String = R_GetStreamingContext("CoId").ToString()
            Dim lcMachineType As String = R_GetStreamingContext("cMachineType").ToString()
            Dim loCls As New ATM00150DetailCLS
            loEntity.cCompanyId = lcCoId
            loEntity.cMachineType = lcMachineType
            loAtm0150Detail = loCls.getATM0150DetailList(loEntity)

            If loAtm0150Detail IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of ATM00150DetailStreamingDTO)(loAtm0150Detail, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "ATM0150Detail")
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function

    Public Function getATM0150List() As System.ServiceModel.Channels.Message Implements IATM00150StreamingService.getATM0150List
        Dim loEx As New R_Exception
        Dim loAtm0150 As New List(Of ATM00150StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEntity As New ATM00150DTO
        Dim loList As List(Of Byte())

        Try

            Dim lcCoId As String = R_GetStreamingContext("CoId").ToString()
            Dim loCls As New ATM00150CLS
            loEntity.cCompanyId = lcCoId
            loAtm0150 = loCls.getATM0150List(loEntity)

            If loAtm0150 IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of ATM00150StreamingDTO)(loAtm0150, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "ATM0150")
            End If
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        Return loRtn
    End Function



End Class

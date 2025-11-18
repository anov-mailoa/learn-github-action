Imports System.ServiceModel
Imports R_Common
Imports ATB00400Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports ATB00400Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATB00400StreamingService" in code, svc and config file together.
Public Class ATB00400StreamingService
    Implements IATB00400StreamingService
     
    Public Function getMasterWorkTable() As System.ServiceModel.Channels.Message Implements IATB00400StreamingService.getMasterWorkTable
        Dim loEx As New R_Exception
        Dim loCls As New ATB00400Cls
        Dim loRtnTemp As List(Of ATB00400StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATB00400DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            'loRtnTemp = loCls.getMasterWorkTable(loParam)

            loRtn = R_StreamUtility(Of ATB00400StreamDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getMasterWorkTable")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetResultPreviewProcess() As System.ServiceModel.Channels.Message Implements IATB00400StreamingService.GetResultPreviewProcess
        Dim loRtn As Message
        Dim loCls As New ATB00400Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATB00400DTO
        Dim loRtnTemp As List(Of ATB00400StreamDTO)
        Dim loList As List(Of Byte())

        Try
            With poParam
                .COMPANY_ID = R_Utility.R_GetStreamingContext("COMPANY_ID")
                .USER_ID = R_Utility.R_GetStreamingContext("USER_ID")
                .KEY_GUID = R_Utility.R_GetStreamingContext("KEY_GUID")
            End With

            loRtnTemp = loCls.GetResultPreviewProcess(poParam)

            loList = R_Utility.R_GetChunkData(Of ATB00400StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetResultPreviewProcess")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
     
    Public Sub Dummy() Implements IATB00400StreamingService.Dummy

    End Sub

End Class

Imports R_Common
Imports R_BackEnd
Imports GSM00400Back
Imports GSM00400Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM00400StreamingService" in code, svc and config file together.
Public Class GSM00400StreamingService
    Implements IGSM00400StreamingService

    Public Function getGridCenter() As System.ServiceModel.Channels.Message Implements IGSM00400StreamingService.getGridCenter
        Dim loException As New R_Exception
        Dim loCls As New GSM00400Cls
        Dim loRtnTemp As List(Of GSM00400CenterGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00400DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getGridCenter(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00400CenterGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridCenter")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridDept() As System.ServiceModel.Channels.Message Implements IGSM00400StreamingService.getGridDept
        Dim loException As New R_Exception
        Dim loCls As New GSM00400Cls
        Dim loRtnTemp As List(Of GSM00400DeptGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00400DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCenterCode = R_Utility.R_GetStreamingContext("cCenterCode")
            End With

            loRtnTemp = loCls.getGridDept(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00400DeptGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridDept")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of GSM00400Back.GSM00400DeptGridDTO)) Implements IGSM00400StreamingService.Dummy

    End Sub
End Class

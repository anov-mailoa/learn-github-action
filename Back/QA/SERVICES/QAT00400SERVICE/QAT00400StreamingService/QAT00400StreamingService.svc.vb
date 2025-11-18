Imports R_BackEnd
Imports R_Common
Imports QAT00400Back
Imports QAT00400Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00400StreamingService" in code, svc and config file together.
Public Class QAT00400StreamingService
    Implements IQAT00400StreamingService

    Public Function getLoadGrid() As System.ServiceModel.Channels.Message Implements IQAT00400StreamingService.getLoadGrid
        Dim loException As New R_Exception
        Dim loCls As New QAT00400CLS
        Dim loRtn As New List(Of QAT00400StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAT00400DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            poParam.cLoginId = R_Utility.R_GetStreamingContext("cLoginId")

            loRtn = loCls.getLoadGrid(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLoadGrid")
            
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetCmbDepartment() As System.ServiceModel.Channels.Message Implements IQAT00400StreamingService.GetCmbDepartment
        Dim loException As New R_Exception
        Dim loCls As New QAT00400CLS
        Dim loRtnTemp As List(Of QAT00400ComboboxDTO)
        Dim loParam As New QAT00400DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLoginId = R_Utility.R_GetStreamingContext("cLoginId")
            .iDocOwnerLevel = R_Utility.R_GetStreamingContext("iDocOwnerLevel")
        End With

        Try
            loRtnTemp = loCls.GetCmbDepartment(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT00400ComboboxDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbDepartment")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


End Class

Imports R_Common
Imports R_BackEnd
Imports QAT00700Back
Imports QAT00700Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00700StreamService" in code, svc and config file together.
Public Class QAT00700StreamService
    Implements IQAT00700StreamService

    Public Function GetATTACHMENTS() As System.ServiceModel.Channels.Message Implements IQAT00700StreamService.GetATTACHMENTS
        Dim loException As New R_Exception
        Dim loCls As New QAT00700Cls
        Dim loRtnTemp As List(Of QAT00700Grid2Dto)
        Dim loParam As New QAT00700Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
        End With

        Try
            loRtnTemp = loCls.GetATTACHMENTS(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT00700Grid2Dto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetATTACHMENTS")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetDEPARTMENT_USER() As System.ServiceModel.Channels.Message Implements IQAT00700StreamService.GetDEPARTMENT_USER
        Dim loException As New R_Exception
        Dim loCls As New QAT00700Cls
        Dim loRtnTemp As List(Of QAT00700StreamDto)
        Dim loParam As New QAT00700Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLoginId = R_Utility.R_GetStreamingContext("cLoginId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .iDeptLevel = R_Utility.R_GetStreamingContext("iDeptLevel")
        End With

        Try
            loRtnTemp = loCls.GetDEPARTMENT_USER(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT00700StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDEPARTMENT_USER")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetDOCUMENTS() As System.ServiceModel.Channels.Message Implements IQAT00700StreamService.GetDOCUMENTS
        Dim loException As New R_Exception
        Dim loCls As New QAT00700Cls
        Dim loRtnTemp As List(Of QAT00700StreamDto)
        Dim loParam As New QAT00700Dto
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
        End With

        Try
            loRtnTemp = loCls.GetDOCUMENTS(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT00700StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDOCUMENTS")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar2 As System.Collections.Generic.List(Of QAT00700Back.QAT00700Grid2Dto)) Implements IQAT00700StreamService.Dummy

    End Sub

End Class

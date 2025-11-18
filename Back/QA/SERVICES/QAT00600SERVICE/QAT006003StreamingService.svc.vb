Imports R_BackEnd
Imports R_Common
Imports QAT00600Back
Imports QAT00600Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT006003StreamingService" in code, svc and config file together.
Public Class QAT006003StreamingService
    Implements IQAT006003StreamingService

    Public Function getSocDocNameList() As System.ServiceModel.Channels.Message Implements IQAT006003StreamingService.getSocDocNameList
        Dim loException As New R_Exception
        Dim loCls As New QAT006003Cls
        Dim loRtnTemp As List(Of QAT006003StreamDTO)
        Dim loRtn As Message
        Dim loParam As New QAT006003DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getSocDocNameList(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT006003StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSocDocNameList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSocAttachList() As System.ServiceModel.Channels.Message Implements IQAT006003StreamingService.getSocAttachList
        Dim loException As New R_Exception
        Dim loCls As New QAT006003Cls
        Dim loRtnTemp As List(Of QAT006003StreamDTO)
        Dim loRtn As Message
        Dim loParam As New QAT006003DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getSocAttachList(loParam)
            loList = R_Utility.R_GetChunkData(Of QAT006003StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSocAttachList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

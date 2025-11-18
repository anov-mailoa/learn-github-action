' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00100StreamingService" in code, svc and config file together.
Imports R_Common
Imports QAM00100Back
Imports System.ServiceModel.Channels
Imports QAM00100Common
Imports R_BackEnd
Public Class QAM00100StreamingService
    Implements IQAM00100StreamingService

    Public Function GetCmbDepartmentLevel() As System.ServiceModel.Channels.Message Implements IQAM00100StreamingService.GetCmbDepartmentLevel
        Dim loException As New R_Exception
        Dim loCls As New QAM00100CLS
        Dim loRtnTemp As List(Of QAM00100ComboboxDTO)
        Dim loParam As New QAM00100DTO
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
        End With

        Try
            loRtnTemp = loCls.GetCmbDepartmentLevel(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM00100ComboboxDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetCmbDepartmentLevel")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbLoadQA() As System.ServiceModel.Channels.Message Implements IQAM00100StreamingService.GetCmbLoadQA
        Dim loException As New R_Exception
        Dim loCls As New QAM00100CLS
        Dim loRtnTemp As List(Of QAM00100ComboboxDTO)
        Dim loParam As New QAM00100DTO
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .iDeptLevel = R_Utility.R_GetStreamingContext("iDeptLevel")
        End With

        Try
            loRtnTemp = loCls.GetCmbLoadQA(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM00100ComboboxDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetCmbLoadQA")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

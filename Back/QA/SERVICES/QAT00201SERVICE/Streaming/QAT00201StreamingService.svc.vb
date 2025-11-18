Imports R_Common
Imports R_BackEnd
Imports QAT00201Back
Imports QAT00201Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00201StreamingService" in code, svc and config file together.
Public Class QAT00201StreamingService
    Implements IQAT00201StreamingService


    Public Function getDocOwnerList() As System.ServiceModel.Channels.Message Implements IQAT00201StreamingService.getDocOwnerList
        Dim loException As New R_Exception
        Dim loCls As New QAT00201CLS
        Dim poParam As New QAT00201DTO
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getDocOwnerList(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDocOwnerList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRevDocList() As System.ServiceModel.Channels.Message Implements IQAT00201StreamingService.getRevDocList
        Dim loException As New R_Exception
        Dim loCls As New QAT00201CLS
        Dim poParam As New QAT00201DTO
        Dim loRtnList As New List(Of QAT00201StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cVarTransCode = R_Utility.R_GetStreamingContext("cVarTransCode")
                .cVarProgramId = R_Utility.R_GetStreamingContext("cVarProgramId")
            End With

            loRtnList = loCls.getRevDocList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT00201StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRevDocList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


End Class

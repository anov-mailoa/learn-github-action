Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNM02300Back
Imports PNM02300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02300StreamingService" in code, svc and config file together.
Public Class PNM02300StreamingService
    Implements IPNM02300StreamingService

    Public Function getTrainingCategories() As System.ServiceModel.Channels.Message Implements IPNM02300StreamingService.getTrainingCategories
        Dim loCls As New PNM02300HeaderCLS
        Dim poParam As New PNM02300HeaderDTO
        Dim loRtnTemp As List(Of PNM02300StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getTrainingCategories(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTrainingCategories")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTrainingSubject() As System.ServiceModel.Channels.Message Implements IPNM02300StreamingService.getTrainingSubject
        Dim loCls As New PNM02300DetailCLS
        Dim poParam As New PNM02300DetailDTO
        Dim loRtnTemp As List(Of PNM02300StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCatTrainingCode = R_Utility.R_GetStreamingContext("cCatTrainingCode")
                '.lCbInactive = R_Utility.R_GetStreamingContext("lCbInactive")
            End With

            loRtnTemp = loCls.getTrainingSubject(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTrainingSubject")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getData() As System.ServiceModel.Channels.Message Implements IPNM02300StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New PNM02300DetailCLS
        Dim loRtnTemp As List(Of PNM02300ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM02300DetailDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02300ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

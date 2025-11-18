Imports System.ServiceModel.Channels
Imports R_Common
Imports PYB06000Back
Imports PYB06000Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB06000StreamingService" in code, svc and config file together.
Public Class PYB06000StreamingService
    Implements IPYB06000StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYB06000StreamingService.getGrupGaji
        Dim loException As New R_Exception
        Dim loCls As New PYB06000CLS
        Dim poParam As New PYB06000DTO
        Dim loRtnList As New List(Of PYB06000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB06000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYB06000StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PYB06000CLS
        Dim poParam As New PYB06000DTO
        Dim loRtnList As New List(Of PYB06000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReportType = R_Utility.R_GetStreamingContext("cReportType")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.getReportData(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB06000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            loException.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn
    End Function

    Public Function getPeriod() As System.ServiceModel.Channels.Message Implements IPYB06000StreamingService.getPeriod
        Dim loException As New R_Exception
        Dim loCls As New PYB06000CLS
        Dim poParam As New PYB06000DTO
        Dim loRtnList As New List(Of PYB06000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getPeriod(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB06000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriod")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYB06000Back.PYB06000DTO)) Implements IPYB06000StreamingService.Dummy

    End Sub
End Class

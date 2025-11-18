Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR04000Common
Imports PYR04000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR04000StreamingService" in code, svc and config file together.
Public Class PYR04000StreamingService
    Implements IPYR04000StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR04000StreamingService.getGrupGaji
        Dim loException As New R_Exception
        Dim loCls As New PYR04000CLS
        Dim poParam As New PYR04000DTO
        Dim loRtnList As New List(Of PYR04000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cLookUpLanguage = R_Utility.R_GetStreamingContext("cLookUpLanguage")
            End With

            loRtnList = loCls.getGrupGaji(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR04000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR04000StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PYR04000CLS
        Dim poParam As New PYR04000DTO
        Dim loRtnList As New List(Of PYR04000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cJamsostekCode = R_Utility.R_GetStreamingContext("cJamsostekCode")
                .cNomorJamsostekPerusahaan = R_Utility.R_GetStreamingContext("cNomorJamsostekPerusahaan")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
                .cReportType = R_Utility.R_GetStreamingContext("cReportType")
                If .cReportType = "4" Then
                    .lBaru = R_Utility.R_GetStreamingContext("lBaru")
                    .lKeluar = R_Utility.R_GetStreamingContext("lKeluar")
                    .lNaik = R_Utility.R_GetStreamingContext("lNaik")
                    .lTurun = R_Utility.R_GetStreamingContext("lTurun")
                End If
            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR04000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPeriod() As System.ServiceModel.Channels.Message Implements IPYR04000StreamingService.getPeriod
        Dim loException As New R_Exception
        Dim loCls As New PYR04000CLS
        Dim poParam As New PYR04000DTO
        Dim loRtnList As New List(Of PYR04000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim pcCompId As String

        Try
            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnList = loCls.getPeriod(pcCompId)
            loList = R_Utility.R_GetChunkData(Of PYR04000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriod")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PYR04000Back.PYR04000DTO), poParam2 As System.Collections.Generic.List(Of PYR04000Back.PYR04001DTO), poParam3 As System.Collections.Generic.List(Of PYR04000Back.PYR04002DTO), poParam4 As System.Collections.Generic.List(Of PYR04000Back.PYR04003DTO), poParam5 As System.Collections.Generic.List(Of PYR04000Back.PYR04004DTO), poParam6 As System.Collections.Generic.List(Of PYR04000Back.PYR04005DTO), poParam7 As System.Collections.Generic.List(Of PYR04000Back.PYR04006DTO), poParam8 As System.Collections.Generic.List(Of PYR04000Back.PYR04007DTO), poParam9 As System.Collections.Generic.List(Of PYR04000Back.PYR04008DTO), poParam10 As System.Collections.Generic.List(Of PYR04000Back.PYR04000DetilPerusahaanDTO)) Implements IPYR04000StreamingService.Dummy

    End Sub
End Class

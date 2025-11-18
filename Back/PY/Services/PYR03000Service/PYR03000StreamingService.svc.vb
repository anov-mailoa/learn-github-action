Imports R_BackEnd
Imports R_Common
Imports PYR03000Common
Imports PYR03000Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR03000StreamingService" in code, svc and config file together.
Public Class PYR03000StreamingService
    Implements IPYR03000StreamingService

    Public Function GetReportData() As System.ServiceModel.Channels.Message Implements IPYR03000StreamingService.GetReportData
        Dim loCls As New PYR03000CLS
        Dim loEx As New R_Exception
        Dim poParam As New PYR03000DTO
        Dim loRtnList As New List(Of PYR03000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cSptPeriod = R_Utility.R_GetStreamingContext("cSptPeriod")
                .cCompanyTaxIdList = R_Utility.R_GetStreamingContext("cCompanyTaxIdList")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .cReportForm = R_Utility.R_GetStreamingContext("cReportForm")
                .lIsEmployee = R_Utility.R_GetStreamingContext("lIsEmployee")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")

                .cReportYear = R_Utility.R_GetStreamingContext("cReportYear")
                .cReportMonth = R_Utility.R_GetStreamingContext("cReportMonth")
                .cSptPeriodType = R_Utility.R_GetStreamingContext("cSptPeriodType")
            End With

            loRtnList = loCls.GetReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR03000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCompanyTaxId() As System.ServiceModel.Channels.Message Implements IPYR03000StreamingService.getCompanyTaxId
        Dim loException As New R_Exception
        Dim loCls As New PYR03000CLS
        Dim poParam As New PYR03000DTO
        Dim loRtnList As New List(Of PYR03000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getCompanyTaxId(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR03000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCompanyTaxId")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR03000StreamingService.getGrupGaji
        Dim loException As New R_Exception
        Dim loCls As New PYR03000CLS
        Dim poParam As New PYR03000DTO
        Dim loRtnList As New List(Of PYR03000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cSptPeriod = R_Utility.R_GetStreamingContext("cSptPeriod")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR03000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSptPeriod() As System.ServiceModel.Channels.Message Implements IPYR03000StreamingService.getSptPeriod
        Dim loException As New R_Exception
        Dim loCls As New PYR03000CLS
        Dim poParam As New PYR03000DTO
        Dim loRtnList As New List(Of PYR03000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getSptPeriod(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR03000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSptPeriod")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSptSetting(poParam As PYR03000Back.PYR03000DTO) As PYR03000Back.PYR03000DTO Implements IPYR03000StreamingService.getSptSetting
        Dim loEx As New R_Exception
        Dim loCls As New PYR03000CLS
        Dim loRtnTemp As New PYR03000DTO

        Try
            loRtnTemp = loCls.getSptSetting(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnTemp
    End Function
End Class

Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNM04100Back
Imports PNM04100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM04100StreamingService" in code, svc and config file together.
Public Class PNM04100StreamingService
    Implements IPNM04100StreamingService

    Public Function getPnmOrgStructure() As System.ServiceModel.Channels.Message Implements IPNM04100StreamingService.getPnmOrgStructure
        Dim loCls As New PNM04100PnmFacilitiesCls
        Dim loRtnTemp As List(Of PNM04100PnmFacilitiesStreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM04100PnmFacilitiesDto
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cMonitoringBy = R_Utility.R_GetStreamingContext("cMonitoringBy")
            End With

            loRtnTemp = loCls.getPnmOrgStructure(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM04100PnmFacilitiesStreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmOrgStructure")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListOfFacilities() As System.ServiceModel.Channels.Message Implements IPNM04100StreamingService.getListOfFacilities
        Dim loCls As New PNM04100PnmFacilitiesCls
        Dim poParam As New PNM04100PnmFacilitiesDto
        Dim loRtnTemp As List(Of PNM04100PnmFacilitiesStreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                '.lFlag = R_Utility.R_GetStreamingContext("lFlag")

            End With

            loRtnTemp = loCls.getListOfFacilities(poParam)

            ' If there is data, convert to Message
            If loRtnTemp IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of PNM04100PnmFacilitiesStreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListOfFacilities")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListOfPositions() As System.ServiceModel.Channels.Message Implements IPNM04100StreamingService.getListOfPositions
        Dim loCls As New PNM04100PositionsCls
        Dim loParam As New PNM04100PositionsDto
        Dim loRtnTemp As List(Of PNM04100PnmFacilitiesStreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFacilityCode = R_Utility.R_GetStreamingContext("cFacilityCode")


            End With

            loRtnTemp = loCls.getListOfPositions(loParam)

            ' If there is data, convert to Message
            If loRtnTemp IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of PNM04100PnmFacilitiesStreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListOfPositions")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPnmOrgStructureP() As System.ServiceModel.Channels.Message Implements IPNM04100StreamingService.getPnmOrgStructureP
        Dim loCls As New PNM04100PositionsCls
        Dim loRtnTemp As List(Of PNM04100PnmFacilitiesStreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM04100PositionsDto
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getPnmOrgStructureP(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM04100PnmFacilitiesStreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmOrgStructureP")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPnmOrgStructurePDet() As System.ServiceModel.Channels.Message Implements IPNM04100StreamingService.getPnmOrgStructurePDet
        Dim loCls As New PNM04100PositionsCls
        Dim loRtnTemp As List(Of PNM04100PnmFacilitiesStreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM04100PositionsDto
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            End With

            loRtnTemp = loCls.getPnmOrgStructurePDet(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM04100PnmFacilitiesStreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmOrgStructurePDet")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListOfBatch() As System.ServiceModel.Channels.Message Implements IPNM04100StreamingService.getListOfBatch
        Dim loCls As New PNM04100BatchCls
        Dim loParam As New PNM04100BatchDto
        Dim loRtnTemp As List(Of PNM04100PnmFacilitiesStreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFacilityCode = R_Utility.R_GetStreamingContext("cFacilityCode")
                ' .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            End With

            loRtnTemp = loCls.getListOfBatch(loParam)

            ' If there is data, convert to Message
            If loRtnTemp IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of PNM04100PnmFacilitiesStreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListOfBatch")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getExcelData() As System.ServiceModel.Channels.Message Implements IPNM04100StreamingService.getExcelData
        Dim loException As New R_Exception
        Dim loCls As New PNM04100ExcelCls
        Dim poParam As New PNM04100PnmFacilitiesDto
        Dim loRtnTemp As List(Of PNM04100PnmFacilitiesStreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getExcelData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM04100PnmFacilitiesStreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExcelData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNM04100StreamingService.getReportData
        Dim loCls As New PNM04100PnmFacilitiesCls
        Dim loRtnTemp As List(Of PNM04100ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM04100PnmFacilitiesDto
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            End With

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM04100ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of PNM04100Back.PNM04100PnmFacilitiesGridDto)) Implements IPNM04100StreamingService.Dummy

    End Sub

End Class

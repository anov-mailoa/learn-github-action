Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNT03100Common
Imports PNT03100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT03100StreamingService" in code, svc and config file together.
Public Class PNT03100StreamingService
    Implements IPNT03100StreamingService

    Public Function RFT_GET_STATCHANGE_EMPLOYEE_TYPES() As System.ServiceModel.Channels.Message Implements IPNT03100StreamingService.RFT_GET_STATCHANGE_EMPLOYEE_TYPES
        Dim loEx As New R_Exception
        Dim loCls As New PNT03100Cls
        Dim loRtnTemp As List(Of PNT03100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PNT03100DTO

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("COMPID")
            loParam.cEmployeeType = R_Utility.R_GetStreamingContext("EMPTYP")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("CULTID")

            loRtnTemp = loCls.RFT_GET_STATCHANGE_EMPLOYEE_TYPES(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PNT03100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_STATCHANGE_EMPLOYEE_TYPES")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbGrade() As System.ServiceModel.Channels.Message Implements IPNT03100StreamingService.getCmbGrade
        Dim loCls As New PNT03100Cls
        Dim loRtnTemp As List(Of PNT03100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT03100DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGrade = R_Utility.R_GetStreamingContext("cGrade")
                .cSubGrade = R_Utility.R_GetStreamingContext("cSubGrade")
            End With

            loRtnTemp = loCls.getCmbGrade(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbGrade")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNT03100StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New PNT03100Cls
        Dim poParam As New PNT03100DTO
        Dim loRtnTemp As List(Of PNT03100ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cReferenceDate = R_Utility.R_GetStreamingContext("cReferenceDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT03100ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

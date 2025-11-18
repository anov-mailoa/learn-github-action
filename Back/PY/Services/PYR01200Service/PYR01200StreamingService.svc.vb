Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYR01200Common
Imports PYR01200Back
Imports SIAPP_SERVICE_PY

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR01200StreamingService" in code, svc and config file together.
Public Class PYR01200StreamingService
    Implements IPYR01200StreamingService

    Public Function getGrupGaji() As System.ServiceModel.Channels.Message Implements IPYR01200StreamingService.getGrupGaji
        Dim loException As New R_Exception
        Dim loCls As New PYR01200CLS
        Dim poParam As New PYR01200DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR01200StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getGrupGaji(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGrupGaji")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYR01200StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PYR01200CLS
        Dim poParam As New PYR01200DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR01200ReportDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .lShowResignEmp = R_Utility.R_GetStreamingContext("lShowResignEmp")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
            End With

            loRtnList = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01200ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            loException.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PYR01200Back.PYR01200DTO)) Implements IPYR01200StreamingService.Dummy

    End Sub

    Public Function getExcelData() As Message Implements IPYR01200StreamingService.getExcelData
        Dim loException As New R_Exception
        Dim loCls As New PYR01200CLS
        Dim poParam As New PYR01200DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR01200ReportDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .cSalaryGroupList = R_Utility.R_GetStreamingContext("cSalaryGroupList")
                .cEmployeeIdList = R_Utility.R_GetStreamingContext("cEmployeeIdList")
                .lShowResignEmp = R_Utility.R_GetStreamingContext("lShowResignEmp")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEncryptionKey = R_Utility.R_GetStreamingContext("cEncryptionKey")
            End With

            loRtnList = loCls.getExcelData(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR01200ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExcelData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            loException.ConvertAndThrowToServiceExceptionIfErrors()
        End If

        Return loRtn
    End Function
End Class

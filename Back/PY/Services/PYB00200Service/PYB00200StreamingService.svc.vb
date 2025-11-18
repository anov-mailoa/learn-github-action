Imports R_Common
Imports PYB00200Back
Imports System.ServiceModel.Channels
Imports PYB00200Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB00200StreamingService" in code, svc and config file together.
Public Class PYB00200StreamingService
    Implements IPYB00200StreamingService

    Public Function GetGvEmployeeGroup() As System.ServiceModel.Channels.Message Implements IPYB00200StreamingService.GetGvEmployeeGroup
        Dim loEx As New R_Exception
        Dim loCls As New PYB00200Cls
        Dim loRtnTemp As List(Of PYB00200Grid_S)
        Dim loRtn As Message
        Dim loParam As New PYB00200Dto

        Try
            With loParam
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.GetGvEmployeeGroup(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00200Grid_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetGvEmployeeGroup")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetGvResignEmployee() As System.ServiceModel.Channels.Message Implements IPYB00200StreamingService.GetGvResignEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYB00200Cls
        Dim loRtnTemp As List(Of PYB00200Grid_S)
        Dim loRtn As Message
        Dim loParam As New PYB00200Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .lEmpSalaryResignProcess = R_Utility.R_GetStreamingContext("lEmpSalaryResignProcess")
            End With

            loRtnTemp = loCls.GetGvResignEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00200Grid_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetGvResignEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetGvSalaryProcess() As System.ServiceModel.Channels.Message Implements IPYB00200StreamingService.GetGvSalaryProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYB00200Cls
        Dim loRtnTemp As List(Of PYB00200Grid_S)
        Dim loRtn As Message
        Dim loParam As New PYB00200Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cProcessType = R_Utility.R_GetStreamingContext("cProcessType")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cProcessStatus = R_Utility.R_GetStreamingContext("cProcessStatus")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.GetGvSalaryProcess(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00200Grid_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetGvSalaryProcess")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetGvResignSalaryProcess() As System.ServiceModel.Channels.Message Implements IPYB00200StreamingService.GetGvResignSalaryProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYB00200Cls
        Dim loRtnTemp As List(Of PYB00200Grid_S)
        Dim loRtn As Message
        Dim loParam As New PYB00200Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.GetGvResignSalaryProcess(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00200Grid_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetGvResignSalaryProcess")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbProcessCode() As System.ServiceModel.Channels.Message Implements IPYB00200StreamingService.getCmbProcessCode
        Dim loEx As New R_Exception
        Dim loCls As New PYB00200Cls
        Dim loRtnTemp As List(Of PYB00200Grid_S)
        Dim loRtn As Message
        Dim loParam As New PYB00200Dto

        Try
            With loParam
                .cActivePeriod = R_Utility.R_GetStreamingContext("cActivePeriod")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getCmbProcessCode(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00200Grid_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbProcessCode")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbSalaryGroup() As System.ServiceModel.Channels.Message Implements IPYB00200StreamingService.getCmbSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New PYB00200Cls
        Dim loRtnTemp As List(Of PYB00200Grid_S)
        Dim loRtn As Message
        Dim loParam As New PYB00200Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getCmbSalaryGroup(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00200Grid_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbSalaryGroup")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridEmployee() As System.ServiceModel.Channels.Message Implements IPYB00200StreamingService.getGridEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYB00200Cls
        Dim loRtnTemp As List(Of PYB00200Grid_S)
        Dim loRtn As Message
        Dim loParam As New PYB00200Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cActivePeriod = R_Utility.R_GetStreamingContext("cActivePeriod")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .lFromLookup = R_Utility.R_GetStreamingContext("lFromLookup")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getGridEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00200Grid_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYB00200StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYB00200Cls
        Dim loRtnTemp As List(Of PYB00200ReportDTO)
        Dim loRtn As Message
        Dim loParam As New PYB00200Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEmpList = R_Utility.R_GetStreamingContext("cEmpList")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getReportData(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00200ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

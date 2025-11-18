Imports R_Common
Imports PYB05000Back
Imports System.ServiceModel.Channels
Imports PYB05000Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB05000StreamingService" in code, svc and config file together.
Public Class PYB05000StreamingService
    Implements IPYB05000StreamingService

    Public Function GetGvSalaryProcess() As System.ServiceModel.Channels.Message Implements IPYB05000StreamingService.GetGvSalaryProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYB05000Cls
        Dim loRtnTemp As List(Of PYB05000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB05000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cProcessIndex = R_Utility.R_GetStreamingContext("cProcessIndex")
                .cCompanyBankCode = R_Utility.R_GetStreamingContext("cCompanyBankCode")
                .cCompanyBankNo = R_Utility.R_GetStreamingContext("cCompanyBankNo")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.GetGvSalaryProcess(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB05000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetGvSalaryProcess")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTemplateList() As System.ServiceModel.Channels.Message Implements IPYB05000StreamingService.getTemplateList
        Dim loEx As New R_Exception
        Dim loCls As New PYB05000Cls
        Dim loRtnTemp As List(Of PYB05000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB05000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getTemplateList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB05000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTemplateList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getBankTransferData() As System.ServiceModel.Channels.Message Implements IPYB05000StreamingService.getBankTransferData
        Dim loEx As New R_Exception
        Dim loCls As New PYB05000Cls
        Dim loRtnTemp As New DataTable
        Dim loRtn As Message
        Dim loParam As New PYB05000DTO

        Dim loRtnList1 As New List(Of DataTable)

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cGuid = R_Utility.R_GetStreamingContext("cGuid")
            End With

            loRtnTemp = loCls.getBankTransferData(loParam)

            loRtnList1.Add(loRtnTemp)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of DataTable)(loRtnList1, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBankTransferData")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbBank() As System.ServiceModel.Channels.Message Implements IPYB05000StreamingService.getCmbBank
        Dim loEx As New R_Exception
        Dim loCls As New PYB05000Cls
        Dim loRtnTemp As List(Of PYB05000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB05000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbBank(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB05000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbBank")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYB05000Back.PYB05000DTO)) Implements IPYB05000StreamingService.Dummy

    End Sub

    Public Function Get_ProcessPeriod() As System.ServiceModel.Channels.Message Implements IPYB05000StreamingService.Get_ProcessPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYB05000Cls
        Dim loRtnTemp As List(Of PYB05000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB05000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriodType = R_Utility.R_GetStreamingContext("cPeriodType")
            End With

            loRtnTemp = loCls.Get_ProcessPeriod(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB05000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "Get_ProcessPeriod")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

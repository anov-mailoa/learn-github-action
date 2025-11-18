Imports R_Common
Imports R_BackEnd
Imports JCT00200Back
Imports JCT00200Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "JCT00200StreamingService" in code, svc and config file together.
Public Class JCT00200StreamingService
    Implements IJCT00200StreamingService

    Public Function getComboDept() As System.ServiceModel.Channels.Message Implements IJCT00200StreamingService.getComboDept
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls
        Dim loRtnTemp As List(Of ComboBoxDto)
        Dim loRtn As Message
        Dim pcCompId, pcUserId As String
        Try
            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtnTemp = loCls.getComboDept(pcCompId, pcUserId)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ComboBoxDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getComboDept")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListEmployee() As System.ServiceModel.Channels.Message Implements IJCT00200StreamingService.getListEmployee
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls
        Dim loRtnTemp As List(Of EmployeeStreamDto)
        Dim loRtn As Message
        Dim loParam As New JCT00200Dto
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cPosition = R_Utility.R_GetStreamingContext("cPosition")
            End With
            loRtnTemp = loCls.getListEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of EmployeeStreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getProbation() As System.ServiceModel.Channels.Message Implements IJCT00200StreamingService.getProbation
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls
        Dim loRtnTemp As List(Of ProbationStreamDto)
        Dim loRtn As Message
        Dim pcCompId, pcUserId As String
        Try
            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcUserId = R_Utility.R_GetStreamingContext("cUserId")
            loRtnTemp = loCls.getProbation(pcCompId, pcUserId)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ProbationStreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProbation")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransactionList() As System.ServiceModel.Channels.Message Implements IJCT00200StreamingService.getTransactionList
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls
        Dim loRtnTemp As List(Of TransactionStreamDto)
        Dim loRtn As Message
        Dim loParam As New JCT00200Dto
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With
            loRtnTemp = loCls.getTransactionList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of TransactionStreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransactionList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

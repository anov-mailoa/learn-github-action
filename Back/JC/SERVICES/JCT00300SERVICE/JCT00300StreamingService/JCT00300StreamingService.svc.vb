Imports R_Common
Imports R_BackEnd
Imports JCT00300Back
Imports System.ServiceModel.Channels
Imports JCT00300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "JCT00300StreamingService" in code, svc and config file together.
Public Class JCT00300StreamingService
    Implements IJCT00300StreamingService

    Public Function getComboDept() As System.ServiceModel.Channels.Message Implements IJCT00300StreamingService.getComboDept
        Dim loEx As New R_Exception
        Dim loCls As New JCT00300Cls
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

    Public Function getListEmployee() As System.ServiceModel.Channels.Message Implements IJCT00300StreamingService.getListEmployee
        Dim loEx As New R_Exception
        Dim loCls As New JCT00300Cls
        Dim loRtnTemp As List(Of EmployeeStreamDto)
        Dim loRtn As Message
        Dim loParam As New JCT00300DTO
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
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

    Public Function getEvaluation() As System.ServiceModel.Channels.Message Implements IJCT00300StreamingService.getEvaluation
        Dim loEx As New R_Exception
        Dim loCls As New JCT00300Cls
        Dim loRtnTemp As List(Of EvaluationListDTO)
        Dim loRtn As Message
        Dim loParam As New JCT00300DTO
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLangId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getEvaluation(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of EvaluationListDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEvaluation")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

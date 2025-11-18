' NOTE: You can use the "Rename" command on the context menu to change the class name "JCI00100StreamingService" in code, svc and config file together.
Imports R_Common
Imports R_BackEnd
Imports JCI00100Common
Imports JCI00100Back
Imports System.ServiceModel.Channels
Imports SIAPP_PUBCommon

Public Class JCI00100StreamingService
    Implements IJCI00100StreamingService
     
    Public Function getCmbPosition() As System.ServiceModel.Channels.Message Implements IJCI00100StreamingService.getCmbPosition
        Dim loEx As New R_Exception
        Dim loCls As New JCI00100CLS
        Dim loRtnTemp As List(Of JCI00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New JCI00100DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getCmbPosition(loParam)
            loList = R_Utility.R_GetChunkData(Of JCI00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPosition")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbYear() As System.ServiceModel.Channels.Message Implements IJCI00100StreamingService.getCmbYear
        Dim loEx As New R_Exception
        Dim loCls As New JCI00100CLS
        Dim loRtnTemp As List(Of JCI00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New JCI00100DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getCmbYear(loParam)
            loList = R_Utility.R_GetChunkData(Of JCI00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbYear")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListEmployee() As System.ServiceModel.Channels.Message Implements IJCI00100StreamingService.getListEmployee
        Dim loEx As New R_Exception
        Dim loCls As New JCI00100CLS
        Dim loRtnTemp As List(Of JCI00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New JCI00100DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            End With

            loRtnTemp = loCls.getListEmployee(loParam)
            loList = R_Utility.R_GetChunkData(Of JCI00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListEvaluationDetail() As System.ServiceModel.Channels.Message Implements IJCI00100StreamingService.getListEvaluationDetail
        Dim loEx As New R_Exception
        Dim loCls As New JCI00100CLS
        Dim loRtnTemp As List(Of JCI00100DetailStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New JCI00100DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getListEvaluationDetail(loParam)
            loList = R_Utility.R_GetChunkData(Of JCI00100DetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListEvaluationDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

  
End Class

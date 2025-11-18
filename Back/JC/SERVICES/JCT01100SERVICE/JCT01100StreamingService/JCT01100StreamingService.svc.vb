Imports R_Common
Imports JCT01100Back
Imports System.ServiceModel.Channels
Imports JCT01100Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "JCT01100StreamingService" in code, svc and config file together.
Public Class JCT01100StreamingService
    Implements IJCT01100StreamingService

    Public Function getEvaluation() As System.ServiceModel.Channels.Message Implements IJCT01100StreamingService.getEvaluation
        Dim loException As New R_Exception
        Dim loCls As New JCT01100Cls
        Dim loRtnTemp As List(Of EvaluationDto)
        Dim loRtn As Message
        Dim loParam As New JCT01100DTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")

            loRtnTemp = loCls.getEvaluation(loParam)
            loList = R_Utility.R_GetChunkData(Of EvaluationDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEvaluation")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEvaluationDetail() As System.ServiceModel.Channels.Message Implements IJCT01100StreamingService.getEvaluationDetail
        Dim loException As New R_Exception
        Dim loCls As New JCT01100Cls
        Dim loRtnTemp As List(Of EvaluationDetailDto)
        Dim loRtn As Message
        Dim loParam As New JCT01100DTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            loParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            loParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            loRtnTemp = loCls.getEvaluationDetail(loParam)

            loList = R_Utility.R_GetChunkData(Of EvaluationDetailDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEvaluationDetail")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    
End Class

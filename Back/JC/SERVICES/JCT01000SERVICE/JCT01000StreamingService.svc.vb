Imports R_Common
Imports R_BackEnd
Imports JCT01000Back
Imports JCT01000Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "JCT01000StreamingService" in code, svc and config file together.
Public Class JCT01000StreamingService
    Implements IJCT01000StreamingService

    Public Function getInformationList() As System.ServiceModel.Channels.Message Implements IJCT01000StreamingService.getInformationList
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000Cls
        Dim loRtn As List(Of InformationListDto)
        Dim loRtnMessage As Message = Nothing
        Dim loParam As New JCT01000Dto
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            End With

            loRtn = loCls.getInformationList(loParam)
            loList = R_Utility.R_GetChunkData(Of InformationListDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getInformationList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListEmployee() As System.ServiceModel.Channels.Message Implements IJCT01000StreamingService.getListEmployee
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000Cls
        Dim loRtn As List(Of EvaluationListDto)
        Dim loRtnMessage As Message = Nothing
        Dim loParam As New JCT01000Dto
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtn = loCls.getListEmployee(loParam)
            loList = R_Utility.R_GetChunkData(Of EvaluationListDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListEmployeeDetail() As System.ServiceModel.Channels.Message Implements IJCT01000StreamingService.getListEmployeeDetail
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls
        Dim loRtn As List(Of JCT01000StreamingDetailDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loParam As New JCT01000DetailDto
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            End With

            loRtn = loCls.getListEmployeeDetail(loParam)
            loList = R_Utility.R_GetChunkData(Of JCT01000StreamingDetailDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListEmployeeDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function PrintProcess() As System.ServiceModel.Channels.Message Implements IJCT01000StreamingService.PrintProcess
        Dim loEx As New R_Exception
        Dim loRtn As New List(Of JCT01000StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loParam As New JCT01000Dto
        Dim loList As List(Of Byte())
        Dim loCls As New JCT01000Cls

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cProgFlag = R_Utility.R_GetStreamingContext("cProgFlag")
                .lDownloadAll = R_Utility.R_GetStreamingContext("lDownloadAll")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtn = loCls.PrintProcess(loParam)
            loList = R_Utility.R_GetChunkData(Of JCT01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "PrintProcess")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function GetCompetencyResultList() As System.ServiceModel.Channels.Message Implements IJCT01000StreamingService.GetCompetencyResultList
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls
        Dim loRtn As List(Of JCT01000StreamingDetailDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loParam As New JCT01000DetailDto
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtn = loCls.GetCompetencyResultList(loParam)
            loList = R_Utility.R_GetChunkData(Of JCT01000StreamingDetailDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCompetencyResultList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetFailedEmployees() As System.ServiceModel.Channels.Message Implements IJCT01000StreamingService.GetFailedEmployees
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000Cls
        Dim loRtn As List(Of JCT01000StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loParam As New JCT01000Dto
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtn = loCls.GetFailedEmployees(loParam)
            loList = R_Utility.R_GetChunkData(Of JCT01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetFailedEmployees")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetListTrainingHistory() As System.ServiceModel.Channels.Message Implements IJCT01000StreamingService.GetListTrainingHistory
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls
        Dim loRtn As List(Of JCT01000StreamingDetailDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loParam As New JCT01000DetailDto
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtn = loCls.GetListTrainingHistory(loParam)
            loList = R_Utility.R_GetChunkData(Of JCT01000StreamingDetailDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetListTrainingHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetDownloadInfo() As System.ServiceModel.Channels.Message Implements IJCT01000StreamingService.GetDownloadInfo
        Dim loEx As New R_Exception
        Dim loRtn As New List(Of JCT01000StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loParam As New JCT01000Dto
        Dim loList As List(Of Byte())
        Dim loCls As New JCT01000Cls

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtn = loCls.GetDownloadInfo(loParam)
            loList = R_Utility.R_GetChunkData(Of JCT01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDownloadInfo")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function GetListHistoryCompetency() As System.ServiceModel.Channels.Message Implements IJCT01000StreamingService.GetListHistoryCompetency
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls
        Dim loRtn As List(Of JCT01000StreamingDetailDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loParam As New JCT01000DetailDto
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .CCAT_COMPETENCY_CODE = R_Utility.R_GetStreamingContext("CCAT_COMPETENCY_CODE")
                .CCOMPETENCY_CODE = R_Utility.R_GetStreamingContext("CCOMPETENCY_CODE")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtn = loCls.GetListHistoryCompetency(loParam)
            loList = R_Utility.R_GetChunkData(Of JCT01000StreamingDetailDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetListHistoryCompetency")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function GetDefaultScoringList() As System.ServiceModel.Channels.Message Implements IJCT01000StreamingService.GetDefaultScoringList
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls
        Dim loRtn As List(Of JCT01000StreamingDetailDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loParam As New JCT01000DetailDto
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .CPOSITION_CODE = R_Utility.R_GetStreamingContext("CPOSITION_CODE")
                .CCAT_COMPETENCY_CODE = R_Utility.R_GetStreamingContext("CCAT_COMPETENCY_CODE")
                .CCOMPETENCY_CODE = R_Utility.R_GetStreamingContext("CCOMPETENCY_CODE")
            End With

            loRtn = loCls.GetDefaultScoringList(loParam)
            loList = R_Utility.R_GetChunkData(Of JCT01000StreamingDetailDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDefaultScoringList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class

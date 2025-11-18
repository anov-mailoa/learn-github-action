Imports System.ServiceModel.Channels
Imports R_Common
Imports MCT02000Back
Imports MCT02000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT02000StreamingService" in code, svc and config file together.
Public Class MCT02000StreamingService
    Implements IMCT02000StreamingService

    Public Function getMctCorrection() As System.ServiceModel.Channels.Message Implements IMCT02000StreamingService.getMctCorrection
        Dim loCls As New MCT02000Cls
        Dim loRtnList As New List(Of MCT02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT02000GridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getMctCorrection(poParam)

            loList = R_Utility.R_GetChunkData(Of MCT02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getMctCorrection")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMedicalItemCorrectionList() As System.ServiceModel.Channels.Message Implements IMCT02000StreamingService.GetMedicalItemCorrectionList
        Dim loCls As New MCT02000Cls
        Dim loRtnList As New List(Of MCT02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT02000DTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.GetMedicalItemCorrectionList(poParam)

            loList = R_Utility.R_GetChunkData(Of MCT02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "GetMedicalItemCorrectionList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function getCmbMedicalItem() As System.ServiceModel.Channels.Message Implements IMCT02000StreamingService.getCMBMedicalItem
    '    Dim loCls As New MCT02000Cls
    '    Dim loRtnList As New List(Of MCT02000StreamingDTO)
    '    Dim loRtn As Message = Nothing
    '    Dim poParam As New MCT02000DTO
    '    Dim loEx As New R_Exception
    '    Dim loList As List(Of Byte())

    '    Try
    '        With poParam
    '            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
    '            .cYear = R_Utility.R_GetStreamingContext("cYear")
    '            .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
    '            .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
    '        End With

    '        loRtnList = loCls.getCmbMedicalItem(poParam)

    '        loList = R_Utility.R_GetChunkData(Of MCT02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
    '        loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbMedicalItem")

    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function getMedicalItem() As System.ServiceModel.Channels.Message Implements IMCT02000StreamingService.getMedicalItem
        Dim loCls As New MCT02000Cls
        Dim loRtnList As New List(Of MCT02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT02000DTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            loRtnList = loCls.getMedicalItem(R_Utility.R_GetStreamingContext("CCOMPANY_ID"))

            loList = R_Utility.R_GetChunkData(Of MCT02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getMedicalItem")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getDownloadData() As System.ServiceModel.Channels.Message Implements IMCT02000StreamingService.getDownloadData
        Dim loCls As New MCT02000Cls
        Dim loRtnList As New List(Of MCT02000DownloadDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT02000DTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnList = loCls.getDownloadData(poParam)

            loList = R_Utility.R_GetChunkData(Of MCT02000DownloadDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getDownloadData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLimitCorrectionDetail() As System.ServiceModel.Channels.Message Implements IMCT02000StreamingService.getLimitCorrectionDetail
        Dim loCls As New MCT02000Cls
        Dim loRtnList As New List(Of MCT02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT02000GridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtnList = loCls.getLimitCorrectionDetail(poParam)

            loList = R_Utility.R_GetChunkData(Of MCT02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getLimitCorrectionDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getEmpL() As System.ServiceModel.Channels.Message Implements IMCT02000StreamingService.getEmpL
        Dim loCls As New MCT02000Cls
        Dim loRtnList As New List(Of MCT02000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCT02000GridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnList = loCls.getEmpL(poParam)

            loList = R_Utility.R_GetChunkData(Of MCT02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getEmpL")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function
End Class

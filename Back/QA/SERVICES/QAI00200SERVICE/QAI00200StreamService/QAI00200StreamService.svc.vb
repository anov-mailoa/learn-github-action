Imports R_Common
Imports QAI00200Back
Imports System.ServiceModel.Channels
Imports QAI00200Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAI00200StreamService" in code, svc and config file together.
Public Class QAI00200StreamService
    Implements IQAI00200StreamService

    Public Function GetHISTDOCLIST() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetHISTDOCLIST
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetHISTDOCLIST(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetHISTDOCLIST")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetHISTFILINGLIST() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetHISTFILINGLIST
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetHISTFILINGLIST(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetHISTFILINGLIST")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetSOCLIST() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetSOCLIST
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
            .iDocVersion = R_Utility.R_GetStreamingContext("iDocVersion")
        End With

        Try
            loRtnTemp = loCls.GetSOCLIST(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetSOCLIST")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCLAUSES() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetCLAUSES
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetCLAUSES(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetCLAUSES")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetDOC_SOCIALIZATION() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetDOC_SOCIALIZATION
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetDOC_SOCIALIZATION(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetDOC_SOCIALIZATION")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetHISTCLAUSES() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetHISTCLAUSES
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetHISTCLAUSES(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetHISTCLAUSES")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetHISTRELPOSLIST() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetHISTRELPOSLIST
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetHISTRELPOSLIST(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetHISTRELPOSLIST")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetHISTRETAINERSLIST() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetHISTRETAINERSLIST
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetHISTRETAINERSLIST(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetHISTRETAINERSLIST")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetRELPOS() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetRELPOS
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetRELPOS(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetRELPOS")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetRETAINERS() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetRETAINERS
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetRETAINERS(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetRETAINERS")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetRELDOC_SOCIALIZATION() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetRELDOC_SOCIALIZATION
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetRELDOC_SOCIALIZATION(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetRELDOC_SOCIALIZATION")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetRELDOCLIST() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetRELDOCLIST
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetRELDOCLIST(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetRELDOCLIST")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetRELDOCRETAINERS() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetRELDOCRETAINERS
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200StreamDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetRELDOCRETAINERS(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)


            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetRELDOCRETAINERS")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetRSP_QAI00200_GETRELDOC() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetRSP_QAI00200_GETRELDOC
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200RelatedDocDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetRSP_QAI00200_GETRELDOC(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200RelatedDocDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetRSP_QAI00200_GETRELDOC")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetRSP_QAI00200_GETREVISION() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.GetRSP_QAI00200_GETREVISION
        Dim loException As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtnTemp As List(Of QAI00200RevisionDto)
        Dim loParam As New QAI00200Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
        End With

        Try
            loRtnTemp = loCls.GetRSP_QAI00200_GETREVISION(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI00200RevisionDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetRSP_QAI00200_GETREVISION")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poGrid As QAI00200Back.QAI00200GridDto) Implements IQAI00200StreamService.Dummy

    End Sub

    Public Function getCmbPositionCodeRetainer() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.getCmbPositionCodeRetainer
        Dim loCls As New QAI00200Tab5RetainerCLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAI00200Tab5RetainerDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
            End With

            loRtnList = loCls.getCmbPositionCodeRetainer(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbPositionCodeRetainer")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbDocType() As System.ServiceModel.Channels.Message Implements IQAI00200StreamService.getCmbDocType
        Dim loCls As New QAI00200Tab5DocInfoCLS
        Dim loRtnList As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAI00200Tab5DocInfoDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLangId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getCmbDocType(poParam)
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getCmbDocType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

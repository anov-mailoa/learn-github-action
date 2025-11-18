Imports R_Common
Imports ESS_PUB_BACK
Imports System.ServiceModel.Channels
Imports ESS_PUB_COMMON
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "SIAPP_PUB_DTOStreamingService" in code, svc and config file together.
Public Class ESS_PUB_StreamingService
    Implements IESS_PUB_StreamingService

    Public Function RFT_GET_GEOGRAPHY() As System.ServiceModel.Channels.Message Implements IESS_PUB_StreamingService.RFT_GET_GEOGRAPHY
        Dim loEx As New R_Exception
        Dim loCls As New ESS_PUBCLS
        Dim loRtnTemp As List(Of CMB_DTO)
        Dim loRtn As Message
        Dim loParam As New ESS_PUB_ParamDTO

        Try
            With loParam
                .CLEVEL = R_Utility.R_GetStreamingContext("CLEVEL")
                .CPARENT_CODE = R_Utility.R_GetStreamingContext("CPARENT_CODE")
            End With

            loRtnTemp = loCls.RFT_GET_GEOGRAPHY(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of CMB_DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_GEOGRAPHY")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_GSB_CODE_INFO() As System.ServiceModel.Channels.Message Implements IESS_PUB_StreamingService.RFT_GET_GSB_CODE_INFO
        Dim loEx As New R_Exception
        Dim loCls As New ESS_PUBCLS
        Dim loRtnTemp As List(Of CMB_DTO)
        Dim loRtn As Message
        Dim loParam As New ESS_PUB_ParamDTO

        Try
            With loParam
                .CCLASS_APPLICATION = R_Utility.R_GetStreamingContext("CCLASS_APPLICATION")
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CCLASS_ID = R_Utility.R_GetStreamingContext("CCLASS_ID")
                .CCLASS_RECID = R_Utility.R_GetStreamingContext("CCLASS_RECID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnTemp = loCls.RFT_GET_GSB_CODE_INFO(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of CMB_DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_GSB_CODE_INFO")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub RFN_VALIDATE_EMP_APPROVAL_POSITIONS(poParam As ESS_PUB_BACK.ESS_PUB_ParamDTO) Implements IESS_PUB_StreamingService.RFN_VALIDATE_EMP_APPROVAL_POSITIONS
        Dim loEx As New R_Exception
        Dim loCls As New ESS_PUBCLS

        Try
            loCls.RFN_VALIDATE_EMP_APPROVAL_POSITIONS(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub ParamDTO(poPar1 As System.Collections.Generic.List(Of ESS_PUB_BACK.CMB_DTOReguler)) Implements IESS_PUB_StreamingService.ParamDTO

    End Sub

    Public Function RFT_ESS_TRANSACTION_APPROVAL_STATUS() As System.ServiceModel.Channels.Message Implements IESS_PUB_StreamingService.RFT_ESS_TRANSACTION_APPROVAL_STATUS
        Dim loEx As New R_Exception
        Dim loCls As New ESS_PUBCLS
        Dim loRtnTemp As List(Of RFT_ESS_TRANSACTION_APPROVAL_STATUS_DTO)
        Dim loRtn As Message
        Dim loParam As New ESS_PUB_ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .LESS = R_Utility.R_GetStreamingContext("LESS")
            End With

            loRtnTemp = loCls.RFT_ESS_TRANSACTION_APPROVAL_STATUS(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_ESS_TRANSACTION_APPROVAL_STATUS_DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_ESS_TRANSACTION_APPROVAL_STATUS")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_ESS_GET_EMPLOYEE_SUB_PROGRAM_LIST() As System.ServiceModel.Channels.Message Implements IESS_PUB_StreamingService.RFT_ESS_GET_EMPLOYEE_SUB_PROGRAM_LIST
        Dim loEx As New R_Exception
        Dim loCls As New ESS_PUBCLS
        Dim loRtnTemp As List(Of RFT_ESS_GET_EMPLOYEE_SUB_PROGRAM_LIST_DTO)
        Dim loRtn As Message
        Dim loParam As New ESS_PUB_ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CPARENT_CODE = R_Utility.R_GetStreamingContext("CPARENT_CODE")
            End With

            loRtnTemp = loCls.RFT_ESS_GET_EMPLOYEE_SUB_PROGRAM_LIST(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_ESS_GET_EMPLOYEE_SUB_PROGRAM_LIST_DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_ESS_GET_EMPLOYEE_SUB_PROGRAM_LIST")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

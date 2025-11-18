Imports System.ServiceModel
Imports R_Common
Imports PYT01000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYT01000Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT01000StreamingService" in code, svc and config file together.
Public Class PYT01000StreamingService
    Implements IPYT01000StreamingService

    Public Function getRapidCompList() As System.ServiceModel.Channels.Message Implements IPYT01000StreamingService.getRapidCompList
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls
        Dim loRtn As New List(Of PYT01000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01000DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CPROCESS_CODE = R_Utility.R_GetStreamingContext("CPROCESS_CODE")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtn = loCls.getRapidCompList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRapidCompList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbYear() As System.ServiceModel.Channels.Message Implements IPYT01000StreamingService.getCmbYear
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls
        Dim loRtn As New List(Of PYT01000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01000DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtn = loCls.getCmbYear(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbYear")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getTransactionList() As System.ServiceModel.Channels.Message Implements IPYT01000StreamingService.getTransactionList
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls
        Dim loRtn As New List(Of PYT01000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01000DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtn = loCls.getTransactionList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransactionList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getDetailEmployeeList() As System.ServiceModel.Channels.Message Implements IPYT01000StreamingService.getDetailEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls
        Dim loRtn As New List(Of PYT01000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01000DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtn = loCls.getDetailEmployeeList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDetailEmployeeList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getLookupEmployeeList() As System.ServiceModel.Channels.Message Implements IPYT01000StreamingService.getLookupEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls
        Dim loRtn As New List(Of PYT01000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01000DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CPROCESS_CODE = R_Utility.R_GetStreamingContext("CPROCESS_CODE")
                .CSTART_PERIOD_INDEX = R_Utility.R_GetStreamingContext("CSTART_PERIOD_INDEX")
                .CEND_PERIOD_INDEX = R_Utility.R_GetStreamingContext("CEND_PERIOD_INDEX")
            End With

            loRtn = loCls.getLookupEmployeeList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookupEmployeeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getDTPResultEmployee() As System.ServiceModel.Channels.Message Implements IPYT01000StreamingService.getDTPResultEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls
        Dim loRtn As New List(Of PYT01000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01000DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtn = loCls.getDTPResultEmployee(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDTPResultEmployee")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getDTPResultDetail() As System.ServiceModel.Channels.Message Implements IPYT01000StreamingService.getDTPResultDetail
        Dim loEx As New R_Exception
        Dim loCls As New PYT01000Cls
        Dim loRtn As New List(Of PYT01000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01000DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtn = loCls.getDTPResultDetail(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDTPResultDetail")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    
End Class

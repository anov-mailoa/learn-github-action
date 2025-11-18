Imports System.ServiceModel
Imports R_Common
Imports PYT01200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYT01200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT01200StreamingService" in code, svc and config file together.
Public Class PYT01200StreamingService
    Implements IPYT01200StreamingService

    Public Function getCompList() As System.ServiceModel.Channels.Message Implements IPYT01200StreamingService.getCompList
        Dim loEx As New R_Exception
        Dim loCls As New PYT01200DetailCls
        Dim loRtn As New List(Of PYT01200DetailStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01200DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CPROCESS_CODE = R_Utility.R_GetStreamingContext("CPROCESS_CODE")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CLAST_PROCESS_PERIOD = R_Utility.R_GetStreamingContext("CLAST_PROCESS_PERIOD")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtn = loCls.getCompList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01200DetailStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCompList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getDetailList() As System.ServiceModel.Channels.Message Implements IPYT01200StreamingService.getDetailList
        Dim loEx As New R_Exception
        Dim loCls As New PYT01200DetailCls
        Dim loRtn As New List(Of PYT01200DetailStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01200DTO
        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .LHISTORY = R_Utility.R_GetStreamingContext("LHISTORY")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtn = loCls.getDetailList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01200DetailStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDetailList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getEmpList() As System.ServiceModel.Channels.Message Implements IPYT01200StreamingService.getEmpList
        Dim loEx As New R_Exception
        Dim loCls As New PYT01200Cls
        Dim loRtn As New List(Of PYT01200StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01200DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtn = loCls.getEmpList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmpList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getTrxList() As System.ServiceModel.Channels.Message Implements IPYT01200StreamingService.getTrxList
        Dim loEx As New R_Exception
        Dim loCls As New PYT01200Cls
        Dim loRtn As New List(Of PYT01200StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01200DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .LHISTORY = R_Utility.R_GetStreamingContext("LHISTORY")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtn = loCls.getTrxList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTrxList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getYearList() As System.ServiceModel.Channels.Message Implements IPYT01200StreamingService.getYearList
        Dim loEx As New R_Exception
        Dim loCls As New PYT01200Cls
        Dim loRtn As New List(Of PYT01200StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01200DTO

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtn = loCls.getYearList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getYearList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbProcessCode() As System.ServiceModel.Channels.Message Implements IPYT01200StreamingService.getCmbProcessCode
        Dim loEx As New R_Exception
        Dim loCls As New PYT01200Cls
        Dim loRtn As New List(Of PYT01200StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT01200DTO
        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
                .CLAST_PROCESS_PERIOD = R_Utility.R_GetStreamingContext("CLAST_PROCESS_PERIOD")
            End With

            loRtn = loCls.getCmbProcessCode(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT01200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbProcessCode")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class

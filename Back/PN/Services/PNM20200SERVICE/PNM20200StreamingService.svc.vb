Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20200Back
Imports PNM20200Common
Imports SIAPP_SERVICE_PN

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM20000StreamingService" in code, svc and config file together.
Public Class PNM20200StreamingService
    Implements IPNM20200StreamingService

    Public Sub dummy(poParam As PNM20200DTO) Implements IPNM20200StreamingService.dummy

    End Sub

    Public Function getListComboBox() As Message Implements IPNM20200StreamingService.getListComboBox
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20200CLS
        Dim loRtn As List(Of PNM20200StreamingDTO)
        Dim loParam As New PNM20200DTO
        Dim loList As List(Of Byte())
        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtn = loCls.getListComboBox(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListComboBox")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListDiningDate() As Message Implements IPNM20200StreamingService.getListDiningDate
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20200CLS
        Dim loRtn As List(Of PNM20200StreamingDTO)
        Dim loParam As New PNM20200DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CCANTEEN_CODE = R_Utility.R_GetStreamingContext("CCANTEEN_CODE")
                .CTIME_CODE = R_Utility.R_GetStreamingContext("CTIME_CODE")
                .CDINING_DATE = R_Utility.R_GetStreamingContext("CDINING_DATE")
            End With

            loRtn = loCls.getListDiningDate(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDiningDate")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListEmployee() As Message Implements IPNM20200StreamingService.getListEmployee
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20200CLS
        Dim loRtn As List(Of PNM20200EmployeeDTO)
        Dim loParam As New PNM20200DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CCANTEEN_CODE = R_Utility.R_GetStreamingContext("CCANTEEN_CODE")
                .CTIME_CODE = R_Utility.R_GetStreamingContext("CTIME_CODE")
                .CDINING_DATE = R_Utility.R_GetStreamingContext("CDINING_DATE")
                .LDINING = R_Utility.R_GetStreamingContext("LDINING")
            End With

            loRtn = loCls.getListEmployee(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20200EmployeeDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class

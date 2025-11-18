Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYI02000Back
Imports PYI02000Common

Public Class PYI02000StreamingService
    Implements IPYI02000StreamingService

    Public Function GetCmbLocation() As System.ServiceModel.Channels.Message Implements IPYI02000StreamingService.GetCmbLocation
        Dim loEx As New R_Exception
        Dim loCls As New PYI02000Cls
        Dim poParam As New PYI02000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYI02000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtnList = loCls.GetCmbLocation(poParam)
            loList = R_Utility.R_GetChunkData(Of PYI02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbLocation")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbPosition() As System.ServiceModel.Channels.Message Implements IPYI02000StreamingService.GetCmbPosition
        Dim loEx As New R_Exception
        Dim loCls As New PYI02000Cls
        Dim poParam As New PYI02000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYI02000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnList = loCls.GetCmbPosition(poParam)
            loList = R_Utility.R_GetChunkData(Of PYI02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbPosition")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbDepartment() As System.ServiceModel.Channels.Message Implements IPYI02000StreamingService.GetCmbDepartment
        Dim loEx As New R_Exception
        Dim loCls As New PYI02000Cls
        Dim poParam As New PYI02000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYI02000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtnList = loCls.GetCmbDepartment(poParam)
            loList = R_Utility.R_GetChunkData(Of PYI02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbDepartment")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetInquiryTaxEmployeeList() As System.ServiceModel.Channels.Message Implements IPYI02000StreamingService.GetInquiryTaxEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New PYI02000Cls
        Dim poParam As New PYI02000DTO
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYI02000StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CEMPLOYEE_NAME = R_Utility.R_GetStreamingContext("CEMPLOYEE_NAME")
                .CPOSITION_CODE = R_Utility.R_GetStreamingContext("CPOSITION_CODE")
                .CLOCATION_CODE = R_Utility.R_GetStreamingContext("CLOCATION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CSTATUS = R_Utility.R_GetStreamingContext("CSTATUS")
            End With

            loRtnList = loCls.GetInquiryTaxEmployeeList(poParam)
            loList = R_Utility.R_GetChunkData(Of PYI02000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetInquiryTaxEmployeeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

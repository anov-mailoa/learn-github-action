Imports R_BackEnd
Imports R_Common
Imports PYM03000Back
Imports PYM03000Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM03000StreamingService" in code, svc and config file together.
Public Class PYM03000StreamingService
    Implements IPYM03000StreamingService

    Public Function getCmbDimension() As System.ServiceModel.Channels.Message Implements IPYM03000StreamingService.getCmbDimension
        Dim loCls As New PYM03000CLS
        Dim loParam As New PYM03000DTO
        Dim loRtnList As New List(Of PYM03000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnList = loCls.getCmbDimension(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM03000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbDimension")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListUsedSalaryRange() As System.ServiceModel.Channels.Message Implements IPYM03000StreamingService.getListUsedSalaryRange
        Dim loCls As New PYM03000DetailCls
        Dim loParam As New PYM03000DTO
        Dim loRtnList As New List(Of PYM03000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CKEY = R_Utility.R_GetStreamingContext("CKEY")
            End With

            loRtnList = loCls.getListUsedSalaryRange(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM03000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListUsedSalaryRange")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01700StreamingService" in code, svc and config file together.
Imports R_Common
Imports PYM01700Back
Imports System.ServiceModel.Channels
Imports PYM01700Common
Imports R_BackEnd

Public Class PYM01700StreamingService
    Implements IPYM01700StreamingService

    Public Function getTaxStatusMapping() As System.ServiceModel.Channels.Message Implements IPYM01700StreamingService.getTaxStatusMapping
        Dim loEx As New R_Exception
        Dim loCls As New PYM01700Cls
        Dim loRtnTemp As List(Of PYM01700StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYM01700DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CTAX_STATUS = R_Utility.R_GetStreamingContext("CTAX_STATUS")
            End With

            loRtnTemp = loCls.getTaxStatusMapping(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01700StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTaxStatusMapping")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getChildFamilyMapping() As System.ServiceModel.Channels.Message Implements IPYM01700StreamingService.getChildFamilyMapping
        Dim loEx As New R_Exception
        Dim loCls As New PYM01700Cls
        Dim loRtnTemp As List(Of PYM01700StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYM01700DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CFLAG = R_Utility.R_GetStreamingContext("CFLAG")
            End With

            loRtnTemp = loCls.getChildFamilyMapping(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01700StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getChildFamilyMapping")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

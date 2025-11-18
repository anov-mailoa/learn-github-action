Imports System.ServiceModel
Imports R_Common
Imports PNM06000Back
Imports PNM06000Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "pnm06000StreamingService" in code, svc and config file together.
Public Class PNM06000StreamingService
    Implements IPNM06000StreamingService

    Public Function getLetterMaster() As System.ServiceModel.Channels.Message Implements IPNM06000StreamingService.getLetterMaster
        Dim loException As New R_Exception
        Dim loCls As New PNM06000LetterMasterCLS
        Dim loRtnTemp As List(Of PNM06000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM06000DTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.getLetterMaster(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM06000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLetterMaster")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbTransType() As System.ServiceModel.Channels.Message Implements IPNM06000StreamingService.getCmbTransType
        Dim loException As New R_Exception
        Dim loCls As New PNM06000LetterMasterCLS
        Dim loRtnTemp As List(Of PNM06000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM06000DTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.CLETTER_MODULE = R_Utility.R_GetStreamingContext("CLETTER_MODULE")

            loRtnTemp = loCls.getCmbTransType(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM06000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbTransType")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poGrid As System.Collections.Generic.List(Of PNM06000Back.PNM06000GridDTO)) Implements IPNM06000StreamingService.Dummy

    End Sub
End Class

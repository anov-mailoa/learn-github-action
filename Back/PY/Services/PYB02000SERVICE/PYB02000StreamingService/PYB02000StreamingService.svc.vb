Imports R_Common
Imports R_BackEnd
Imports PYB02000Back
Imports PYB02000Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB02000StreamingService" in code, svc and config file together.
Public Class PYB02000StreamingService
    Implements IPYB02000StreamingService

    Public Function GetPeriode() As System.ServiceModel.Channels.Message Implements IPYB02000StreamingService.GetPeriode
        Dim loEx As New R_Exception
        Dim loCls As New PYB02000Cls
        Dim loRtnTemp As List(Of PYB02000StreamingDTO)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.GetPeriode(R_Utility.R_GetStreamingContext("CCOMPANY_ID"))

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetPeriode")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function GetGroup() As System.ServiceModel.Channels.Message Implements IPYB02000StreamingService.GetGroup
        Dim loEx As New R_Exception
        Dim loCls As New PYB02000Cls
        Dim loRtnTemp As List(Of PYB02000StreamingDTO)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.GetGroup(R_Utility.R_GetStreamingContext("CCOMPANY_ID"))

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetGroup")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function GetKPP() As System.ServiceModel.Channels.Message Implements IPYB02000StreamingService.GetKPP
        Dim loEx As New R_Exception
        Dim loCls As New PYB02000Cls
        Dim loRtnTemp As List(Of PYB02000StreamingDTO)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.GetKPP(R_Utility.R_GetStreamingContext("CCOMPANY_ID"))

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetKPP")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function GenerateFile() As System.ServiceModel.Channels.Message Implements IPYB02000StreamingService.GenerateFile
        Dim loEx As New R_Exception
        Dim loCls As New PYB02000Cls
        Dim loRtnTemp As List(Of PYB02000StreamingDTO)
        Dim loRtn As Message
        Dim loparam As New PYB02000DTO

        Try
            With loparam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("COMPID")
                .CPERIODE = R_Utility.R_GetStreamingContext("PERIOD")
                .CTANGGAL_PEMOTONGAN = R_Utility.R_GetStreamingContext("TANGPO")
                .CTIPE_BUKTI_POTONG = R_Utility.R_GetStreamingContext("BUKPOT")
                .CGROUP_LIST = R_Utility.R_GetStreamingContext("GROUPL")
                .CKPP_LIST = R_Utility.R_GetStreamingContext("KPPLIS")
                .CENC_KEY = R_Utility.R_GetStreamingContext("ENCKEY")
                .LMASA_TRANSISI = R_Utility.R_GetStreamingContext("MATRAN")
                .IPERIODE_AWAL = R_Utility.R_GetStreamingContext("IPEAWA")
                .IPERIODE_AKHIR = R_Utility.R_GetStreamingContext("IPEAKH")
                .CPOSITION_TYPE = R_Utility.R_GetStreamingContext("CPOTYP")
                .CPOSITION_NAME = R_Utility.R_GetStreamingContext("CPONAM")
            End With

            loRtnTemp = loCls.GenerateFile(loparam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GenerateFile")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYB02000Back.PYB02000DTO)) Implements IPYB02000StreamingService.Dummy

    End Sub

End Class

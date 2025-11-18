Imports R_Common
Imports PYB04500Back
Imports System.ServiceModel.Channels
Imports PYB04500Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB04500StreamingService" in code, svc and config file together.
Public Class PYB04500StreamingService
    Implements IPYB04500StreamingService

    Public Function GetGvSalaryProcess() As System.ServiceModel.Channels.Message Implements IPYB04500StreamingService.GetGvSalaryProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYB04500Cls
        Dim loRtnTemp As List(Of PYB04500StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB04500Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriodType = R_Utility.R_GetStreamingContext("cPeriodType")
                .cProcessIndex = R_Utility.R_GetStreamingContext("cProcessIndex")
            End With

            loRtnTemp = loCls.GetGvSalaryProcess(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB04500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetGvSalaryProcess")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Get_ProcessPeriod(poParam As PYB04500Back.PYB04500Dto) As String Implements IPYB04500StreamingService.Get_ProcessPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYB04500Cls
        Dim loRtnTemp As String = ""
        Try
            loRtnTemp = loCls.Get_ProcessPeriod(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnTemp
    End Function

    Public Function cekMultiCompany(pcCompId As String) As PYB04500Back.PYB04500Dto Implements IPYB04500StreamingService.cekMultiCompany
        Dim loEx As New R_Exception
        Dim loCls As New PYB04500Cls
        Dim loRtn As New PYB04500Dto
        Try
            loRtn = loCls.cekMultiCompany(pcCompId)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYB04500Back.PYB04500Dto)) Implements IPYB04500StreamingService.Dummy

    End Sub
End Class

Imports System.ServiceModel.Channels
Imports PNT04200Back
Imports PNT04200Common
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT04200StreamingService" in code, svc and config file together.
Public Class PNT04200StreamingService
    Implements IPNT04200StreamingService

    Public Function getPntTransactionHd() As System.ServiceModel.Channels.Message Implements IPNT04200StreamingService.getPntTransactionHd
        Dim loCls As New PNT04200Cls
        Dim loRtnTemp As List(Of PNT04200StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT04200DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
            End With

            loRtnTemp = loCls.getPntTransactionHd(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT04200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPntTransactionHd")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCompany() As System.ServiceModel.Channels.Message Implements IPNT04200StreamingService.getCompany
        Dim loCls As New PNT04200Cls
        Dim loRtnTemp As List(Of PNT04200StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT04200DTO
        Dim loEx As New R_Exception

        Try
            'With poParam
            '    .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            '    .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            '    .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
            'End With

            loRtnTemp = loCls.getCompany(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT04200StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCompany")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of PNT04200Back.PNT04200GridDTO)) Implements IPNT04200StreamingService.Dummy

    End Sub
End Class

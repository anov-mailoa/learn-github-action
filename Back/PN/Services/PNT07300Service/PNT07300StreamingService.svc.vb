Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNT07300Back
Imports PNT07300Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT07300StreamingService" in code, svc and config file together.
Public Class PNT07300StreamingService
    Implements IPNT07300StreamingService

    Public Function getPnmGradeDt() As System.ServiceModel.Channels.Message Implements IPNT07300StreamingService.getPnmGradeDt
        Dim loCls As New PNT07300CLS
        Dim loRtnTemp As List(Of PNT07300StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT07300DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGrade = R_Utility.R_GetStreamingContext("cGrade")
            End With

            loRtnTemp = loCls.getPnmGradeDt(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT07300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmGradeDt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCompany() As System.ServiceModel.Channels.Message Implements IPNT07300StreamingService.getCompany
        Dim loCls As New PNT07300CLS
        Dim loRtnTemp As List(Of PNT07300StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT07300DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
            End With

            loRtnTemp = loCls.getCompany(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT07300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCompany")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

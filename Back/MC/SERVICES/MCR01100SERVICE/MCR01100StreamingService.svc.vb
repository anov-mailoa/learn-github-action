' NOTE: You can use the "Rename" command on the context menu to change the class name "MCR01100StreamingService" in code, svc and config file together.
Imports R_Common
Imports System.ServiceModel.Channels
Imports MCR01100Back
Imports MCR01100Common
Imports R_BackEnd
Public Class MCR01100StreamingService
    Implements IMCR01100StreamingService

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of MCR01100Back.MCR01100DTO)) Implements IMCR01100StreamingService.Dummy

    End Sub

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IMCR01100StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New MCR01100CLS
        Dim poParam As New MCR01100DTO
        Dim loRtnList As New List(Of MCR01100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEncrypt = R_Utility.R_GetStreamingContext("cEncrypt")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cReport = R_Utility.R_GetStreamingContext("cReport")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .LWITH_SUBITEM = R_Utility.R_GetStreamingContext("LWITH_SUBITEM")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR01100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getYear() As System.ServiceModel.Channels.Message Implements IMCR01100StreamingService.getYear
        Dim loException As New R_Exception
        Dim loCls As New MCR01100CLS
        Dim poParam As New MCR01100DTO
        Dim loRtnList As New List(Of MCR01100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStatus = R_Utility.R_GetStreamingContext("cStatus")
            End With

            loRtnList = loCls.getyear(poParam)
            loList = R_Utility.R_GetChunkData(Of MCR01100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loRtnList.AsEnumerable, "getYear")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

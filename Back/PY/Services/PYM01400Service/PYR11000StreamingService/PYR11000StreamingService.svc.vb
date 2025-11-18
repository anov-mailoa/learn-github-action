Imports R_Common
Imports System.ServiceModel.Channels
Imports PYM01400Back
Imports PYM01400Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR11000StreamingService" in code, svc and config file together.
Public Class PYR11000StreamingService
    Implements IPYR11000StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPYR11000StreamingService.getReport
        Dim loEx As New R_Exception
        Dim loCls As New PYM01400Cls
        Dim poParam As New PYM01400Dto
        Dim loRtnList As New List(Of PYR11000ReportDto)
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cNonEmployeeIdList = R_Utility.R_GetStreamingContext("cNonEmployeeIdList")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            End With

            loRtnList = loCls.getReport(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYR11000ReportDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

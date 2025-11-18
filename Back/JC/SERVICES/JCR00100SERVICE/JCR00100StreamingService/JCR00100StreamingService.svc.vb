Imports R_Common
Imports R_BackEnd
Imports JCR00100Back
Imports System.ServiceModel.Channels
Imports JCR00100Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "JCR00100StreamingService" in code, svc and config file together.
Public Class JCR00100StreamingService
    Implements IJCR00100StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IJCR00100StreamingService.getReport
        Dim loRtn As New List(Of JCR00100StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New JCR00100Cls
        Dim loEx As New R_Exception
        Dim poParam As New JCR00100ParDTO
        Dim loList As List(Of Byte())

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            poParam.cEvaluationType = R_Utility.R_GetStreamingContext("cEvaluationType")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.lIncludeApplicable = R_Utility.R_GetStreamingContext("lIncludeApplicable")


            loRtn = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of JCR00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getListReferrence() As System.ServiceModel.Channels.Message Implements IJCR00100StreamingService.getListReferrence
        Dim loRtn As New List(Of JCR00100RefNoLookupDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New JCR00100Cls
        Dim loEx As New R_Exception
        Dim poParam As New JCR00100ParDTO
        Dim loList As List(Of Byte())

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEvaluationType = R_Utility.R_GetStreamingContext("cEvaluationType")


            loRtn = loCls.getListReferrence(poParam)
            loList = R_Utility.R_GetChunkData(Of JCR00100RefNoLookupDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListReferrence")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of JCR00100Back.JCR00100ParDTO)) Implements IJCR00100StreamingService.Dummy

    End Sub
End Class

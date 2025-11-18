' NOTE: You can use the "Rename" command on the context menu to change the class name "QAF01000StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports R_Common
Imports QAF01000Back

Public Class QAF01000StreamingService
    Implements IQAF01000StreamingService

    Public Function getTreePosition() As System.ServiceModel.Channels.Message Implements IQAF01000StreamingService.getTreePosition
        Dim loCls As New QAF01000CLS
        Dim loRtnList As New List(Of QAF01000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New QAF01000DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransCode = R_Utility.R_GetStreamingContext("cTransCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cRefNo = R_Utility.R_GetStreamingContext("cRefNo")
                .cDocNo = R_Utility.R_GetStreamingContext("cDocNo")
                .cProgramId = R_Utility.R_GetStreamingContext("cProgramId")
            End With

            loRtnList = loCls.getTreePosition(poParam)

            loRtn = R_StreamUtility(Of QAF01000StreamingDTO).WriteToMessage(loRtnList.AsEnumerable(), "getTreePosition")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of QAF01000Back.QAF01000StreamingDTO)) Implements IQAF01000StreamingService.Dummy

    End Sub
End Class

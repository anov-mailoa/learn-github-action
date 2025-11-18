Imports System.ServiceModel
Imports R_Common
Imports ATF00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels ' NOTE: You can use the "Rename" command on the context menu to change the class name "ATF00100StreamService" in code, svc and config file together.
Public Class ATF00100StreamService
    Implements IATF00100StreamService

    Public Function getDetail() As System.ServiceModel.Channels.Message Implements IATF00100StreamService.getDetail
        Dim loRtn As Message
        Dim loCls As New ATF00100Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATF00100DTO
        Dim loRtnTemp As New List(Of ATF00100StreamDTO)
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .dDateNow = R_Utility.R_GetStreamingContext("dDateNow")
            End With
            loRtnTemp = loCls.getDetail(poParam)
            loRtn = R_StreamUtility(Of ATF00100StreamDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy3(poPar As System.Collections.Generic.List(Of ATF00100Back.ATF00100StreamDTO)) Implements IATF00100StreamService.Dummy3

    End Sub
End Class

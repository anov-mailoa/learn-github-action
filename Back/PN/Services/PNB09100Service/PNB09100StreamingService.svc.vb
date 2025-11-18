Imports System.ServiceModel.Channels
Imports PNB09100Back
Imports PNB09100Common
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNB09100StreamingService" in code, svc and config file together.
Public Class PNB09100StreamingService
    Implements IPNB09100StreamingService

    Public Function getPnmEmpOffice() As System.ServiceModel.Channels.Message Implements IPNB09100StreamingService.getPnmEmpOffice
        Dim loCls As New PNB09100Cls
        Dim loRtnTemp As List(Of PNB09100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNB09100DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cDateNow = R_Utility.R_GetStreamingContext("cDateNow")
            End With

            loRtnTemp = loCls.getPnmEmpOffice(poParam)
            loList = R_Utility.R_GetChunkData(Of PNB09100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmEmpOffice")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

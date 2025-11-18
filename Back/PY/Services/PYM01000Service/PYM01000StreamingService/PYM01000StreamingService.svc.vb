' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01000StreamingService" in code, svc and config file together.
Imports R_Common
Imports PYM01000Back
Imports System.ServiceModel.Channels
Imports PYM01000Common
Imports R_BackEnd

Public Class PYM01000StreamingService
    Implements IPYM01000StreamingService

    Public Function getPYM01000Grid() As System.ServiceModel.Channels.Message Implements IPYM01000StreamingService.getPYM01000Grid
        Dim loEx As New R_Exception
        Dim loCls As New PYM01000Cls
        Dim loRtnTemp As List(Of PYM01000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYM01000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getPYM01000Grid(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPYM01000Grid")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

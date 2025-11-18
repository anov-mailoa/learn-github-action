Imports R_Common
Imports R_BackEnd
Imports GSM00300Back
Imports GSM00300Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM00300StreamingService" in code, svc and config file together.
Public Class GSM00300StreamingService
    Implements IGSM00300StreamingService

    Public Function getGridYear() As System.ServiceModel.Channels.Message Implements IGSM00300StreamingService.getGridYear
        Dim loException As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtnTemp As List(Of GSM00300YearGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getGridYear(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00300YearGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridYear")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridYearDetails() As System.ServiceModel.Channels.Message Implements IGSM00300StreamingService.getGridYearDetails
        Dim loException As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtnTemp As List(Of GSM00300YearDetailGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cCyear")
            End With

            loRtnTemp = loCls.getGridYearDetails(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00300YearDetailGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridYearDetails")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function generatePeriod() As System.ServiceModel.Channels.Message Implements IGSM00300StreamingService.generatePeriod
        Dim loException As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtnTemp As List(Of GSM00300YearDetailGridDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .lPeriodMode = R_Utility.R_GetStreamingContext("lPeriodMode")
                .cPeriodNo = R_Utility.R_GetStreamingContext("cPeriodNo")
            End With

            loRtnTemp = loCls.generatePeriod(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00300YearDetailGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "generatePeriod")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of GSM00300Back.GSM00300YearGridDTO), poPar2 As System.Collections.Generic.List(Of GSM00300Back.GSM00300YearDetailGridDTO)) Implements IGSM00300StreamingService.Dummy

    End Sub
End Class

Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports ATT00800Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00800ByPosStreamingService" in code, svc and config file together.
Public Class ATT00800ByPosStreamingService
    Implements IATT00800ByPosStreamingService
     
    Public Function getAttCorrectionByPosition() As System.ServiceModel.Channels.Message Implements IATT00800ByPosStreamingService.getAttCorrectionByPosition
        Dim loException As New R_Exception
        Dim loCls As New ATT00800ByPosCls
        Dim loRtnTemp As New List(Of ATT00800ByPosStreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00800ByPosDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .cShiftDateFrom = R_Utility.R_GetStreamingContext("cShiftDateFrom")
                .cShiftDateTo = R_Utility.R_GetStreamingContext("cShiftDateTo")
            End With

            'loRtnTemp = loCls.getAttCorrectionByPosition(loParam)

            loRtn = R_StreamUtility(Of ATT00800ByPosStreamDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getAttCorrectionByPosition")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getShiftCode() As System.ServiceModel.Channels.Message Implements IATT00800ByPosStreamingService.getShiftCode
        Dim loException As New R_Exception
        Dim loCls As New ATT00800ByPosCls
        Dim loRtnTemp As New List(Of ATT00800ByPosStreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00800ByPosDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .iShiftType = R_Utility.R_GetStreamingContext("iShiftType")
            End With

            'loRtnTemp = loCls.getShiftCode(loParam)

            loRtn = R_StreamUtility(Of ATT00800ByPosStreamDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getShiftCode")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of ATT00800Back.ATT00800ByPosRegDTO)) Implements IATT00800ByPosStreamingService.Dummy

    End Sub

End Class

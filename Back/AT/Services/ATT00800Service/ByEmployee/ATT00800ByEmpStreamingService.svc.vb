Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATT00800Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00800ByEmpStreamingService" in code, svc and config file together.
Public Class ATT00800ByEmpStreamingService
    Implements IATT00800ByEmpStreamingService

    Public Function getAttCorrectionByEmp() As System.ServiceModel.Channels.Message Implements IATT00800ByEmpStreamingService.getAttCorrectionByEmp
        Dim loException As New R_Exception
        Dim loCls As New ATT00800ByEmpCls
        Dim loRtnTemp As New List(Of ATT00800ByEmpStreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00800DTO

        Try
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cShiftDateFrom = R_Utility.R_GetStreamingContext("cShiftDateFrom")
                .cShiftDateTo = R_Utility.R_GetStreamingContext("cShiftDateTo")
            End With

            'loRtnTemp = loCls.getAttCorrectionByEmp(loParam)

            loRtn = R_StreamUtility(Of ATT00800ByEmpStreamDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getAttCorrectionByEmp")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(ByVal poParam1 As System.Collections.Generic.List(Of ATT00800Back.ATT00800ByEmpStreamDTO), ByVal poParam2 As System.Collections.Generic.List(Of ATT00800Back.ATT00800ByEmpRegDTO)) Implements IATT00800ByEmpStreamingService.Dummy

    End Sub

End Class

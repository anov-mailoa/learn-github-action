Imports R_Common
Imports R_BackEnd
Imports LNI00100Back
Imports System.ServiceModel.Channels
Imports LNI00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNI00100StreamingService" in code, svc and config file together.
Public Class LNI00100StreamingService
    Implements ILNI00100StreamingService

    Public Function RFN_Get_Remaining_Loan() As Decimal Implements ILNI00100StreamingService.RFN_Get_Remaining_Loan
        Dim loEx As New R_Exception
        Dim loCls As New LNI00100Cls
        Dim poParam As New LNI00100Dto
        Dim loRtn As Integer

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .dParamDate = R_Utility.R_GetStreamingContext("dParamDate")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            End With

            loRtn = loCls.RFN_Get_Remaining_Loan(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_View_Feasibility() As System.ServiceModel.Channels.Message Implements ILNI00100StreamingService.RSP_View_Feasibility
        Dim loException As New R_Exception
        Dim loCls As New LNI00100Cls
        Dim loRtnTemp As List(Of LNI00100Dto_S)
        Dim loRtn As Message
        Dim loParam As New LNI00100Dto
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
                .cInterestType = R_Utility.R_GetStreamingContext("cInterestType")
                .nOtherLoan = R_Utility.R_GetStreamingContext("nOtherLoan")
                .nInstallmentLimitPct = R_Utility.R_GetStreamingContext("nInstallmentLimitPct")
                .nSalary = R_Utility.R_GetStreamingContext("nSalary")
                .nPrincipal = R_Utility.R_GetStreamingContext("nPrincipal")
                .iMaxLine = R_Utility.R_GetStreamingContext("iMaxLine")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            End With

            loRtnTemp = loCls.RSP_View_Feasibility(loParam)
            loList = R_Utility.R_GetChunkData(Of LNI00100Dto_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_View_Feasibility")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As LNI00100Back.LNI00100Dto) Implements ILNI00100StreamingService.Dummy

    End Sub
End Class

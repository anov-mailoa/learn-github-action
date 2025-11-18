Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports LNR00200Back
Imports LNR00200Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNR00200StreamingService" in code, svc and config file together.
Public Class LNR00200StreamingService
    Implements ILNR00200StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements ILNR00200StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New LNR00200Cls
        Dim loRtnTemp As List(Of LNR00200Dto_S)
        Dim loRtn As Message
        Dim loParam As New LNR00200Dto
        Dim loList As List(Of Byte())
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromInstaSllmentDate = R_Utility.R_GetStreamingContext("cFromInstallmentDate")
                .cToInstallmentDate = R_Utility.R_GetStreamingContext("cToInstallmentDate")
                '.cOption = R_Utility.R_GetStreamingContext("cOption")
                .cOutstanding = R_Utility.R_GetStreamingContext("cOutstanding")
                .cDetail = R_Utility.R_GetStreamingContext("cDetail")
                .cStatus = R_Utility.R_GetStreamingContext("cStatus")
                .cSortBy = R_Utility.R_GetStreamingContext("cSortBy")
                .cAllEmployee = R_Utility.R_GetStreamingContext("cAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
                .cLoanCategoryList = R_Utility.R_GetStreamingContext("cLoanCategoryList")
            End With

            loRtnTemp = loCls.RSP_Loan_Analysis(loParam)
            loList = R_Utility.R_GetChunkData(Of LNR00200Dto_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLoanCategory() As System.ServiceModel.Channels.Message Implements ILNR00200StreamingService.getLoanCategory
        Dim loException As New R_Exception
        Dim loCls As New LNR00200Cls
        Dim loRtnTemp As List(Of LNR00200Dto_Category_S)
        Dim loRtn As Message
        Dim pcCoId As String
        Dim loList As List(Of Byte())
        Try
            pcCoId = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtnTemp = loCls.getLoanCategory(pcCoId)
            loList = R_Utility.R_GetChunkData(Of LNR00200Dto_Category_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLoanCategory")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function


    Public Sub Dummy(poParReguler As System.Collections.Generic.List(Of LNR00200Back.LNR00200Dto_R), poLoanCateg As System.Collections.Generic.List(Of LNR00200Back.LNR00200LoanCategoryDto), poReport As System.Collections.Generic.List(Of LNR00200Back.ReportHeaderDTO)) Implements ILNR00200StreamingService.Dummy

    End Sub
End Class

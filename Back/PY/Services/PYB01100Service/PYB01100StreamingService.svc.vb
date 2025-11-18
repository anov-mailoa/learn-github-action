Imports R_Common
Imports R_BackEnd
Imports PYB01100Back
Imports System.ServiceModel.Channels
Imports PYB01100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB01100StreamingService" in code, svc and config file together.
Public Class PYB01100StreamingService
    Implements IPYB01100StreamingService

    Public Function GetGvSalaryGroupList() As System.ServiceModel.Channels.Message Implements IPYB01100StreamingService.GetGvSalaryGroupList
        Dim loEx As New R_Exception
        Dim loCls As New PYB01100CLS
        Dim poParam As New PYB01100DTO
        Dim loRtnList As New List(Of PYB01100StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPeriode = R_Utility.R_GetStreamingContext("cPeriode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.GetGvSalaryGroupList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB01100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetGvSalaryGroupList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPeriodList() As System.ServiceModel.Channels.Message Implements IPYB01100StreamingService.getPeriodList
        Dim loEx As New R_Exception
        Dim loCls As New PYB01100CLS
        Dim poParam As New PYB01100DTO
        Dim loRtnList As New List(Of PYB01100StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnList = loCls.getPeriodList(poParam)
            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB01100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriodList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPeriod(poParam As PYB01100Back.PYB01100DTO) As String Implements IPYB01100StreamingService.getPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYB01100CLS
        Dim loRtn As String
        Dim loRtnTemp As List(Of PYB01100StreamingDTO)

        Try
            loRtnTemp = loCls.getPeriodList(poParam)

            Dim loQuery = (From A In loRtnTemp
                            Where A.cPeriode.Trim = poParam.cPeriode.Trim
                            Select A).ToList.FirstOrDefault

            If loQuery IsNot Nothing Then
                loRtn = loQuery.cPeriode
            Else
                loRtn = ""
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPYB01100StreamingService.getReportData
        Dim loEx As New R_Exception
        Dim loCls As New PYB01100CLS
        Dim poParam As New PYB01100DTO
        Dim loRtnList As New List(Of PYB01100StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cBuktiPotongNo = R_Utility.R_GetStreamingContext("cBuktiPotongNo")
                .cPeriode = R_Utility.R_GetStreamingContext("cPeriode")
                .iCorrectionNo = R_Utility.R_GetStreamingContext("iCorrectionNo")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cGroupList = R_Utility.R_GetStreamingContext("cGroupList")
                .cKppList = R_Utility.R_GetStreamingContext("cKppList")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")
                .lPrintZeroTax = R_Utility.R_GetStreamingContext("lPrintZeroTax")
                .cTglPemotong = R_Utility.R_GetStreamingContext("cTglPemotong")
                .iReportType = R_Utility.R_GetStreamingContext("iReportType")
                If .iReportType = 6 Then
                    .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                End If
                .LUSE_NIK = R_Utility.R_GetStreamingContext("LUSE_NIK")
            End With

            loRtnList = loCls.getReportData(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB01100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getYearList() As System.ServiceModel.Channels.Message Implements IPYB01100StreamingService.getYearList
        Dim loEx As New R_Exception
        Dim loCls As New PYB01100CLS
        Dim poParam As New PYB01100DTO
        Dim loRtnList As New List(Of PYB01100StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getYearList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB01100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getYearList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar2 As PYB01100Back.PYB01100DTO, poPar3 As PYB01100Back.PYB01100GridDTO) Implements IPYB01100StreamingService.Dummy

    End Sub

End Class

Imports R_Common
Imports R_BackEnd
Imports ESM01300Back
Imports ESM01300Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01300StreamingService" in code, svc and config file together.
Public Class ESM01300StreamingService
    Implements IESM01300StreamingService

    Public Function GetMedicalLimitListHD() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetMedicalLimitListHD
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300MedicalCls
        Dim loRtnTemp As List(Of ESM01300MedicalStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
            End With

            loRtnTemp = loCls.GetMedicalLimitListHD(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01300MedicalStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetMedicalLimitListHD")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMedicalLimitListDT() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetMedicalLimitListDT
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300MedicalCls
        Dim loRtnTemp As List(Of ESM01300MedicalStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CLIMIT_TYPE = R_Utility.R_GetStreamingContext("CLIMIT_TYPE")
                .CITEM_ID = R_Utility.R_GetStreamingContext("CITEM_ID")
                .ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
            End With

            loRtnTemp = loCls.GetMedicalLimitListDT(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01300MedicalStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetMedicalLimitListDT")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMedicalHistoryListHD() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetMedicalHistoryListHD
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300MedicalCls
        Dim loRtnTemp As List(Of ESM01300MedicalStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
                .CEND_DATE = R_Utility.R_GetStreamingContext("CEND_DATE")
                .ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
            End With

            loRtnTemp = loCls.GetMedicalHistoryListHD(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01300MedicalStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetMedicalHistoryListHD")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMedicalHistoryListDT() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetMedicalHistoryListDT
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300MedicalCls
        Dim loRtnTemp As List(Of ESM01300MedicalStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
            End With

            loRtnTemp = loCls.GetMedicalHistoryListDT(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01300MedicalStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetMedicalHistoryListDT")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbBoxList() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetCmbBoxList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300MedicalCls
        Dim loRtnTemp As List(Of ESM01300StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCLASS_APPLICATION = R_Utility.R_GetStreamingContext("CCLASS_APPLICATION")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CITEM_ID = R_Utility.R_GetStreamingContext("CITEM_ID")
            End With

            loRtnTemp = loCls.GetCmbBoxList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbBoxList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetReimbursementList() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetReimbursementList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementHdCLS
        Dim loRtnTemp As List(Of ESM01300ReimbursementStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
                .ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
            End With

            loRtnTemp = loCls.GetReimbursementList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01300ReimbursementStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetReimbursementList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetSubItemsList() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetSubItemsList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300ReimbursementDtCLS
        Dim loRtnTemp As List(Of ESM01300ReimbursementStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
            End With

            loRtnTemp = loCls.GetSubItemsList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01300ReimbursementStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetSubItemsList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbYearList() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetCmbYearList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300MedicalCls
        Dim loRtnTemp As List(Of ESM01300CmbDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.GetCmbYearList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300CmbDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbYearList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Annual Salary Card
    Public Function GetAnnualSalaryList() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetAnnualSalaryList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300AnnualSalaryCls
        Dim loRtnTemp As List(Of ESM01300AnnualSalaryReportDto)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .LSHOW_ZERO_VALUE = R_Utility.R_GetStreamingContext("LSHOW_ZERO_VALUE")
                .ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
            End With

            loRtnTemp = loCls.GetAnnualSalaryList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300AnnualSalaryReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetAnnualSalaryList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbAnnualSalaryYearList() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetCmbAnnualSalaryYearList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300AnnualSalaryCls
        Dim loRtnTemp As List(Of ESM01300CmbDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetCmbAnnualSalaryYearList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300CmbDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbAnnualSalaryYearList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Salary Slip
    Public Function GetSalarySlipReportData() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetSalarySlipReportData
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300SalarySlipCls
        Dim loRtnTemp As List(Of ESM01300SalarySlipReportDto)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CPERIOD = R_Utility.R_GetStreamingContext("CPERIOD")
                .ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
            End With

            loRtnTemp = loCls.GetSalarySlipReportData(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300SalarySlipReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetSalarySlipReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbPeriodList() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetCmbPeriodList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300SalarySlipCls
        Dim loRtnTemp As List(Of ESM01300CmbDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetCmbPeriodList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300CmbDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbPeriodList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'SPT
    Public Function GetSptReportData() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetSptReportData
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300SPT1721_A1Cls
        Dim loRtnTemp As List(Of ESM01300SPTReportDto)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .ENCKEY = R_Utility.R_GetStreamingContext("ENCKEY")
            End With

            loRtnTemp = loCls.GetSptReportData(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300SPTReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetSptReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetSptYearList() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetSptYearList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300SPT1721_A1Cls
        Dim loRtnTemp As List(Of ESM01300CmbDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetSptYearList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300CmbDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetSptYearList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Loan
    Public Function getHeader() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.getHeader
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanCls
        Dim loRtnTemp As List(Of ESM01300LoanStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01300LoanParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnTemp = loCls.getHeader(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300LoanStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHeader")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub GetInstallment() Implements IESM01300StreamingService.GetInstallment
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanCls
        Dim loParam As New ESM01300LoanParameterDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CLOAN_TYPE = R_Utility.R_GetStreamingContext("CLOAN_TYPE")
                .NPRINCIPAL = R_Utility.R_GetStreamingContext("NPRINCIPAL")
                .ICALC_INSTALL_BY = R_Utility.R_GetStreamingContext("ICALC_INSTALL_BY")
                .ITENOR = R_Utility.R_GetStreamingContext("ITENOR")
                .NBASIC_INSTALLMENT = R_Utility.R_GetStreamingContext("NBASIC_INSTALLMENT")
                .IINTERVAL = R_Utility.R_GetStreamingContext("IINTERVAL")
                .NINTEREST_RATE = R_Utility.R_GetStreamingContext("NINTEREST_RATE")
                .CINTEREST_TYPE = R_Utility.R_GetStreamingContext("CINTEREST_TYPE")
                .NINTEREST = R_Utility.R_GetStreamingContext("NINTEREST")
                .CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
            End With

            loCls.GetInstallment(loParam)


        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function GetListLoan() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetListLoan
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanCls
        Dim loRtnTemp As List(Of ESM01300LoanStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01300LoanParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
                .CEND_DATE = R_Utility.R_GetStreamingContext("CEND_DATE")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtnTemp = loCls.GetListLoan(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300LoanStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetListLoan")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetListOutstandingLoan() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetListOutstandingLoan
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanEntryCLS
        Dim loRtnTemp As List(Of ESM01300LoanStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01300LoanParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
                .CEND_DATE = R_Utility.R_GetStreamingContext("CEND_DATE")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtnTemp = loCls.GetListOutstandingLoan(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300LoanStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetListOutstandingLoan")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetListLoanSchedule() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetListLoanSchedule
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanCls
        Dim loRtnTemp As List(Of ESM01300LoanStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01300LoanParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtnTemp = loCls.GetListLoanSchedule(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300LoanStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetListLoanSchedule")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getloanType() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.getloanType
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanCls
        Dim loRtnTemp As List(Of ESM01300LoanComboboxDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01300LoanParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnTemp = loCls.getloanType(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300LoanComboboxDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getloanType")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Summary() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.Summary
        Dim loException As New R_Exception
        Dim loCls As New ESM01300LoanCls
        Dim loParam As New ESM01300LoanParameterDTO
        Dim loRtn As Message
        Dim loRtnTemp As List(Of ESM01300LoanComboboxDTO)
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CLOAN_TYPE = R_Utility.R_GetStreamingContext("CLOAN_TYPE")
                .NPRINCIPAL = R_Utility.R_GetStreamingContext("NPRINCIPAL")
                .ICALC_INSTALL_BY = R_Utility.R_GetStreamingContext("ICALC_INSTALL_BY")
                .ITENOR = R_Utility.R_GetStreamingContext("ITENOR")
                .NBASIC_INSTALLMENT = R_Utility.R_GetStreamingContext("NBASIC_INSTALLMENT")
                .IINTERVAL = R_Utility.R_GetStreamingContext("IINTERVAL")
                .NINTEREST_RATE = R_Utility.R_GetStreamingContext("NINTEREST_RATE")
                .CINTEREST_TYPE = R_Utility.R_GetStreamingContext("CINTEREST_TYPE")
                .NINTEREST = R_Utility.R_GetStreamingContext("NINTEREST")
                .CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
            End With


            loRtnTemp = loCls.Summary(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01300LoanComboboxDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "Summary")


        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub ParamDTO(poGridMedical As System.Collections.Generic.List(Of ESM01300Back.ESM01300MedicalGridDTO), poGridReimbursement As System.Collections.Generic.List(Of ESM01300Back.ESM01300ReimbursementGridDTO)) Implements IESM01300StreamingService.ParamDTO

    End Sub

    Public Function GetCmbForWhomName() As System.ServiceModel.Channels.Message Implements IESM01300StreamingService.GetCmbForWhomName
        Dim loEx As New R_Exception
        Dim loCls As New ESM01300MedicalCls
        Dim loRtnTemp As List(Of ESM01300CmbDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ESM01300DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
                .CFOR_WHOM = R_Utility.R_GetStreamingContext("CFOR_WHOM")
            End With

            loRtnTemp = loCls.GetCmbForWhomName(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01300CmbDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbForWhomName")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

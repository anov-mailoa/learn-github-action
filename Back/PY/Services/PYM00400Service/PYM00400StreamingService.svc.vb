Imports R_Common
Imports System.ServiceModel.Channels
Imports PYM00400Back
Imports PYM00400Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00400StreamingService" in code, svc and config file together.
Public Class PYM00400StreamingService
    Implements IPYM00400StreamingService

    Public Function getDataKPPMaster() As System.ServiceModel.Channels.Message Implements IPYM00400StreamingService.getDataKPPMaster
        Dim loCls As New PYM00400KPPMasterCLS
        Dim poParam As New PYM00400KPPMasterDTO
        Dim loRtnList As New List(Of PYM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.CDISPLAY_TYPE = R_Utility.R_GetStreamingContext("CDISPLAY_TYPE")

            loRtnList = loCls.getDataKPPMaster(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataKPPMaster")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataPPH21() As System.ServiceModel.Channels.Message Implements IPYM00400StreamingService.getDataPPH21
        Dim loCls As New PYM00400PPH21CLS
        Dim poParam As New PYM00400PPH21DTO
        Dim loRtnList As New List(Of PYM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getDataPPH21(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataPPH21")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPKPDataList() As System.ServiceModel.Channels.Message Implements IPYM00400StreamingService.getPKPDataList
        Dim loCls As New PYM00400PPH21CLS
        Dim poParam As New PYM00400PKPListGridDTO
        Dim loRtnList As New List(Of PYM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnList = loCls.getPKPDataList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPKPDataList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataSevern() As System.ServiceModel.Channels.Message Implements IPYM00400StreamingService.getDataSevern
        Dim loCls As New PYM00400SevernCLS
        Dim poParam As New PYM00400SevernDTO
        Dim loRtnList As New List(Of PYM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getDataSevern(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataSevern")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSevernPKPDataList() As System.ServiceModel.Channels.Message Implements IPYM00400StreamingService.getSevernPKPDataList
        Dim loCls As New PYM00400SevernCLS
        Dim poParam As New PYM00400PKPListGridDTO
        Dim loRtnList As New List(Of PYM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnList = loCls.getSevernPKPDataList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSevernPKPDataList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbPeriod() As System.ServiceModel.Channels.Message Implements IPYM00400StreamingService.getCmbPeriod
        Dim loCls As New PYM00400CustomTaxCLS
        Dim poParam As New PYM00400CustomTaxDTO
        Dim loRtnList As New List(Of PYM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
            End With

            loRtnList = loCls.getCmbPeriod(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPeriod")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGridCustomTax() As System.ServiceModel.Channels.Message Implements IPYM00400StreamingService.getGridCustomTax
        Dim loCls As New PYM00400CustomTaxCLS
        Dim poParam As New PYM00400CustomTaxDTO
        Dim loRtnList As New List(Of PYM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
            End With

            loRtnList = loCls.getGridCustomTax(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridCustomTax")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPeriode() As System.ServiceModel.Channels.Message Implements IPYM00400StreamingService.getPeriode
        Dim loCls As New PYM00400PKPMonthlyCLS
        Dim poParam As New PYM00400PKPMonthlyDTO
        Dim loRtnList As New List(Of PYM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnList = loCls.getPeriode(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPeriode")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getPKPDT() As System.ServiceModel.Channels.Message Implements IPYM00400StreamingService.getPKPDT
        Dim loCls As New PYM00400PKPMonthlyCLS
        Dim poParam As New PYM00400PKPMonthlyDTO
        Dim loRtnList As New List(Of PYM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CPERIODE = R_Utility.R_GetStreamingContext("CPERIODE")
                .CTIPE_TARIF = R_Utility.R_GetStreamingContext("CTIPE_TARIF")
            End With

            loRtnList = loCls.getPKPDT(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPKPDT")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getPKPHD() As System.ServiceModel.Channels.Message Implements IPYM00400StreamingService.getPKPHD
        Dim loCls As New PYM00400PKPMonthlyCLS
        Dim poParam As New PYM00400PKPMonthlyDTO
        Dim loRtnList As New List(Of PYM00400StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CPERIODE = R_Utility.R_GetStreamingContext("CPERIODE")
            End With

            loRtnList = loCls.getPKPHD(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00400StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPKPHD")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class

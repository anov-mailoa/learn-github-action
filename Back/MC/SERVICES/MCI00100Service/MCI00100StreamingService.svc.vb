Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCI00100Back
Imports MCI00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCI00100StreamingService" in code, svc and config file together.
Public Class MCI00100StreamingService
    Implements IMCI00100StreamingService

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IMCI00100StreamingService.GetEmployeeList
        Dim loCls As New MCI00100CLS
        Dim poParam As New MCI00100ParamDTO
        Dim loRtnList As New List(Of MCI00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CLANGID = R_Utility.R_GetStreamingContext("CLANGID")
                .CENCKEY = R_Utility.R_GetStreamingContext("CENCKEY")
                .CUSERID = R_Utility.R_GetStreamingContext("CUSERID")
            End With

            loRtnList = loCls.GetEmployeeList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCI00100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "GetEmployeeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEmpSeparateLimitList() As System.ServiceModel.Channels.Message Implements IMCI00100StreamingService.GetEmpSeparateLimitList
        Dim loCls As New MCI00100CLS
        Dim poParam As New MCI00100ParamDTO
        Dim loRtnList As New List(Of MCI00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CLANGID = R_Utility.R_GetStreamingContext("CLANGID")
                .CENCKEY = R_Utility.R_GetStreamingContext("CENCKEY")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnList = loCls.GetEmpSeparateLimitList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCI00100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "GetEmpSeparateLimitList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetClaimTransList() As System.ServiceModel.Channels.Message Implements IMCI00100StreamingService.GetClaimTransList
        Dim loCls As New MCI00100CLS
        Dim poParam As New MCI00100ParamDTO
        Dim loRtnList As New List(Of MCI00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CLANGID = R_Utility.R_GetStreamingContext("CLANGID")
                .CENCKEY = R_Utility.R_GetStreamingContext("CENCKEY")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnList = loCls.GetClaimTransList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCI00100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "GetClaimTransList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCorrectionTransList() As System.ServiceModel.Channels.Message Implements IMCI00100StreamingService.GetCorrectionTransList
        Dim loCls As New MCI00100CLS
        Dim poParam As New MCI00100ParamDTO
        Dim loRtnList As New List(Of MCI00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CLANGID = R_Utility.R_GetStreamingContext("CLANGID")
                .CENCKEY = R_Utility.R_GetStreamingContext("CENCKEY")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnList = loCls.GetCorrectionTransList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCI00100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "GetCorrectionTransList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(oData As System.Collections.Generic.List(Of MCI00100Back.MCI00100DTO)) Implements IMCI00100StreamingService.Dummy

    End Sub

    Public Function GetEmpSummaryInfo(poParam As MCI00100Back.MCI00100ParamDTO) As MCI00100Back.MCI00100DTO Implements IMCI00100StreamingService.GetEmpSummaryInfo
        Dim loCls As New MCI00100CLS
        Dim loRtn As New MCI00100DTO
        Dim loEx As New R_Exception

        Try

            loRtn = loCls.GetEmpSummaryInfo(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetYear(pcCompId As String) As MCI00100Back.MCI00100DTO Implements IMCI00100StreamingService.GetYear
        Dim loCls As New MCI00100CLS
        Dim loRtn As New MCI00100DTO
        Dim loEx As New R_Exception

        Try

            loRtn = loCls.GetYear(pcCompId)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetFamilyList() As System.ServiceModel.Channels.Message Implements IMCI00100StreamingService.GetFamilyList
        Dim loCls As New MCI00100CLS
        Dim poParam As New MCI00100ParamDTO
        Dim loRtnList As New List(Of MCI00100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CLANGID = R_Utility.R_GetStreamingContext("CLANGID")
                .CENCKEY = R_Utility.R_GetStreamingContext("CENCKEY")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnList = loCls.GetFamilyList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCI00100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "GetFamilyList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub UpdateFamilyInfo(poParam As MCI00100Back.MCI00100ParamDTO) Implements IMCI00100StreamingService.UpdateFamilyInfo
        Dim loCls As New MCI00100CLS
        Dim loEx As New R_Exception

        Try
            loCls.UpdateFamilyInfo(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class

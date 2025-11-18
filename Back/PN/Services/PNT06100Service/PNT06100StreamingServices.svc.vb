Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNT06100Back
Imports PNT06100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT06100StreamingServices" in code, svc and config file together.
Public Class PNT06100StreamingServices
    Implements IPNT06100StreamingServices

    Public Function getListGridAssignment() As System.ServiceModel.Channels.Message Implements IPNT06100StreamingServices.getListGridAssignment
        Dim loCls As New PNT06100AssignmentDtCls
        Dim poParam As New PNT06100AssignmentDtGridDto
        Dim loRtnTemp As List(Of PNT06100StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getListGridAssignment(poParam)

            ' If there is data, convert to Message
            If loRtnTemp IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of PNT06100StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGridAssignment")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getFacility() As System.ServiceModel.Channels.Message Implements IPNT06100StreamingServices.getFacility
        Dim loCls As New PNT06100AssignmentDtCls
        Dim loRtnTemp As List(Of PNT06100StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT06100AssignmentDtDto
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReferenceDate = R_Utility.R_GetStreamingContext("cReferenceDate")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                '.cFacilityCode = R_Utility.R_GetStreamingContext("cFacilityCode")
            End With

            loRtnTemp = loCls.getFacility(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT06100StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getFacility")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListEmpFac() As System.ServiceModel.Channels.Message Implements IPNT06100StreamingServices.getListEmpFac
        Dim loCls As New PNT06100EmployeeFacilitiesCls
        Dim poParam As New PNT06100EmployeeGridDto
        Dim loRtnTemp As List(Of PNT06100StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getListEmpFac(poParam)

            ' If there is data, convert to Message
            If loRtnTemp IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of PNT06100StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListEmpFac")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNT06100StreamingServices.getReport
        Dim loException As New R_Exception
        Dim loCls As New PNT06100AssignmentHdCls
        Dim poParam As New PNT06100AssignmentHdDto
        Dim loRtnTemp As List(Of PNT06100ReportDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cReferenceDate = R_Utility.R_GetStreamingContext("cReferenceDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT06100ReportDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PNT06100Back.PNT06100AssignmentDtGridDto), poParam2 As System.Collections.Generic.List(Of PNT06100Back.PNT06100EmployeeGridDto)) Implements IPNT06100StreamingServices.Dummy

    End Sub
End Class

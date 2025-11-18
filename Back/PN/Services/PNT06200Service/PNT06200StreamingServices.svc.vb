Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNT06200Back
Imports PNT06200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT06200StreamingServices" in code, svc and config file together.
Public Class PNT06200StreamingServices
    Implements IPNT06200StreamingServices

    Public Function getFacility() As System.ServiceModel.Channels.Message Implements IPNT06200StreamingServices.getFacility
        Dim loCls As New PNT06200ReturnDtCls
        Dim loRtnTemp As List(Of PNT06200StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNT06200ReturnDtDto
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReferenceDate = R_Utility.R_GetStreamingContext("cReferenceDate")
                .cFacilityCode = R_Utility.R_GetStreamingContext("cFacilityCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getFacility(poParam)
            loList = R_Utility.R_GetChunkData(Of PNT06200StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getFacility")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListEmpFac() As System.ServiceModel.Channels.Message Implements IPNT06200StreamingServices.getListEmpFac
        Dim loCls As New PNT06200EmployeeFacilitiesCls
        Dim poParam As New PNT06200EmployeeGridDto
        Dim loRtnTemp As List(Of PNT06200StreamingDto)
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
                loList = R_Utility.R_GetChunkData(Of PNT06200StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListEmpFac")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListGridReturn() As System.ServiceModel.Channels.Message Implements IPNT06200StreamingServices.getListGridReturn
        Dim loCls As New PNT06200ReturnDtCls
        Dim poParam As New PNT06200ReturnDtGridDto
        Dim loRtnTemp As List(Of PNT06200StreamingDto)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getListGridReturn(poParam)

            ' If there is data, convert to Message
            If loRtnTemp IsNot Nothing Then
                loList = R_Utility.R_GetChunkData(Of PNT06200StreamingDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
                loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGridReturn")
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PNT06200Back.PNT06200ReturnDtGridDto), poParam2 As System.Collections.Generic.List(Of PNT06200Back.PNT06200EmployeeGridDto)) Implements IPNT06200StreamingServices.Dummy

    End Sub
End Class

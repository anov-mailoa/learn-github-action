Imports R_Common
Imports ESI01000Back
Imports ESI01000Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESI01000StreamingService" in code, svc and config file together.
Public Class ESI01000StreamingService
    Implements IESI01000StreamingService

    Public Sub Dummy(poParam As ESI01000Back.ParameterDTO) Implements IESI01000StreamingService.Dummy

    End Sub

    Public Function getCmbTransType() As System.ServiceModel.Channels.Message Implements IESI01000StreamingService.getCmbTransType
        Dim loEx As New R_Exception
        Dim loCls As New ESI01000CLS
        Dim loRtnTemp As List(Of ESI01000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.getCmbTransType(loParam)

            loList = R_Utility.R_GetChunkData(Of ESI01000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbTransType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSearchList() As System.ServiceModel.Channels.Message Implements IESI01000StreamingService.getSearchList
        Dim loEx As New R_Exception
        Dim loCls As New ESI01000CLS
        Dim loRtnTemp As List(Of ESI01000StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_TYPE = R_Utility.R_GetStreamingContext("CTRANSACTION_TYPE")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            Dim lcEmployees As String
            Dim loEmployees As New List(Of ESI01000EmployeeDTO)
            lcEmployees = R_Utility.R_GetStreamingContext("oEmployees")
            loEmployees = R_Utility.XMLToObject(Of List(Of ESI01000EmployeeDTO))(lcEmployees)

            loRtnTemp = loCls.getSearchList(loParam, loEmployees)

            loList = R_Utility.R_GetChunkData(Of ESI01000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSearchList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

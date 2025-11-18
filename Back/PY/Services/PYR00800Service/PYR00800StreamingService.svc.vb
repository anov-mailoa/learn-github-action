Imports R_Common
Imports R_BackEnd
Imports PYR00800Common
Imports PYR00800Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYR00800StreamingService" in code, svc and config file together.
Public Class PYR00800StreamingService
    Implements IPYR00800StreamingService


    Public Function LoadGrid() As System.ServiceModel.Channels.Message Implements IPYR00800StreamingService.LoadGrid
        Dim loEx As New R_Exception
        Dim loCls As New PYR00800Cls
        Dim poParam As New PYR00800Dto
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR00800StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                '.cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
                '.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.LoadGrid(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR00800StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "LoadGrid")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_EMP_SALARY_SLIP() As System.ServiceModel.Channels.Message Implements IPYR00800StreamingService.RSP_EMP_SALARY_SLIP
        Dim loEx As New R_Exception
        Dim loCls As New PYR00800Cls
        Dim poParam As New PYR00800Dto
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of RSP_EMP_SALARY_SLIP_DTO_S)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                '.cSalaryGroupList = R_Utility.R_GetStreamingContext("cGroupCode")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cEncryptKey = R_Utility.R_GetStreamingContext("cEncryptKey")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            Dim lcGroup As String
            Dim loGroup As New List(Of PYR00800GroupDTO)
            lcGroup = R_Utility.R_GetStreamingContext("oGroup")
            loGroup = R_Utility.XMLToObject(Of List(Of PYR00800GroupDTO))(lcGroup)

            loRtnList = loCls.RSP_EMP_SALARY_SLIP(poParam, loGroup)
            loList = R_Utility.R_GetChunkData(Of RSP_EMP_SALARY_SLIP_DTO_S)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_EMP_SALARY_SLIP")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParamDto As System.Collections.Generic.List(Of PYR00800Back.PYR00800Dto), poParamGv As System.Collections.Generic.List(Of PYR00800Back.GvSalaryGroupDto)) Implements IPYR00800StreamingService.Dummy

    End Sub

    Public Function getCmbPeriod() As System.ServiceModel.Channels.Message Implements IPYR00800StreamingService.getCmbPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYR00800Cls
        Dim poParam As New PYR00800Dto
        Dim loList As List(Of Byte())
        Dim loRtnList As New List(Of PYR00800StreamingDTO)
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getCmbPeriod(poParam)
            loList = R_Utility.R_GetChunkData(Of PYR00800StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPeriod")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

Imports R_Common
Imports PYM01400Back
Imports System.ServiceModel.Channels
Imports PYM01400Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01400StreamingService" in code, svc and config file together.
Public Class PYM01400StreamingService
    Implements IPYM01400StreamingService

    Public Function Get_Department() As System.ServiceModel.Channels.Message Implements IPYM01400StreamingService.Get_Department
        Dim loEx As New R_Exception
        Dim loCls As New PYM01400Cls
        Dim loRtnTemp As List(Of DepartmentDto_S)
        Dim loRtn As Message
        Dim loParam As New PYM01400Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.Get_Department(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of DepartmentDto_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "Get_Department")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Get_Kode_Pajak() As System.ServiceModel.Channels.Message Implements IPYM01400StreamingService.Get_Kode_Pajak
        Dim loEx As New R_Exception
        Dim loCls As New PYM01400Cls
        Dim loRtnTemp As List(Of KodePajakDTO_S)
        Dim loRtn As Message
        Dim loParam As New PYM01400Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.Get_Kode_Pajak(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of KodePajakDTO_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "Get_Kode_Pajak")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Get_KPP() As System.ServiceModel.Channels.Message Implements IPYM01400StreamingService.Get_KPP
        Dim loEx As New R_Exception
        Dim loCls As New PYM01400Cls
        Dim loRtnTemp As List(Of KPPDTO_S)
        Dim loRtn As Message
        Dim loParam As New PYM01400Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.Get_KPP(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of KPPDTO_S)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "Get_KPP")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar4 As System.Collections.Generic.List(Of PYM01400Back.KPPDTO_R), poPar5 As System.Collections.Generic.List(Of PYM01400Back.DepartmentDto_R), poPar6 As System.Collections.Generic.List(Of PYM01400Back.KodePajakDTO_R), poPar8 As System.Collections.Generic.List(Of PYM01400Back.PYM01400GridDto_R), poPar9 As System.Collections.Generic.List(Of PYM01400Back.LookUpCmbDTO_R), poPar10 As System.Collections.Generic.List(Of PYM01400Back.DropDownListIdentityTypeDto), poPar11 As System.Collections.Generic.List(Of PYM01400Back.DropDownTaxStatusDto), poPar13 As System.Collections.Generic.List(Of PYM01400Back.PYT01400GridDto_R)) Implements IPYM01400StreamingService.Dummy

    End Sub
End Class

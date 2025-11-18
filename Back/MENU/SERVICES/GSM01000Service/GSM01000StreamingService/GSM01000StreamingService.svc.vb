Imports R_Common
Imports R_BackEnd
Imports GSM01000Back
Imports GSM01000Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01000StreamingService" in code, svc and config file together.
Public Class GSM01000StreamingService
    Implements IGSM01000StreamingService

    Public Function getTransProfile() As System.ServiceModel.Channels.Message Implements IGSM01000StreamingService.getTransProfile
        Dim loException As New R_Exception
        Dim loCls As New GSM01000Cls
        Dim loRtnTemp As List(Of GSM01000TransProfileDTOnon)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getTransProfile(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01000TransProfileDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransProfile")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListDepartment() As System.ServiceModel.Channels.Message Implements IGSM01000StreamingService.getListDepartment
        Dim loException As New R_Exception
        Dim loCls As New GSM01001Cls
        Dim loRtnTemp As List(Of GSM01000DeptListDTO)
        Dim loRtn As Message = Nothing
        Dim pcCompId, pcTransCd As String
        Dim loList As List(Of Byte())

        Try

            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcTransCd = R_Utility.R_GetStreamingContext("cTransactionCode")


            loRtnTemp = loCls.getListDepartment(pcCompId, pcTransCd)
            loList = R_Utility.R_GetChunkData(Of GSM01000DeptListDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDepartment")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of GSM01000Back.GSM01000TransProfileDTO)) Implements IGSM01000StreamingService.Dummy

    End Sub
End Class

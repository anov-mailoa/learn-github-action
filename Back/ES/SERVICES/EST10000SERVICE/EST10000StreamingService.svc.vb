Imports R_Common
Imports R_BackEnd
Imports EST10000Back
Imports EST10000Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "EST10000StreamingService" in code, svc and config file together.
Public Class EST10000StreamingService
    Implements IEST10000StreamingService

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IEST10000StreamingService.GetEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New EST10000Cls
        Dim loRtnTemp As List(Of EST10000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST10000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With


            loRtnTemp = loCls.GetEmployeeList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST10000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")
            'ASDSADSAD
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetFamilyDataList() As System.ServiceModel.Channels.Message Implements IEST10000StreamingService.GetFamilyDataList
        Dim loEx As New R_Exception
        Dim loCls As New EST10000Cls
        Dim loRtnTemp As List(Of EST10000FamilyStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST10000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetFamilyDataList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST10000FamilyStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetFamilyDataList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetBankAccountList() As System.ServiceModel.Channels.Message Implements IEST10000StreamingService.GetBankAccountList
        Dim loEx As New R_Exception
        Dim loCls As New EST10000Cls
        Dim loRtnTemp As List(Of EST10000BankAccStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST10000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetBankAccountList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST10000BankAccStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetBankAccountList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEmergencyContactList() As System.ServiceModel.Channels.Message Implements IEST10000StreamingService.GetEmergencyContactList
        Dim loEx As New R_Exception
        Dim loCls As New EST10000Cls
        Dim loRtnTemp As List(Of EST10000EmergencyStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST10000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetEmergencyContactList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST10000EmergencyStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmergencyContactList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetFormalEducationList() As System.ServiceModel.Channels.Message Implements IEST10000StreamingService.GetFormalEducationList
        Dim loEx As New R_Exception
        Dim loCls As New EST10000Cls
        Dim loRtnTemp As List(Of EST10000FormalEducationStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST10000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetFormalEducationList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST10000FormalEducationStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetFormalEducationList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLanguageList() As System.ServiceModel.Channels.Message Implements IEST10000StreamingService.GetLanguageList
        Dim loEx As New R_Exception
        Dim loCls As New EST10000Cls
        Dim loRtnTemp As List(Of EST10000LanguageStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST10000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetLanguageList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST10000LanguageStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLanguageList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLicenseList() As System.ServiceModel.Channels.Message Implements IEST10000StreamingService.GetLicenseList
        Dim loEx As New R_Exception
        Dim loCls As New EST10000Cls
        Dim loRtnTemp As List(Of EST10000LicenseStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST10000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetLicenseList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST10000LicenseStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLicenseList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTrainingHistoryList() As System.ServiceModel.Channels.Message Implements IEST10000StreamingService.GetTrainingHistoryList
        Dim loEx As New R_Exception
        Dim loCls As New EST10000Cls
        Dim loRtnTemp As List(Of EST10000TrainingHistoryStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST10000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetTrainingHistoryList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST10000TrainingHistoryStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTrainingHistoryList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetWorkExperienceList() As System.ServiceModel.Channels.Message Implements IEST10000StreamingService.GetWorkExperienceList
        Dim loEx As New R_Exception
        Dim loCls As New EST10000Cls
        Dim loRtnTemp As List(Of EST10000WorkExpStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST10000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetWorkExperienceList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST10000WorkExpStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetWorkExperienceList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub DummyDTO(poPar As System.Collections.Generic.List(Of EST10000Back.EST10000GridDTO)) Implements IEST10000StreamingService.DummyDTO

    End Sub

    Public Function getMedicalHistoryList() As System.ServiceModel.Channels.Message Implements IEST10000StreamingService.getMedicalHistoryList
        Dim loEx As New R_Exception
        Dim loCls As New EST10000Cls
        Dim loRtnTemp As List(Of EST10000MedicalHistoryStreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New EST10000DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.GetMedicalHistoryList(loParam)

            loList = R_Utility.R_GetChunkData(Of EST10000MedicalHistoryStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMedicalHistoryList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

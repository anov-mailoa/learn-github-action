Imports R_Common
Imports ESM01100Back
Imports System.ServiceModel.Channels
Imports ESM01100Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01100StreamingService" in code, svc and config file together.
Public Class ESM01100StreamingService
    Implements IESM01100StreamingService

    Public Function getListComboBox() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getListComboBox
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100CLS
        Dim loRtnTemp As List(Of ESM01100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCLASS_APPLICATION = R_Utility.R_GetStreamingContext("CCLASS_APPLICATION")
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CCLASS_ID = R_Utility.R_GetStreamingContext("CCLASS_ID")
                .CCLASS_RECID = R_Utility.R_GetStreamingContext("CCLASS_RECID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnTemp = loCls.getListComboBox(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListComboBox")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#Region "GET LIST"

    Public Function getFamilyList() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getFamilyList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100FamilyCLS
        Dim loRtnTemp As List(Of ESM01100FamilyStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getFamilyList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01100FamilyStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getFamilyList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmergencyList() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getEmergencyList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100EmergencyCLS
        Dim loRtnTemp As List(Of ESM01100EmergencyStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getEmergencyList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01100EmergencyStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmergencyList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getBankAccList() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getBankAccList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100BankAccCLS
        Dim loRtnTemp As List(Of ESM01100BankAccStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getBankAccList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01100BankAccStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBankAccList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEducationList() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getEducationList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100EducationCLS
        Dim loRtnTemp As List(Of ESM01100EducationStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getEducationList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01100EducationStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEducationList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLanguageList() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getLanguageList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100LanguageCLS
        Dim loRtnTemp As List(Of ESM01100LanguageStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getLanguageList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01100LanguageStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLanguageList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLicenseList() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getLicenseList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100LicenseCLS
        Dim loRtnTemp As List(Of ESM01100LicenseStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getLicenseList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01100LicenseStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLicenseList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTrainingList() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getTrainingList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100TrainingCLS
        Dim loRtnTemp As List(Of ESM01100TrainingStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getTrainingList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01100TrainingStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTrainingList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getWorkExpList() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getWorkExpList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100WorkExpCLS
        Dim loRtnTemp As List(Of ESM01100WorkExpStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getWorkExpList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01100WorkExpStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getWorkExpList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedicalHistoryList() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getMedicalHistoryList
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100MedicalHistoryCLS
        Dim loRtnTemp As List(Of ESM01100MedicalHistoryStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.getMedicalHistoryList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01100MedicalHistoryStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMedicalHistoryList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

    Public Function getCmbTraining() As System.ServiceModel.Channels.Message Implements IESM01100StreamingService.getCmbTraining
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100TrainingCLS
        Dim loRtnTemp As List(Of ComboBoxStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01100ParamDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CCAT_TRAINING_CODE = R_Utility.R_GetStreamingContext("CCAT_TRAINING_CODE")
            End With

            loRtnTemp = loCls.getCmbTraining(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ComboBoxStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbTraining")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    
End Class

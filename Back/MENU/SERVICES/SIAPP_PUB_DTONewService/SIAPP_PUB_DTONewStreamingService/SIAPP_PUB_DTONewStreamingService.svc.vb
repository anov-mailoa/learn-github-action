Imports R_Common
Imports SIAPP_PUB_DTO_NEW
Imports System.ServiceModel.Channels
Imports SIAPP_PUBCommon
Imports R_BackEnd
Imports SIAPP_SERVICE_MENU

' NOTE: You can use the "Rename" command on the context menu to change the class name "SIAPP_PUB_DTOStreamingService" in code, svc and config file together.
Public Class SIAPP_PUB_DTONewStreamingService
    Implements ISIAPP_PUB_DTONewStreamingService

#Region "LOOK UP"

#Region "PERSONAL LOOKUP SECTION"

    Public Function getCmbPattern() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbPattern
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbPattern(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPattern")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCountry() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpCountry
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCountryDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpCountry(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCountryDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpCountry")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpProvince() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpProvince
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpProvinceDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cCountryCode = R_Utility.R_GetStreamingContext("cCountryCode")
            End With

            loRtnTemp = loCls.getLookUpProvince(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpProvinceDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpProvince")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCity() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpCity
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCityDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cCountryCode = R_Utility.R_GetStreamingContext("cCountryCode")
                .cProvinceCode = R_Utility.R_GetStreamingContext("cProvinceCode")
            End With

            loRtnTemp = loCls.getLookUpCity(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCityDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpCity")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpPosition() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpPosition
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpPositionDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpPosition(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpPositionDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpPosition")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpLocation() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpLocation
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpLocationDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpLocation(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpLocationDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpLocation")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpGrade() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpGrade
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpGradeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpGrade(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpGradeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpGrade")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCode() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpCode
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCodeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cClassApplication = R_Utility.R_GetStreamingContext("cClassApplication")
                .cClassId = R_Utility.R_GetStreamingContext("cClassId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpCode(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCodeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpCode")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO
        ''
        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cEmployeeType = R_Utility.R_GetStreamingContext("cEmployeeType")
                .cResign = R_Utility.R_GetStreamingContext("cResign")
                .cProbation = R_Utility.R_GetStreamingContext("cProbation")
            End With

            loRtnTemp = loCls.getLookUpEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpActiveEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpActiveEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpActiveEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cEmployeeType = R_Utility.R_GetStreamingContext("cEmployeeType")
                .cResign = R_Utility.R_GetStreamingContext("cResign")
                .cProbation = R_Utility.R_GetStreamingContext("cProbation")
            End With

            loRtnTemp = loCls.getLookUpActiveEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpActiveEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpActiveEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeWithFacility() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployeeWithFacility
        '
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeWithFacilityDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cEmployeeType = R_Utility.R_GetStreamingContext("cEmployeeType")
                .cResign = R_Utility.R_GetStreamingContext("cResign")
                .cProbation = R_Utility.R_GetStreamingContext("cProbation")
            End With

            loRtnTemp = loCls.getLookUpEmployeeWithFacility(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpEmployeeWithFacilityDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployeeWithFacility")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpActiveContractEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpActiveContractEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpActiveContractEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cEmployeeType = R_Utility.R_GetStreamingContext("cEmployeeType")
                .cResign = R_Utility.R_GetStreamingContext("cResign")
                .cProbation = R_Utility.R_GetStreamingContext("cProbation")
            End With

            loRtnTemp = loCls.getLookUpActiveContractEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpActiveContractEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpActiveContractEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpProbationEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpProbationEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpProbationEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cEmployeeType = R_Utility.R_GetStreamingContext("cEmployeeType")
                .cResign = R_Utility.R_GetStreamingContext("cResign")
                .cProbation = R_Utility.R_GetStreamingContext("cProbation")
            End With

            loRtnTemp = loCls.getLookUpProbationEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpProbationEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpProbationEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpResignedContractEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpResignedContractEmployee


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpResignedContractEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cEmployeeType = R_Utility.R_GetStreamingContext("cEmployeeType")
                .cResign = R_Utility.R_GetStreamingContext("cResign")
                .cProbation = R_Utility.R_GetStreamingContext("cProbation")
            End With

            loRtnTemp = loCls.getLookUpResignedContractEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpResignedContractEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpResignedContractEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function getLookUpReactivationEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpReactivationEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpReactivationEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cEmployeeType = R_Utility.R_GetStreamingContext("cEmployeeType")
                .cResign = R_Utility.R_GetStreamingContext("cResign")
                .cProbation = R_Utility.R_GetStreamingContext("cProbation")
            End With

            loRtnTemp = loCls.getLookUpReactivationEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpReactivationEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpReactivationEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn



    End Function

    Public Function getFacilityDeviceLookup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getFacilityDeviceLookup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpFacilityDeviceDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFacilityOpdevice = R_Utility.R_GetStreamingContext("cFacilityOpdevice")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            End With

            loRtnTemp = loCls.getFacilityDeviceLookup(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpFacilityDeviceDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getFacilityDeviceLookup")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployeeResignLookup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getEmployeeResignLookup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getEmployeeResignLookup(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployeeResignLookup")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCategory() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpCategory
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCodeDTO_N)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.getLookUpCategory()

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCodeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpCategory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCriteria() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpCriteria
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCriteriaDTO_N)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.getLookUpCriteria()

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCriteriaDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpCriteria")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpMasterFacility() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMasterFacility
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpFacilityDeviceDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFacilityOpdevice = R_Utility.R_GetStreamingContext("cFacilityOpdevice")
            End With

            loRtnTemp = loCls.getLookUpMasterFacility(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpFacilityDeviceDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMasterFacility")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpFasilitasKesehatan() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpFasilitasKesehatan
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpFasilitasKesehatanDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cJenisFaskes = R_Utility.R_GetStreamingContext("cJenisFaskes")
                .cProvinsi = R_Utility.R_GetStreamingContext("cProvinsi")
                .cKabupatenKota = R_Utility.R_GetStreamingContext("cKabupatenKota")
                .cKecamatan = R_Utility.R_GetStreamingContext("cKecamatan")
                .cKelurahanDesa = R_Utility.R_GetStreamingContext("cKelurahanDesa")
            End With

            loRtnTemp = loCls.getLookUpFasilitasKesehatan(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpFasilitasKesehatanDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpFasilitasKesehatan")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpReligion() As Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpReligion
        Dim loEx As New R_Exception
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpReligion(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpReligion")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLookUpGeography() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpGeography
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpGeographyDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .nTingkatWilayah = R_Utility.R_GetStreamingContext("nTingkatWilayah")
                .cKodeParent = R_Utility.R_GetStreamingContext("cKodeParent")
            End With

            loRtnTemp = loCls.getLookUpGeography(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpGeographyDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpGeography")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpReference() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpReference

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpReferenceDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cTransactionStatus = R_Utility.R_GetStreamingContext("cTransactionStatus")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
            End With

            loRtnTemp = loCls.getLookUpReference(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpReferenceDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpReference")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMaintenance() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMaintenance

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMaintenanceDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getLookUpMaintenance(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMaintenanceDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMaintenance")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpTraining() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpTraining

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTrainingDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .cCompetencyCode = R_Utility.R_GetStreamingContext("cCompetencyCode")
            End With

            loRtnTemp = loCls.getLookUpTraining(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpTrainingDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpTraining")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpEmployeePNL11000() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployeePNL11000

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeePNL11000DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cProgramCode = R_Utility.R_GetStreamingContext("cProgramCode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getLookUpEmployeePNL11000(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpEmployeePNL11000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployeePNL11000")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpAnggotaKeluargaPNL15000() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpAnggotaKeluargaPNL15000


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAnggotaKeluargaPNL15000DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
                .cNoKartuKeluarga = R_Utility.R_GetStreamingContext("cNoKartuKeluarga")
                .lIncludeEmployee = R_Utility.R_GetStreamingContext("lIncludeEmployee")
            End With

            loRtnTemp = loCls.getLookUpAnggotaKeluargaPNL15000(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpAnggotaKeluargaPNL15000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpAnggotaKeluargaPNL15000")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function getLookUpTemporaryAssignmentPNL00520() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpTemporaryAssignmentPNL00520


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTemporaryAssignmentPNL00520DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                '.cViewDate = R_Utility.R_GetStreamingContext("cViewDate")
            End With

            loRtnTemp = loCls.getLookUpTemporaryAssignmentPNL00520(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpTemporaryAssignmentPNL00520DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpTemporaryAssignmentPNL00520")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function getLookUpTemporaryPositionPNL00150() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpTemporaryPositionPNL00150
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTemporaryPositionPNL00150DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpTemporaryPositionPNL00150(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpTemporaryPositionPNL00150DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpTemporaryPositionPNL00150")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpLetterMasterPNL01600() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpLetterMasterPNL01600
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpLetterMasterPNL01600DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
            End With

            loRtnTemp = loCls.getLookUpLetterMasterPNL01600(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpLetterMasterPNL01600DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpLetterMasterPNL01600")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpLetterTemplatePNL01700() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpLetterTemplatePNL01700
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpLetterTemplatePNL01700DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLetterId = R_Utility.R_GetStreamingContext("cLetterId")
            End With

            loRtnTemp = loCls.getLookUpLetterTemplatePNL01700(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpLetterTemplatePNL01700DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpLetterTemplatePNL01700")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeTransactionAndReport() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployeeTransactionAndReport
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeTransactionAndReportDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cProgramCode = R_Utility.R_GetStreamingContext("cProgramCode")
                .lResign = R_Utility.R_GetStreamingContext("lResign")
                .lBlacklist = R_Utility.R_GetStreamingContext("lBlacklist")
                .cOfficeStatus = R_Utility.R_GetStreamingContext("cOfficeStatus")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")

                .cDeptList = R_Utility.R_GetStreamingContext("cDeptList")
                .cPositionList = R_Utility.R_GetStreamingContext("cPositionList")
                .cLocationList = R_Utility.R_GetStreamingContext("cLocationList")
                .cJobFuncList = R_Utility.R_GetStreamingContext("cJobFuncList")
                .cJobTitleList = R_Utility.R_GetStreamingContext("cJobTitleList")
                .cGradeList = R_Utility.R_GetStreamingContext("cGradeList")
                .cRankList = R_Utility.R_GetStreamingContext("cRankList")
                .cOrgLevelList = R_Utility.R_GetStreamingContext("cOrgLevelList")

                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            End With

            loRtnTemp = loCls.getLookUpEmployeeTransactionAndReport(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpEmployeeTransactionAndReportDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployeeTransactionAndReport")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpBPJSEmployeeAssignment() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpBPJSEmployeeAssignment
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpBPJSEmployeeAssignmentDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getLookUpBPJSEmployeeAssignment(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpBPJSEmployeeAssignmentDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpBPJSEmployeeAssignment")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "ATTENDANCE LOOKUP SECTION"

    Public Function getLookUpHolidaysParameter() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpHolidaysParameter
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpHolidaysParameterDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpHolidaysParameter(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpHolidaysParameterDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpHolidaysParameter")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpMachineSetting() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMachineSetting
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMachineSettingDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpMachineSetting(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMachineSettingDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMachineSetting")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpMachineTable() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMachineTable
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMachineTableDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cMachineType = R_Utility.R_GetStreamingContext("cMachineType")
            End With

            loRtnTemp = loCls.getLookUpMachineTable(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMachineTableDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMachineTable")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpReasonsParameter() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpReasonsParameter
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpReasonsParameterDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReasonCode = R_Utility.R_GetStreamingContext("cReasonCode")
                .cReasonType = R_Utility.R_GetStreamingContext("cReasonType")
                .lActive = R_Utility.R_GetStreamingContext("lActive")
            End With

            loRtnTemp = loCls.getLookUpReasonsParameter(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpReasonsParameterDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpReasonsParameter")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpHolidayEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpHolidayEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpHolidayEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cHolidayDate = R_Utility.R_GetStreamingContext("cHolidayDate")
            End With

            loRtnTemp = loCls.getLookUpHolidayEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpHolidayEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpHolidayEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCardMaster() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpCardMaster
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCardMasterDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpCardMaster(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCardMasterDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpCardMaster")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpOvertimeManagement() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpOvertimeManagement
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpOvertimeIndexCodeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpOvertimeManagement(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpOvertimeIndexCodeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpOvertimeManagement")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpOvertimeIndexDetail() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpOvertimeIndexDetail
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpOvertimeIndexDetailDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cIndexCode = R_Utility.R_GetStreamingContext("cIndexCode")
            End With

            loRtnTemp = loCls.getLookUpOvertimeIndexDetail(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpOvertimeIndexDetailDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpOvertimeIndexDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpOvertimeRounded() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpOvertimeRounded
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpOvertimeRoundedDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpOvertimeRounded(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpOvertimeRoundedDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpOvertimeRounded")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpOvertimeCalculationIndex() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpOvertimeCalculationIndex
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpOvertimeCalculationIndexDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpOvertimeCalculationIndex(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpOvertimeCalculationIndexDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpOvertimeCalculationIndex")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpShiftManagement() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpShiftManagement
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpShiftDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpShiftManagement(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpShiftDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpShiftManagement")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpShiftPattern() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpShiftPattern
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpShiftPatternDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpShiftPattern(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpShiftPatternDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpShiftPattern")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpPatternSequence() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpPatternSequence
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpPatternSequenceDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPatternCode = R_Utility.R_GetStreamingContext("cPatternCode")
            End With

            loRtnTemp = loCls.getLookUpPatternSequence(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpPatternSequenceDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpPatternSequence")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpShiftGroup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpShiftGroup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpShiftGroupDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpShiftGroup(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpShiftGroupDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpShiftGroup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpShiftGroupEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpShiftGroupEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpShiftGroupEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getLookUpShiftGroupEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpShiftGroupEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpShiftGroupEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSpecialLeave() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSpecialLeave
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSpecialLeaveDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpSpecialLeave(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpSpecialLeaveDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSpecialLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpAdditionalLeave() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpAdditionalLeave
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAdditionalLeaveDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpAdditionalLeave(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpAdditionalLeaveDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpAdditionalLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpAnnualLeave() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpAnnualLeave
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAnnualLeaveDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpAnnualLeave(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpAnnualLeaveDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpAnnualLeave")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpIncidentalLeave() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpIncidentalLeave
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpIncidentalLeaveDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpIncidentalLeave(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpIncidentalLeaveDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpIncidentalLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpAnualLeaveEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpAnualLeaveEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAnualLeaveEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getLookUpAnualLeaveEmployee(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpAnualLeaveEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpAnualLeaveEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSchedule() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSchedule
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpScheduleDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStrDate = R_Utility.R_GetStreamingContext("cStrDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEorw = R_Utility.R_GetStreamingContext("cEorw")
                .iSequential = R_Utility.R_GetStreamingContext("iSequential")
            End With

            loRtnTemp = loCls.getLookUpSchedule(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpScheduleDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSchedule")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpRequestOvertime() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpRequestOvertime
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpRequestOvertimeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cToDeptCode = R_Utility.R_GetStreamingContext("cToDeptCode")
            End With

            loRtnTemp = loCls.getLookUpRequestOvertime(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpRequestOvertimeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpRequestOvertime")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpDailyTimeHistory() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpDailyTimeHistory
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpDailyTimeHistoryDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cAttCode = R_Utility.R_GetStreamingContext("cAttCode")
                .cAttDate = R_Utility.R_GetStreamingContext("cAttDate")
                .cAttTime = R_Utility.R_GetStreamingContext("cAttTime")
            End With

            loRtnTemp = loCls.getLookUpDailyTimeHistory(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpDailyTimeHistoryDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpDailyTimeHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpRequestToDepartment() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpRequestToDepartment
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpRequestToDepartmentDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpRequestToDepartment(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpRequestToDepartmentDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpRequestToDepartment")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpAnalysisTable() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpAnalysisTable

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAnalysisTableDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cAttDescription = R_Utility.R_GetStreamingContext("cAttDescription")
            End With

            loRtnTemp = loCls.getLookUpAnalysisTable(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpAnalysisTableDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpAnalysisTable")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

#End Region

#Region "MEDICAL LOOKUP SECTION"

    Public Function getLookUpFamilyMember() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpFamilyMember
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpFamilyMemberDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getLookUpFamilyMember(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpFamilyMemberDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpFamilyMember")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpMedicalItem() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMedicalItem

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalItemDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cMedicalItemId = R_Utility.R_GetStreamingContext("cMedicalItemId")
            End With

            loRtnTemp = loCls.getLookUpMedicalItem(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMedicalItemDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMedicalItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMedicalSubItem() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMedicalSubItem


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalSubItemDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cMedicalItemId = R_Utility.R_GetStreamingContext("cMedicalItemId")
            End With

            loRtnTemp = loCls.getLookUpMedicalSubItem(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMedicalSubItemDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMedicalSubItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpBankAccount() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpBankAccount

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpBankAccountDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpBankAccount(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpBankAccountDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpBankAccount")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMedicalLimitItem() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMedicalLimitItem

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalItemDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnTemp = loCls.getLookUpMedicalLimitItem(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMedicalItemDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMedicalLimitItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpHealthPartner() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpHealthPartner

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpHealthPartnerDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpHealthPartner(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpHealthPartnerDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpHealthPartner")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMedicalRule() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMedicalRule
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalRuleDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpMedicalRule(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMedicalRuleDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMedicalRule")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedicalItem() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getMedicalItem
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getMedicalItem(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMedicalItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedicalPartner() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getMedicalPartner
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cMedicalItemId = R_Utility.R_GetStreamingContext("cMedicalItemId")
            End With

            loRtnTemp = loCls.getMedicalPartner(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMedicalPartner")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeFamily() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployeeFamily

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalEmployeeFamilyDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cForWhom = R_Utility.R_GetStreamingContext("cForWhom")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnTemp = loCls.getLookUpEmployeeFamily(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMedicalEmployeeFamilyDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployeeFamily")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpPartner() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpPartner


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalPartnerDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cProgramCode = R_Utility.R_GetStreamingContext("cProgramCode")
            End With

            loRtnTemp = loCls.getLookUpPartner(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMedicalPartnerDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpPartner")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function getLookUpPartnerContractTransaction() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpPartnerContractTransaction


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalPartnerContractTransactionDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnTemp = loCls.getLookUpPartnerContractTransaction(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMedicalPartnerContractTransactionDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpPartnerContractTransaction")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedicalIllness() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getMedicalIllness
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getMedicalIllness(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMedicalIllness")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMedicalEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMedicalEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getLookUpMedicalEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMedicalEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMedicalEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMedicalClaim() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMedicalClaim


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalClaimDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cClaimStatus = R_Utility.R_GetStreamingContext("cClaimStatus")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpMedicalClaim(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpMedicalClaimDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMedicalClaim")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpTransferBank() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpTransferBank
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTransferBankDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .lFirstTime = R_Utility.R_GetStreamingContext("lFirstTime")
            End With

            loRtnTemp = loCls.getLookUpTransferBank(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpTransferBankDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpTransferBank")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Employee_Medical_ClaimDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                .cProgramCode = R_Utility.R_GetStreamingContext("cProgramCode")
                .cFilterEmployee = R_Utility.R_GetStreamingContext("cFilterEmployee")
            End With

            loRtnTemp = loCls.getEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Employee_Medical_ClaimDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "LOAN LOOKUP SECTION"

    Public Function getLookUpLoanExpenseList() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpLoanExpenseList
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpLoanExpenseListDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpLoanExpenseList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpLoanExpenseListDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpLoanExpenseList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpLoanCategoryList() As Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpLoanCategoryList
        Dim loEx As New R_Exception
        Dim loRtn As Message = Nothing

        Try
            Dim loParam As New ParameterDTO
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpLoanCategoryList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpLoanCategoryDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpLoanCategoryList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLookUpNewLoanTransactionLNL00300() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpNewLoanTransactionLNL00300
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpNewLoanTransactionLNL00300DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnTemp = loCls.getLookUpNewLoanTransactionLNL00300(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpNewLoanTransactionLNL00300DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpNewLoanTransactionLNL00300")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeLNL01000() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployeeLNL01000

        Dim loEx As New R_Exception
        Dim loRtn As Message = Nothing

        Try
            Dim loParam As New ParameterDTO
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            loParam.cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpEmployeeLNL01000(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpEmployeeLNL01000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployeeLNL01000")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function getLookUpEmployeeLNL01500() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployeeLNL01500


        Dim loEx As New R_Exception
        Dim loRtn As Message = Nothing

        Try
            Dim loParam As New ParameterDTO
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLoanStatus = R_Utility.R_GetStreamingContext("cLoanStatus")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProgramCode = R_Utility.R_GetStreamingContext("cProgramCode")
                .cFilterEmployee = R_Utility.R_GetStreamingContext("cFilterEmployee")
            End With

            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpEmployeeLNL01500(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpEmployeeLNL01500DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployeeLNL01500")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLookUpEmployeeLNL02000() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployeeLNL02000
        Dim loEx As New R_Exception
        Dim loRtn As Message = Nothing

        Try
            Dim loParam As New ParameterDTO
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpEmployeeLNL02000(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpEmployeeLNL02000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployeeLNL02000")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
#End Region

#Region "PAYROLL LOOKUP SECTION"

    'PNL05100'
    Public Function getLookUpBpjsPerusahaan() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpBpjsPerusahaan
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpBPJSPerusahaanDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpBpjsPerusahaan(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpBPJSPerusahaanDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpBpjsPerusahaan")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCurrency() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpCurrency
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCurrencyDTO_N)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.getLookUpCurrency()

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCurrencyDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpCurrency")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSalaryGroup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryGroupDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cProcessStatus = R_Utility.R_GetStreamingContext("cProcessStatus")
            End With

            loRtnTemp = loCls.getLookUpSalaryGroup(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpSalaryGroupDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSalaryGroup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpTransferSalaryGroup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpTransferSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryGroupDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpTransferSalaryGroup(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpSalaryGroupDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpTransferSalaryGroup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSalaryGroupPeriod() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSalaryGroupPeriod
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryGroupPeriodDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cProcessStatus = R_Utility.R_GetStreamingContext("cProcessStatus")
                .cStatusEquation = R_Utility.R_GetStreamingContext("cStatusEquation")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cLookUpSenderFlag = R_Utility.R_GetStreamingContext("cLookUpSenderFlag")
                If .cLookUpSenderFlag = "PYL00270" Then
                    .cActiveIndex = R_Utility.R_GetStreamingContext("cActiveIndex")
                End If
            End With

            loRtnTemp = loCls.getLookUpSalaryGroupPeriod(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpSalaryGroupPeriodDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSalaryGroupPeriod")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeList() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeListDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cEmployeeTaxType = R_Utility.R_GetStreamingContext("cEmployeeTaxType")
                .cSalaryType = R_Utility.R_GetStreamingContext("cSalaryType")
                .lNewFunction = R_Utility.R_GetStreamingContext("lNewFunction")
                .cTaxOfficeId = R_Utility.R_GetStreamingContext("cTaxOfficeId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")

                If .lNewFunction = True And .cGroupCode <> "" Then
                    .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                    .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                    .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                    .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                End If
            End With

            loRtnTemp = loCls.getLookUpEmployeeList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpEmployeeListDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployeeList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpMembershipEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpMembershipEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeListDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeTaxType = R_Utility.R_GetStreamingContext("cEmployeeTaxType")
                .cSalaryType = R_Utility.R_GetStreamingContext("cSalaryType")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getLookUpMembershipEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpEmployeeListDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpMembershipEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

#Region "COMPONENT LIST LOOKUP"
    Public Function getLookUpComponentModel1() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpComponentModel1
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpComponentDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTaxMode = R_Utility.R_GetStreamingContext("cTaxMode")
                .cComponentType = R_Utility.R_GetStreamingContext("cComponentType")
                .lAfterTax = R_Utility.R_GetStreamingContext("lAfterTax")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
            End With

            loRtnTemp = loCls.getLookUpComponentModel1(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpComponentDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpComponentModel1")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpComponentModel2() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpComponentModel2
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpComponentDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTaxMode = R_Utility.R_GetStreamingContext("cTaxMode")
                .cComponentType = R_Utility.R_GetStreamingContext("cComponentType")
                .lAfterTax = R_Utility.R_GetStreamingContext("lAfterTax")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getLookUpComponentModel2(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpComponentDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpComponentModel2")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpComponentModel3() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpComponentModel3
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpComponentDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTaxMode = R_Utility.R_GetStreamingContext("cTaxMode")
                .cComponentType = R_Utility.R_GetStreamingContext("cComponentType")
                .lAfterTax = R_Utility.R_GetStreamingContext("lAfterTax")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cLookUpSenderFlag = R_Utility.R_GetStreamingContext("cLookUpSenderFlag")
            End With

            loRtnTemp = loCls.getLookUpComponentModel3(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpComponentDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpComponentModel3")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpComponentList() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpComponentList
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpComponentDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getLookUpComponentList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpComponentDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpComponentList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

    Public Function getLookUpSalaryPolicyUsage() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSalaryPolicyUsage
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryPolicyUsageDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cComponentCode = R_Utility.R_GetStreamingContext("cComponentCode")
            End With

            loRtnTemp = loCls.getLookUpSalaryPolicyUsage(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpSalaryPolicyUsageDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSalaryPolicyUsage")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#Region "SALARY PROCESS CODE LOOKUP"
    Public Function getLookUpSalaryProcessCodeModel1() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSalaryProcessCodeModel1
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryProcessCodeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLookUpSenderFlag = R_Utility.R_GetStreamingContext("cLookUpSenderFlag")
            End With

            loRtnTemp = loCls.getLookUpSalaryProcessCodeModel1(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpSalaryProcessCodeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSalaryProcessCodeModel1")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSalaryProcessCodeModel2() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSalaryProcessCodeModel2
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryProcessCodeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStringList = R_Utility.R_GetStreamingContext("cStringList")
                .cProcessType = R_Utility.R_GetStreamingContext("cProcessType")
                .cLookUpSenderFlag = R_Utility.R_GetStreamingContext("cLookUpSenderFlag")
            End With

            loRtnTemp = loCls.getLookUpSalaryProcessCodeModel2(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpSalaryProcessCodeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSalaryProcessCodeModel2")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSalaryProcessCodeModel3() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSalaryProcessCodeModel3
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryProcessCodeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpSalaryProcessCodeModel3(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpSalaryProcessCodeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSalaryProcessCodeModel3")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

    Public Function getLookUpJamsostek() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpJamsostek
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpJamsostekDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpJamsostek(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpJamsostekDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpJamsostek")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpTransferCode() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpTransferCode
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTransferCodeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpTransferCode(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpTransferCodeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpTransferCode")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpBank() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpBank
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpBankDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpBank(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpBankDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpBank")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpTaxOffice() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpTaxOffice
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTaxOfficeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpTaxOffice(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpTaxOfficeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpTaxOffice")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpUserDefineParams() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpUserDefineParams
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpUserDefineParamsDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpUserDefineParams(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpUserDefineParamsDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpUserDefineParams")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpFormula() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpFormula
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpFormulaDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpFormula(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpFormulaDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpFormula")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookupRapelCompList() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookupRapelCompList
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpRapelComponentListDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getLookupRapelCompList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpRapelComponentListDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookupRapelCompList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpBPJSBank() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpBPJSBank
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpBPJSBankDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpBPJSBank(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpBPJSBankDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpBPJSBank")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpAllEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpAllEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAllEmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpAllEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpAllEmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpAllEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpCompanyBankAccount() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpCompanyBankAccount

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCompanyBankAccountDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpCompanyBankAccount(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCompanyBankAccountDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpCompanyBankAccount")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpEmployeeBankAccount() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployeeBankAccount
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCompanyBankAccountDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getLookUpEmployeeBankAccount(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCompanyBankAccountDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployeeBankAccount")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSalaryGroupMulti() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSalaryGroupMulti

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryGroupMultiDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getLookUpSalaryGroupMulti(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpSalaryGroupMultiDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSalaryGroupMulti")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpPayrollUser() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpPayrollUser
        '

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpPayrollUserDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpPayrollUser(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpPayrollUserDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpPayrollUser")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpObjekPajak() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpObjekPajak
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpObjekPajakDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpObjekPajak(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpObjekPajakDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpObjekPajak")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#Region "PYL00800"

    Public Function getCmbCurr() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbCurr
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            loRtnTemp = loCls.getCmbCurr()

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCurr")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbGrade() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbGrade
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbGrade(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbGrade")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbLocation() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbLocation
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbLocation(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbLocation")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbPosition() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbPosition
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbPosition(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPosition")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbSalaryGroup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getCmbSalaryGroup(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbSalaryGroup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbCostCenter() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbCostCenter
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbCostCenter(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCostCenter")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbTaxOffice() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbTaxOffice
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbTaxOffice(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbTaxOffice")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbKodeObjekPajak() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbKodeObjekPajak
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbKodeObjekPajak(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbKodeObjekPajak")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#End Region

#Region "GENERAL SYSTEM LOOKUP SECTION"
    Public Function getLookUpDepartmentList() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpDepartmentList
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpDepartmentDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLookUpSenderFlag = R_Utility.R_GetStreamingContext("cLookUpSenderFlag")
                If .cLookUpSenderFlag = "GSL00150" Then
                    .cStaffFunction = R_Utility.R_GetStreamingContext("cStaffFunction")
                    .cParentPosition = R_Utility.R_GetStreamingContext("cParentPosition")
                End If
            End With

            loRtnTemp = loCls.getLookUpDepartmentList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpDepartmentDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpDepartmentList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLookUpCompany() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.GetLookUpCompany
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCompanyDTO_N)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.GetLookUpCompany()

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCompanyDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLookUpCompany")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

#Region "QA LOOKUP SECTION"

    'COMBO BOX

    Public Function getCmbDepartment() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbDepartment
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbDepartment(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbDepartment")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbDocumentType() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getCmbDocumentType
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbDocumentType(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbDocumentType")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    '===========================================================================================================

    Public Function getLookUpParentDocument() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpParentDocument

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL00100DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDocType = R_Utility.R_GetStreamingContext("cDocType")
            End With

            loRtnTemp = loCls.getLookUpParentDocument(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of QAL00100DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpParentDocument")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpDocument() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpDocument
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL00300DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDocType = R_Utility.R_GetStreamingContext("cDocType")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cQaDeptCode = R_Utility.R_GetStreamingContext("cQaDeptCode")
            End With

            loRtnTemp = loCls.getLookUpDocument(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of QAL00300DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpDocument")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpFillingMethod() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpFillingMethod
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL00400DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpFillingMethod(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of QAL00400DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpFillingMethod")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSocializationDetail() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSocializationDetail
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL01000DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getLookUpSocializationDetail(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of QAL01000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSocializationDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSocializationHeader() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpSocializationHeader
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL01000DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cQaDeptCode = R_Utility.R_GetStreamingContext("cQaDeptCode")
                .cProgramId = R_Utility.R_GetStreamingContext("cProgramId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getLookUpSocializationHeader(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of QAL01000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpSocializationHeader")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeQA() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEmployeeQA
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL01100DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            End With

            loRtnTemp = loCls.getLookUpEmployeeQA(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of QAL01100DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEmployeeQA")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpClause() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpClause
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL00500DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cIsoType = R_Utility.R_GetStreamingContext("cIsoType")
                .cIsoVersion = R_Utility.R_GetStreamingContext("cIsoVersion")
            End With

            loRtnTemp = loCls.getLookUpClause(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of QAL00500DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpClause")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "JOB COMPETENCIES LOOKUP SECTION"

    Public Function getLookUpPositionCompetencies() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpPositionCompetencies
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtnTemp As List(Of JCL00100DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getLookUpPositionCompetencies(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of JCL00100DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpPositionCompetencies")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpAppraiserEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpAppraiserEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtnTemp As List(Of JCL01000DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getLookUpAppraiserEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of JCL01000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpAppraiserEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEvaluationEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpEvaluationEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtnTemp As List(Of JCL03000DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cEvaluationType = R_Utility.R_GetStreamingContext("cEvaluationType")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getLookUpEvaluationEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of JCL03000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpEvaluationEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpJcEmployeePosition() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpJcEmployeePosition
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtnTemp As List(Of JCL02000DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getLookUpJcEmployeePosition(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of JCL02000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpJcEmployeePosition")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCategoryCompetency() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpCategoryCompetency
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtnTemp As List(Of JCL04000DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpCategoryCompetency(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of JCL04000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpCategoryCompetency")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCompetency() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getLookUpCompetency
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtnTemp As List(Of JCL04000DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpCompetency(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of JCL04000DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpCompetency")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#End Region

#Region "STORED PROCEDURE"
    Public Function RSP_Get_Payroll_Dimension() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_Get_Payroll_Dimension
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Get_Payroll_DimensionDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDimension1 = R_Utility.R_GetStreamingContext("cDimension1")
                .cDimension2 = R_Utility.R_GetStreamingContext("cDimension2")
                .cDimension3 = R_Utility.R_GetStreamingContext("cDimension3")
                .cDimension4 = R_Utility.R_GetStreamingContext("cDimension4")
                .cDimension5 = R_Utility.R_GetStreamingContext("cDimension5")
                .cDimension6 = R_Utility.R_GetStreamingContext("cDimension6")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.RSP_Get_Payroll_Dimension(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Get_Payroll_DimensionDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_Get_Payroll_Dimension")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_GET_USER_RIGHTS() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_GET_USER_RIGHTS
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Get_User_RightsDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.RSP_GET_USER_RIGHTS(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Get_User_RightsDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_GET_USER_RIGHTS")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_Get_Class_Info() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_Get_Class_Info
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Class_InfoDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cTableName = R_Utility.R_GetStreamingContext("cTableName")
                .cClassApplication = R_Utility.R_GetStreamingContext("cClassApplication")
                .cClassId = R_Utility.R_GetStreamingContext("cClassId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cWhere = R_Utility.R_GetStreamingContext("cWhere")
                .cClassRecId = R_Utility.R_GetStreamingContext("cClassRecId")
            End With

            loRtnTemp = loCls.RSP_Get_Class_Info(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Class_InfoDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_Get_Class_Info")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_EMPSAL_COMPONENTS() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_EMPSAL_COMPONENTS
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Empsal_ComponentsDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cStartPeriodIndex = R_Utility.R_GetStreamingContext("cStartPeriodIndex")
                .cEndPeriodIndex = R_Utility.R_GetStreamingContext("cEndPeriodIndex")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cShowResignMode = R_Utility.R_GetStreamingContext("cShowResignMode")
                .lGetSocialSecurity = R_Utility.R_GetStreamingContext("lGetSocialSecurity")
            End With

            loRtnTemp = loCls.RSP_EMPSAL_COMPONENTS(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Empsal_ComponentsDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_EMPSAL_COMPONENTS")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_PAYROLL_LOOKUP_EMPLOYEE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_PAYROLL_LOOKUP_EMPLOYEE
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Payroll_Lookup_EmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCodeList = R_Utility.R_GetStreamingContext("cGroupCodeList")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cShowResignMode = R_Utility.R_GetStreamingContext("cShowResignMode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cReligionList = R_Utility.R_GetStreamingContext("cReligionList")
                .cGenderList = R_Utility.R_GetStreamingContext("cGenderList")
                .cTaxOfficeList = R_Utility.R_GetStreamingContext("cTaxOfficeList")
                .cCurrencyList = R_Utility.R_GetStreamingContext("cCurrencyList")
                .cDeptList = R_Utility.R_GetStreamingContext("cDeptList")
                .cGradeList = R_Utility.R_GetStreamingContext("cGradeList")
                .cClassList = R_Utility.R_GetStreamingContext("cClassList")
                .cLocationList = R_Utility.R_GetStreamingContext("cLocationList")
                .cJobFunctionList = R_Utility.R_GetStreamingContext("cJobFunctionList")
                .cJobTitleList = R_Utility.R_GetStreamingContext("cJobTitleList")
                .cRankList = R_Utility.R_GetStreamingContext("cRankList")
                .cPositionList = R_Utility.R_GetStreamingContext("cPositionList")
                .cCostCenterList = R_Utility.R_GetStreamingContext("cCostCenterList")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lYearly = R_Utility.R_GetStreamingContext("lYearly")
                .CPROGRAM_ID = R_Utility.R_GetStreamingContext("CPROGRAM_ID")
                .CSTART_INDEX = R_Utility.R_GetStreamingContext("CSTART_INDEX")
                .CEND_INDEX = R_Utility.R_GetStreamingContext("CEND_INDEX")
            End With

            loRtnTemp = loCls.RSP_PAYROLL_LOOKUP_EMPLOYEE(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Payroll_Lookup_EmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_PAYROLL_LOOKUP_EMPLOYEE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_PERSONEL_LOOKUP_EMPLOYEE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_PERSONEL_LOOKUP_EMPLOYEE
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Personel_Lookup_EmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLookpDate = R_Utility.R_GetStreamingContext("cLookpDate")
                .cShowResignMode = R_Utility.R_GetStreamingContext("cShowResignMode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cReligionList = R_Utility.R_GetStreamingContext("cReligionList")
                .cGenderList = R_Utility.R_GetStreamingContext("cGenderList")
                .cDeptList = R_Utility.R_GetStreamingContext("cDeptList")
                .cGradeList = R_Utility.R_GetStreamingContext("cGradeList")
                .cClassList = R_Utility.R_GetStreamingContext("cClassList")
                .cLocationList = R_Utility.R_GetStreamingContext("cLocationList")
                .cJobFunctionList = R_Utility.R_GetStreamingContext("cJobFunctionList")
                .cJobTitleList = R_Utility.R_GetStreamingContext("cJobTitleList")
                .cRankList = R_Utility.R_GetStreamingContext("cRankList")
                .cPositionList = R_Utility.R_GetStreamingContext("cPositionList")
                .cOfficeStatus = R_Utility.R_GetStreamingContext("cOfficeStatus")
            End With

            loRtnTemp = loCls.RSP_PERSONEL_LOOKUP_EMPLOYEE(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Personel_Lookup_EmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_PERSONEL_LOOKUP_EMPLOYEE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_Build_Loan_Policy_Matrix() As Boolean Implements ISIAPP_PUB_DTONewStreamingService.RSP_Build_Loan_Policy_Matrix
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Boolean
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
                .iDimension = R_Utility.R_GetStreamingContext("iDimension")
                .cSelectDimension = R_Utility.R_GetStreamingContext("cSelectDimension")
            End With

            loRtn = loCls.RSP_Build_Loan_Policy_Matrix(loParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_Get_Loan_Policy_Dimension() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_Get_Loan_Policy_Dimension
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Get_Loan_Policy_DimensionDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
                .iDimension = R_Utility.R_GetStreamingContext("iDimension")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cMode = R_Utility.R_GetStreamingContext("cMode")
            End With

            loRtnTemp = loCls.RSP_Get_Loan_Policy_Dimension(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Get_Loan_Policy_DimensionDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_Get_Loan_Policy_Dimension")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_Get_Loan_Policy_Matrix() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_Get_Loan_Policy_Matrix
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Get_Loan_Policy_MatrixDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
            End With

            loRtnTemp = loCls.RSP_Get_Loan_Policy_Matrix(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Get_Loan_Policy_MatrixDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_Get_Loan_Policy_Matrix")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_View_Feasibility() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_View_Feasibility
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_View_FeasibilityDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
                .nInstallmentLimit = R_Utility.R_GetStreamingContext("nInstallmentLimit")
                .nSalary = R_Utility.R_GetStreamingContext("nSalary")
                .nPrincipal = R_Utility.R_GetStreamingContext("nPrincipal")
                .iMaxLine = R_Utility.R_GetStreamingContext("iMaxLine")
            End With

            loRtnTemp = loCls.RSP_View_Feasibility(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_View_FeasibilityDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_View_Feasibility")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_FIND_NON_EMP_TRANSACTION() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_FIND_NON_EMP_TRANSACTION


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Find_Non_Emp_TransactionDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cKodeObjekPajakList = R_Utility.R_GetStreamingContext("cKodeObjekPajakList")
                .cKppList = R_Utility.R_GetStreamingContext("cKppList")
                .cDepartmentList = R_Utility.R_GetStreamingContext("cDepartmentList")
                .cTaxStatusList = R_Utility.R_GetStreamingContext("cTaxStatusList")
                .cGenderList = R_Utility.R_GetStreamingContext("cGenderList")
                .cTransactionDate = R_Utility.R_GetStreamingContext("cTransactionDate")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            End With

            loRtnTemp = loCls.RSP_FIND_NON_EMP_TRANSACTION(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Find_Non_Emp_TransactionDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_FIND_NON_EMP_TRANSACTION")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_FIND_NON_EMPLOYEE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_FIND_NON_EMPLOYEE

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Find_Non_EmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cKodeObjekPajakList = R_Utility.R_GetStreamingContext("cKodeObjekPajakList")
                .cKppList = R_Utility.R_GetStreamingContext("cKppList")
                .cDepartmentList = R_Utility.R_GetStreamingContext("cDepartmentList")
                .cTaxStatusList = R_Utility.R_GetStreamingContext("cTaxStatusList")
                .cGenderList = R_Utility.R_GetStreamingContext("cGenderList")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .lActive = R_Utility.R_GetStreamingContext("lActive")
            End With

            loRtnTemp = loCls.RSP_FIND_NON_EMPLOYEE(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Find_Non_EmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_FIND_NON_EMPLOYEE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RSP_MDB00100() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_MDB00100

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_MDB00100DTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnTemp = loCls.RSP_MDB00100(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_MDB00100DTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_MDB00100")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_MEDICAL_LIMIT() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_MEDICAL_LIMIT

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Medical_LimitDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cProcessDate = R_Utility.R_GetStreamingContext("cProcessDate")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cMedicalGroup = R_Utility.R_GetStreamingContext("cMedicalGroup")

            End With

            loRtnTemp = loCls.RSP_MEDICAL_LIMIT(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Medical_LimitDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_MEDICAL_LIMIT")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RSP_GET_SELECTION_EMPLOYEE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_GET_SELECTION_EMPLOYEE
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_GET_SELECTION_EMPLOYEEDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cDepartmentList = R_Utility.R_GetStreamingContext("cDepartmentList")
                .cPositionList = R_Utility.R_GetStreamingContext("cPositionList")
                .cLocationList = R_Utility.R_GetStreamingContext("cLocationList")
                .cJobFunctionList = R_Utility.R_GetStreamingContext("cJobFunctionList")
                .cJobTitleList = R_Utility.R_GetStreamingContext("cJobTitleList")
                .cLevelList = R_Utility.R_GetStreamingContext("cLevelList")
                .cClassList = R_Utility.R_GetStreamingContext("cClassList")
                .cRankList = R_Utility.R_GetStreamingContext("cRankList")
                .cEmployeeTypeList = R_Utility.R_GetStreamingContext("cEmployeeTypeList")
                .cSalaryTypeList = R_Utility.R_GetStreamingContext("cSalaryTypeList")
                .cEmployeeTaxTypeList = R_Utility.R_GetStreamingContext("cEmployeeTaxTypeList")
                .cGradeList = R_Utility.R_GetStreamingContext("cGradeList")
                .cSubGradeList = R_Utility.R_GetStreamingContext("cSubGradeList")

            End With

            loRtnTemp = loCls.RSP_GET_SELECTION_EMPLOYEE(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_GET_SELECTION_EMPLOYEEDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_GET_SELECTION_EMPLOYEE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

#End Region

#Region "FUNCTION"

    Public Function RFT_FIND_SIMILAR_EMPLOYEES() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_FIND_SIMILAR_EMPLOYEES
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of SIAPP_PUBCommon.RFT_Find_Similar_EmployeesDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFirstName = R_Utility.R_GetStreamingContext("cFirstName")
                .cMiddleName = R_Utility.R_GetStreamingContext("cMiddleName")
                .cLastName = R_Utility.R_GetStreamingContext("cLastName")
                .cBirthDate = R_Utility.R_GetStreamingContext("cBirthDate")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.RFT_FIND_SIMILAR_EMPLOYEES(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Find_Similar_EmployeesDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_FIND_SIMILAR_EMPLOYEES")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_VALIDATE_IDENTITY() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_VALIDATE_IDENTITY
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Find_Similar_EmployeesDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cIdentitySubject = R_Utility.R_GetStreamingContext("cIdentitySubject")
                .cIdentityNo = R_Utility.R_GetStreamingContext("cIdentityNo")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.RFT_VALIDATE_IDENTITY(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Find_Similar_EmployeesDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_VALIDATE_IDENTITY")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_USER_RIGHTS() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_USER_RIGHTS
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Get_User_RightsDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cModId = R_Utility.R_GetStreamingContext("cModId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lCheckInterfaceModul = R_Utility.R_GetStreamingContext("lCheckInterfaceModul")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.RFT_GET_USER_RIGHTS(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Get_User_RightsDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_USER_RIGHTS")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_PERSONAL_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_PERSONAL_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Personal_InfoDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.RFT_GET_PERSONAL_INFO(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Personal_InfoDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_PERSONAL_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_DEPARTMENT_USER() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_DEPARTMENT_USER
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Department_UserDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .lActive = R_Utility.R_GetStreamingContext("lActive")
                .lViewMode = R_Utility.R_GetStreamingContext("lViewMode")
            End With

            loRtnTemp = loCls.RFT_GET_DEPARTMENT_USER(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Department_UserDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_DEPARTMENT_USER")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LEAVE_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_LEAVE_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Leave_InfoDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLeaveType = R_Utility.R_GetStreamingContext("cLeaveType")
                .cLeaveCode = R_Utility.R_GetStreamingContext("cLeaveCode")
                .lActive = R_Utility.R_GetStreamingContext("lActive")
            End With

            loRtnTemp = loCls.RFT_GET_LEAVE_INFO(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Leave_InfoDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_LEAVE_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_REASONS_PARAMETER() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_REASONS_PARAMETER
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Reasons_ParameterDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReasonCode = R_Utility.R_GetStreamingContext("cReasonCode")
                .lActive = R_Utility.R_GetStreamingContext("lActive")
            End With

            loRtnTemp = loCls.RFT_GET_REASONS_PARAMETER(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Reasons_ParameterDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_REASONS_PARAMETER")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_SCHEDULE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_SCHEDULE
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_ScheduleDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStrDate = R_Utility.R_GetStreamingContext("cStrDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEorw = R_Utility.R_GetStreamingContext("cEorw")
                .iSequential = R_Utility.R_GetStreamingContext("iSequential")
            End With

            loRtnTemp = loCls.RFT_GET_SCHEDULE(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_ScheduleDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_SCHEDULE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_SHIFT_GROUP() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_SHIFT_GROUP
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Shift_GroupDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .lActive = R_Utility.R_GetStreamingContext("lActive")
            End With

            loRtnTemp = loCls.RFT_GET_SHIFT_GROUP(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Shift_GroupDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_SHIFT_GROUP")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_SHIFT_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_SHIFT_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Shift_InfoDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cShiftCode = R_Utility.R_GetStreamingContext("cShiftCode")
                .lActive = R_Utility.R_GetStreamingContext("lActive")
            End With

            loRtnTemp = loCls.RFT_GET_SHIFT_INFO(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Shift_InfoDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_SHIFT_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_GSB_CODE_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_GSB_CODE_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Class_InfoDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cClassApplication = R_Utility.R_GetStreamingContext("cClassApplication")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cClassId = R_Utility.R_GetStreamingContext("cClassId")
                .cClassRecId = R_Utility.R_GetStreamingContext("cClassRecId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.RFT_GET_GSB_CODE_INFO(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Class_InfoDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_GSB_CODE_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_ACTUAL() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_ACTUAL
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_ActualDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cShiftDate = R_Utility.R_GetStreamingContext("cShiftDate")
                .iSequential = R_Utility.R_GetStreamingContext("iSequential")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .iProcessMode = R_Utility.R_GetStreamingContext("iProcessMode")
                .cMoreThan = R_Utility.R_GetStreamingContext("cMoreThan")
                .cLessThan = R_Utility.R_GetStreamingContext("cLessThan")
                .iShiftType = R_Utility.R_GetStreamingContext("iShiftType")
                .cStrOrEnd = R_Utility.R_GetStreamingContext("cStrOrEnd")
                .cShiftStrDt = R_Utility.R_GetStreamingContext("cShiftStrDt")
                .cShiftEndDt = R_Utility.R_GetStreamingContext("cShiftEndDt")
                .cEarlyInShiftStrTm = R_Utility.R_GetStreamingContext("cEarlyInShiftStrTm")
                .iEarlyInHours = R_Utility.R_GetStreamingContext("iEarlyInHours")
                .cLateOutShiftEndTm = R_Utility.R_GetStreamingContext("cLateOutShiftEndTm")
                .iLateOutHours = R_Utility.R_GetStreamingContext("iLateOutHours")
            End With

            loRtnTemp = loCls.RFT_GET_ACTUAL(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_ActualDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_ACTUAL")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_CLASS_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_CLASS_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cTableName = R_Utility.R_GetStreamingContext("cTableName")
                .cClassApplication = R_Utility.R_GetStreamingContext("cClassApplication")
                .cClassId = R_Utility.R_GetStreamingContext("cClassId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cClassRecId = R_Utility.R_GetStreamingContext("cClassRecId")
            End With

            loRtnTemp = loCls.RFT_GET_CLASS_INFO(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of LookUpCmbDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_CLASS_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_CURRENCY_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_CURRENCY_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Currency_InfoDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCurrencyCode = R_Utility.R_GetStreamingContext("cCurrencyCode")
                .cCreateDate = R_Utility.R_GetStreamingContext("cCreateDate")
            End With

            loRtnTemp = loCls.RFT_GET_CURRENCY_INFO(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Currency_InfoDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_CURRENCY_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_TIME_HISTORY() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_TIME_HISTORY
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Time_HistoryDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cAttCode = R_Utility.R_GetStreamingContext("cAttCode")
                .cAttDate = R_Utility.R_GetStreamingContext("cAttDate")
                .cAttTime = R_Utility.R_GetStreamingContext("cAttTime")
            End With

            loRtnTemp = loCls.RFT_GET_TIME_HISTORY(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Time_HistoryDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_TIME_HISTORY")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LOAN_TYPE_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_LOAN_TYPE_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Loan_TypeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
                .lMedical = R_Utility.R_GetStreamingContext("lMedical")
            End With

            loRtnTemp = loCls.RFT_GET_LOAN_TYPE_INFO(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Loan_TypeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_LOAN_TYPE_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LOAN_TRANSACTION_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_LOAN_TRANSACTION_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_Get_Loan_Transaction_InfoDTO_N)

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            End With

            loRtnTemp = loCls.RFT_GET_LOAN_TRANSACTION_INFO(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Loan_Transaction_InfoDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_LOAN_TRANSACTION_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LOAN_SYSTEM_PARAM() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_LOAN_SYSTEM_PARAM
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_Get_Loan_System_ParamDTO_N)

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.RFT_GET_LOAN_SYSTEM_PARAM(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Loan_System_ParamDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_LOAN_SYSTEM_PARAM")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LOAN_INSTALLMENT_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_LOAN_INSTALLMENT_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_Get_Loan_Installment_InfoDTO_N)

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
            End With

            loRtnTemp = loCls.RFT_GET_LOAN_INSTALLMENT_INFO(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Loan_Installment_InfoDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_LOAN_INSTALLMENT_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LEAVE_BALANCE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_LEAVE_BALANCE
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_Get_Leave_BalanceDTO_N)

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLeaveType = R_Utility.R_GetStreamingContext("cLeaveType")
                .cLeaveCode = R_Utility.R_GetStreamingContext("cLeaveCode")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cMonth = R_Utility.R_GetStreamingContext("cMonth")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEntitlementDate = R_Utility.R_GetStreamingContext("cEntitlementDate")
            End With

            loRtnTemp = loCls.RFT_GET_LEAVE_BALANCE(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Leave_BalanceDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_LEAVE_BALANCE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_SPLITSTRING() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_SPLITSTRING
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_SplitstringDTO_N)

        Try
            With loParam
                .cString = R_Utility.R_GetStreamingContext("cString")
                .cSeparator = R_Utility.R_GetStreamingContext("cSeparator")
            End With

            loRtnTemp = loCls.RFT_SPLITSTRING(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_SplitstringDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_SPLITSTRING")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_ANALYSIS_BALANCE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_ANALYSIS_BALANCE

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_GET_ANALYSIS_BALANCEDTO_N)

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cAttDescription = R_Utility.R_GetStreamingContext("cAttDescription")
            End With

            loRtnTemp = loCls.RFT_GET_ANALYSIS_BALANCE(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_GET_ANALYSIS_BALANCEDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_ANALYSIS_BALANCE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RFT_GET_ORG_STRUCTURE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.RFT_GET_ORG_STRUCTURE

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_Get_Org_StructureDTO_N)

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            End With

            loRtnTemp = loCls.RFT_GET_ORG_STRUCTURE(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RFT_Get_Org_StructureDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_ORG_STRUCTURE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

#End Region

#Region "ATP00100"
    Public Function getDataATP00100() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.getDataATP00100
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Personel_Lookup_EmployeeDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cAssignmentType = R_Utility.R_GetStreamingContext("cAssignmentType")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cDeptList = R_Utility.R_GetStreamingContext("cDeptList")
                .cPositionList = R_Utility.R_GetStreamingContext("cPositionList")
                .cLocationList = R_Utility.R_GetStreamingContext("cLocationList")
                .cReligionList = R_Utility.R_GetStreamingContext("cReligionList")
                .cGroupList = R_Utility.R_GetStreamingContext("cGroupList")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow")
                .lIncludeEmployee = R_Utility.R_GetStreamingContext("lIncludeEmployee") 'pinjam DTO untuk LINCLUDE_LEAVE_ONLY
            End With

            loRtnTemp = loCls.getDataATP00100(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of RSP_Personel_Lookup_EmployeeDTO_N)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataATP00100")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

    Public Function ClassAndTranslate() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTONewStreamingService.ClassAndTranslate


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO_N)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cClassApplication = R_Utility.R_GetStreamingContext("cClassApplication")
                .cClassId = R_Utility.R_GetStreamingContext("cClassId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.ClassAndTranslate(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO_N).WriteToMessage(loRtnTemp.AsEnumerable, "ClassAndTranslate")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

#Region "UPLOAD ATTACHMENT"

    Public Function RSP_GET_TRX_ATTACHMENT_LIST() As Message Implements ISIAPP_PUB_DTONewStreamingService.RSP_GET_TRX_ATTACHMENT_LIST
        Dim loEx As New R_Exception
        Dim loRtn As Message
        Dim loTemp As New List(Of LookUpAttachmentDTO)
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loParam As New ParameterDTO
        Dim loList As List(Of Byte())

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loTemp = loCls.RSP_GET_TRX_ATTACHMENT_LIST(loParam)
            loList = R_Utility.R_GetChunkData(Of LookUpAttachmentDTO)(loTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_GET_TRX_ATTACHMENT_LIST")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

#End Region

    '#Region "DUMMY"
    '    Public Sub Dummy(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.SIAPP_PUB_DTOs), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.ATP00100GridDTO)) Implements ISIAPP_PUB_DTONewStreamingService.Dummy

    '    End Sub

    '    Public Sub DummyAttendance(poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpMachineTableDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpReasonsParameterDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyAttendance

    '    End Sub

    '    Public Sub DummyAttendance1(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpHolidaysParameterDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpHolidayEmployeeDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpCardMasterDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyAttendance1

    '    End Sub

    '    Public Sub DummyAttendance2(poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpOvertimeRoundedDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpOvertimeCalculationIndexDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpShiftDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyAttendance2

    '    End Sub

    '    Public Sub DummyAttendance3(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpShiftPatternDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpShiftGroupDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpShiftGroupEmployeeDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyAttendance3

    '    End Sub

    '    Public Sub DummyAttendance4(poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpAnualLeaveEmployeeDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpRequestOvertimeDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyAttendance4

    '    End Sub

    '    Public Sub DummyAttendance5(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpDailyTimeHistoryDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyAttendance5

    '    End Sub

    '    Public Sub DummyAttendance6(poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpIncidentalLeaveDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpAdditionalLeaveDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyAttendance6

    '    End Sub

    '    Public Sub DummyAttendance7(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpAnalysisTableDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyAttendance7

    '    End Sub

    '    Public Sub DummyFunction(poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Department_UserDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Leave_InfoDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Reasons_ParameterDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyFunction

    '    End Sub

    '    Public Sub DummyFunction1(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_ScheduleDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Shift_GroupDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Shift_InfoDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Class_InfoDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyFunction1

    '    End Sub

    '    Public Sub DummyFunction2(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_ActualDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Time_HistoryDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Currency_InfoDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyFunction2

    '    End Sub

    '    Public Sub DummyFunction3(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Loan_System_ParamDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Loan_Installment_InfoDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Leave_BalanceDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_SplitstringDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyFunction3

    '    End Sub

    '    Public Sub DummyFunction4(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_GET_ANALYSIS_BALANCEDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Get_Org_StructureDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyFunction4

    '    End Sub

    '    Public Sub DummyFunction5(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RFT_Find_Similar_EmployeesDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyFunction5

    '    End Sub

    '    Public Sub DummyJobCompetencies(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.JCL00100DTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyJobCompetencies

    '    End Sub

    '    Public Sub DummyLoan(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpLoanCategoryDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpEmployeeLNL01000DTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyLoan

    '    End Sub

    '    Public Sub DummyMedical(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpFamilyMemberDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpMedicalSubItemDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpBankAccountDTO), poPar4 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpHealthPartnerDTO), poPar5 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpMedicalRuleDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyMedical

    '    End Sub

    '    Public Sub DummyPayroll1(poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpEmployeeListDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_GET_SELECTION_EMPLOYEEDTO), poPar4 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.PNP00100GridDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyPayroll1

    '    End Sub

    '    Public Sub DummyPayroll2(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpSalaryPolicyUsageDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyPayroll2

    '    End Sub

    '    Public Sub DummyPayroll3(poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpUserDefineParamsDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpRapelComponentListDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyPayroll3

    '    End Sub

    '    Public Sub DummyPayroll4(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpSalaryGroupMultiDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpTrainingDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyPayroll4

    '    End Sub

    '    Public Sub DummyPersonal(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpReferenceDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.LookUpEmployeePNL11000DTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummyPersonal

    '    End Sub

    '    Public Sub DummySP(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_Get_Payroll_DimensionDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_Get_User_RightsDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.SP_Get_Reference_NumberDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_Check_MTD_ProcessDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummySP

    '    End Sub

    '    Public Sub DummySP1(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.SP_Get_PeriodDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummySP1

    '    End Sub

    '    Public Sub DummySP2(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_Empsal_ComponentsDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_Payroll_Lookup_EmployeeDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_Get_Loan_Policy_MatrixDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_Get_Loan_Policy_DimensionDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummySP2

    '    End Sub

    '    Public Sub DummySP3(poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_View_FeasibilityDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummySP3

    '    End Sub

    '    Public Sub DummySP4(poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_MDB00100DTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO_NEW.RSP_Medical_LimitDTO)) Implements ISIAPP_PUB_DTONewStreamingService.DummySP4

    '    End Sub

    '#End Region


End Class

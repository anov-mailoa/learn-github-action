Imports R_Common
Imports SIAPP_PUB_DTO
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "SIAPP_PUB_DTOStreamingService" in code, svc and config file together.
Public Class SIAPP_PUB_DTOStreamingService
    Implements ISIAPP_PUB_DTOStreamingService

#Region "LOOK UP"

#Region "PERSONAL LOOKUP SECTION"

    Public Function getCmbPattern() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getCmbPattern
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbPattern(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getCmbPattern")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCountry() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpCountry
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCountryDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpCountry(loParam)

            loRtn = R_StreamUtility(Of LookUpCountryDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpCountry")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpProvince() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpProvince
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpProvinceDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cCountryCode = R_Utility.R_GetStreamingContext("cCountryCode")
            End With

            loRtnTemp = loCls.getLookUpProvince(loParam)

            loRtn = R_StreamUtility(Of LookUpProvinceDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpProvince")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCity() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpCity
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCityDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cCountryCode = R_Utility.R_GetStreamingContext("cCountryCode")
                .cProvinceCode = R_Utility.R_GetStreamingContext("cProvinceCode")
            End With

            loRtnTemp = loCls.getLookUpCity(loParam)

            loRtn = R_StreamUtility(Of LookUpCityDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpCity")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpPosition() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpPosition
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpPositionDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpPosition(loParam)

            loRtn = R_StreamUtility(Of LookUpPositionDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpPosition")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpLocation() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpLocation
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpLocationDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpLocation(loParam)

            loRtn = R_StreamUtility(Of LookUpLocationDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpLocation")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpGrade() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpGrade
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpGradeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpGrade(loParam)

            loRtn = R_StreamUtility(Of LookUpGradeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpGrade")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCode() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpCode
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCodeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cClassApplication = R_Utility.R_GetStreamingContext("cClassApplication")
                .cClassId = R_Utility.R_GetStreamingContext("cClassId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpCode(loParam)

            loRtn = R_StreamUtility(Of LookUpCodeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpCode")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeDTO)
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

            loRtn = R_StreamUtility(Of LookUpEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpActiveEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpActiveEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpActiveEmployeeDTO)
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

            loRtn = R_StreamUtility(Of LookUpActiveEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpActiveEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeWithFacility() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployeeWithFacility
        '
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeWithFacilityDTO)
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

            loRtn = R_StreamUtility(Of LookUpEmployeeWithFacilityDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpEmployeeWithFacility")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpActiveContractEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpActiveContractEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpActiveContractEmployeeDTO)
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

            loRtn = R_StreamUtility(Of LookUpActiveContractEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpActiveContractEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpProbationEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpProbationEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpProbationEmployeeDTO)
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

            loRtn = R_StreamUtility(Of LookUpProbationEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpProbationEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpResignedContractEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpResignedContractEmployee


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpResignedContractEmployeeDTO)
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

            loRtn = R_StreamUtility(Of LookUpResignedContractEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpResignedContractEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function getLookUpReactivationEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpReactivationEmployee



        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpReactivationEmployeeDTO)
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

            loRtn = R_StreamUtility(Of LookUpReactivationEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpReactivationEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn



    End Function

    Public Function getFacilityDeviceLookup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getFacilityDeviceLookup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpFacilityDeviceDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFacilityOpdevice = R_Utility.R_GetStreamingContext("cFacilityOpdevice")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            End With

            loRtnTemp = loCls.getFacilityDeviceLookup(loParam)

            loRtn = R_StreamUtility(Of LookUpFacilityDeviceDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getFacilityDeviceLookup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployeeResignLookup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getEmployeeResignLookup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getEmployeeResignLookup(loParam)

            loRtn = R_StreamUtility(Of LookUpEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getEmployeeResignLookup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCategory() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpCategory
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCodeDTO)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.getLookUpCategory()

            loRtn = R_StreamUtility(Of LookUpCodeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpCategory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCriteria() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpCriteria
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCriteriaDTO)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.getLookUpCriteria()

            loRtn = R_StreamUtility(Of LookUpCriteriaDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpCriteria")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpMasterFacility() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMasterFacility
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpFacilityDeviceDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFacilityOpdevice = R_Utility.R_GetStreamingContext("cFacilityOpdevice")
            End With

            loRtnTemp = loCls.getLookUpMasterFacility(loParam)

            loRtn = R_StreamUtility(Of LookUpFacilityDeviceDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMasterFacility")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpFasilitasKesehatan() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpFasilitasKesehatan
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpFasilitasKesehatanDTO)
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

            loRtn = R_StreamUtility(Of LookUpFasilitasKesehatanDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpFasilitasKesehatan")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpReligion() As Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpReligion
        Dim loEx As New R_Exception
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpReligion(loParam)
            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpReligion")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLookUpGeography() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpGeography
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpGeographyDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .nTingkatWilayah = R_Utility.R_GetStreamingContext("nTingkatWilayah")
                .cKodeParent = R_Utility.R_GetStreamingContext("cKodeParent")
            End With

            loRtnTemp = loCls.getLookUpGeography(loParam)

            loRtn = R_StreamUtility(Of LookUpGeographyDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpGeography")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpReference() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpReference

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpReferenceDTO)
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

            loRtn = R_StreamUtility(Of LookUpReferenceDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpReference")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMaintenance() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMaintenance

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMaintenanceDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.getLookUpMaintenance(loParam)

            loRtn = R_StreamUtility(Of LookUpMaintenanceDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMaintenance")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpTraining() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpTraining

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTrainingDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .cCompetencyCode = R_Utility.R_GetStreamingContext("cCompetencyCode")
            End With

            loRtnTemp = loCls.getLookUpTraining(loParam)

            loRtn = R_StreamUtility(Of LookUpTrainingDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpTraining")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpEmployeePNL11000() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployeePNL11000

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeePNL11000DTO)
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

            loRtn = R_StreamUtility(Of LookUpEmployeePNL11000DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpEmployeePNL11000")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpAnggotaKeluargaPNL15000() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpAnggotaKeluargaPNL15000


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAnggotaKeluargaPNL15000DTO)
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

            loRtn = R_StreamUtility(Of LookUpAnggotaKeluargaPNL15000DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpAnggotaKeluargaPNL15000")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function getLookUpTemporaryAssignmentPNL00520() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpTemporaryAssignmentPNL00520


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTemporaryAssignmentPNL00520DTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                '.cViewDate = R_Utility.R_GetStreamingContext("cViewDate")
            End With

            loRtnTemp = loCls.getLookUpTemporaryAssignmentPNL00520(loParam)

            loRtn = R_StreamUtility(Of LookUpTemporaryAssignmentPNL00520DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpTemporaryAssignmentPNL00520")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function getLookUpTemporaryPositionPNL00150() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpTemporaryPositionPNL00150
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTemporaryPositionPNL00150DTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpTemporaryPositionPNL00150(loParam)

            loRtn = R_StreamUtility(Of LookUpTemporaryPositionPNL00150DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpTemporaryPositionPNL00150")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpLetterMasterPNL01600() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpLetterMasterPNL01600
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpLetterMasterPNL01600DTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpLetterMasterPNL01600(loParam)

            loRtn = R_StreamUtility(Of LookUpLetterMasterPNL01600DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpLetterMasterPNL01600")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpLetterTemplatePNL01700() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpLetterTemplatePNL01700
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpLetterTemplatePNL01700DTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLetterId = R_Utility.R_GetStreamingContext("cLetterId")
            End With

            loRtnTemp = loCls.getLookUpLetterTemplatePNL01700(loParam)

            loRtn = R_StreamUtility(Of LookUpLetterTemplatePNL01700DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpLetterTemplatePNL01700")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeTransactionAndReport() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployeeTransactionAndReport
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeTransactionAndReportDTO)
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

            loRtn = R_StreamUtility(Of LookUpEmployeeTransactionAndReportDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpEmployeeTransactionAndReport")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpBPJSEmployeeAssignment() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpBPJSEmployeeAssignment
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpBPJSEmployeeAssignmentDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnTemp = loCls.getLookUpBPJSEmployeeAssignment(loParam)

            loRtn = R_StreamUtility(Of LookUpBPJSEmployeeAssignmentDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpBPJSEmployeeAssignment")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "ATTENDANCE LOOKUP SECTION"

    Public Function getLookUpHolidaysParameter() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpHolidaysParameter
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpHolidaysParameterDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpHolidaysParameter(loParam)

            loRtn = R_StreamUtility(Of LookUpHolidaysParameterDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpHolidaysParameter")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpMachineSetting() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMachineSetting
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMachineSettingDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpMachineSetting(loParam)

            loRtn = R_StreamUtility(Of LookUpMachineSettingDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMachineSetting")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpMachineTable() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMachineTable
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMachineTableDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cMachineType = R_Utility.R_GetStreamingContext("cMachineType")
            End With

            loRtnTemp = loCls.getLookUpMachineTable(loParam)

            loRtn = R_StreamUtility(Of LookUpMachineTableDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMachineTable")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpReasonsParameter() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpReasonsParameter
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpReasonsParameterDTO)
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

            loRtn = R_StreamUtility(Of LookUpReasonsParameterDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpReasonsParameter")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpHolidayEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpHolidayEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpHolidayEmployeeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cHolidayDate = R_Utility.R_GetStreamingContext("cHolidayDate")
            End With

            loRtnTemp = loCls.getLookUpHolidayEmployee(loParam)

            loRtn = R_StreamUtility(Of LookUpHolidayEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpHolidayEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCardMaster() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpCardMaster
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCardMasterDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpCardMaster(loParam)

            loRtn = R_StreamUtility(Of LookUpCardMasterDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpCardMaster")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpOvertimeManagement() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpOvertimeManagement
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpOvertimeIndexCodeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpOvertimeManagement(loParam)

            loRtn = R_StreamUtility(Of LookUpOvertimeIndexCodeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpOvertimeManagement")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpOvertimeIndexDetail() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpOvertimeIndexDetail
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpOvertimeIndexDetailDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cIndexCode = R_Utility.R_GetStreamingContext("cIndexCode")
            End With

            loRtnTemp = loCls.getLookUpOvertimeIndexDetail(loParam)

            loRtn = R_StreamUtility(Of LookUpOvertimeIndexDetailDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpOvertimeIndexDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpOvertimeRounded() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpOvertimeRounded
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpOvertimeRoundedDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpOvertimeRounded(loParam)

            loRtn = R_StreamUtility(Of LookUpOvertimeRoundedDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpOvertimeRounded")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpOvertimeCalculationIndex() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpOvertimeCalculationIndex
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpOvertimeCalculationIndexDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpOvertimeCalculationIndex(loParam)

            loRtn = R_StreamUtility(Of LookUpOvertimeCalculationIndexDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpOvertimeCalculationIndex")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpShiftManagement() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpShiftManagement
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpShiftDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpShiftManagement(loParam)

            loRtn = R_StreamUtility(Of LookUpShiftDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpShiftManagement")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpShiftPattern() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpShiftPattern
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpShiftPatternDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpShiftPattern(loParam)

            loRtn = R_StreamUtility(Of LookUpShiftPatternDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpShiftPattern")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpPatternSequence() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpPatternSequence
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpPatternSequenceDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPatternCode = R_Utility.R_GetStreamingContext("cPatternCode")
            End With

            loRtnTemp = loCls.getLookUpPatternSequence(loParam)

            loRtn = R_StreamUtility(Of LookUpPatternSequenceDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpPatternSequence")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpShiftGroup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpShiftGroup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpShiftGroupDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpShiftGroup(loParam)

            loRtn = R_StreamUtility(Of LookUpShiftGroupDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpShiftGroup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpShiftGroupEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpShiftGroupEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpShiftGroupEmployeeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getLookUpShiftGroupEmployee(loParam)

            loRtn = R_StreamUtility(Of LookUpShiftGroupEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpShiftGroupEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSpecialLeave() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSpecialLeave
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSpecialLeaveDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpSpecialLeave(loParam)

            loRtn = R_StreamUtility(Of LookUpSpecialLeaveDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSpecialLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpAdditionalLeave() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpAdditionalLeave
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAdditionalLeaveDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpAdditionalLeave(loParam)

            loRtn = R_StreamUtility(Of LookUpAdditionalLeaveDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpAdditionalLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function getLookUpAdditionalLeaveBalance() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpAdditionalLeaveBalance
    '    Dim loEx As New R_Exception
    '    Dim loCls As New SIAPP_PUB_DTOCls
    '    Dim loRtnTemp As List(Of LookUpAdditionalLeaveMasterDTO)
    '    Dim loRtn As Message
    '    Dim loParam As New ParameterDTO

    '    Try
    '        With loParam
    '            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
    '            .cLeaveType = R_Utility.R_GetStreamingContext("cLeaveType")
    '            .cLeaveCode = R_Utility.R_GetStreamingContext("cLeaveCode")
    '            .cYear = R_Utility.R_GetStreamingContext("cYear")
    '            .cExpiredDate = R_Utility.R_GetStreamingContext("cExpiredDate")
    '        End With

    '        loRtnTemp = loCls.getLookUpAdditionalLeaveBalance(loParam)

    '        loRtn = R_StreamUtility(Of LookUpAdditionalLeaveMasterDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpAdditionalLeaveBalance")
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function getLookUpAnnualLeave() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpAnnualLeave
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAnnualLeaveDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpAnnualLeave(loParam)

            loRtn = R_StreamUtility(Of LookUpAnnualLeaveDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpAnnualLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpIncidentalLeave() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpIncidentalLeave
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpIncidentalLeaveDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpIncidentalLeave(loParam)

            loRtn = R_StreamUtility(Of LookUpIncidentalLeaveDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpIncidentalLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpAnualLeaveEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpAnualLeaveEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAnualLeaveEmployeeDTO)
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

            loRtn = R_StreamUtility(Of LookUpAnualLeaveEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpAnualLeaveEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSchedule() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSchedule
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpScheduleDTO)
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

            loRtn = R_StreamUtility(Of LookUpScheduleDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSchedule")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpRequestOvertime() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpRequestOvertime
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpRequestOvertimeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cToDeptCode = R_Utility.R_GetStreamingContext("cToDeptCode")
            End With

            loRtnTemp = loCls.getLookUpRequestOvertime(loParam)

            loRtn = R_StreamUtility(Of LookUpRequestOvertimeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpRequestOvertime")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpDailyTimeHistory() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpDailyTimeHistory
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpDailyTimeHistoryDTO)
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

            loRtn = R_StreamUtility(Of LookUpDailyTimeHistoryDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpDailyTimeHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpRequestToDepartment() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpRequestToDepartment
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpRequestToDepartmentDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpRequestToDepartment(loParam)

            loRtn = R_StreamUtility(Of LookUpRequestToDepartmentDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpRequestToDepartment")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpAnalysisTable() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpAnalysisTable

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAnalysisTableDTO)
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

            loRtn = R_StreamUtility(Of LookUpAnalysisTableDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpAnalysisTable")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

#End Region

#Region "MEDICAL LOOKUP SECTION"

    Public Function getLookUpFamilyMember() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpFamilyMember
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpFamilyMemberDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getLookUpFamilyMember(loParam)

            loRtn = R_StreamUtility(Of LookUpFamilyMemberDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpFamilyMember")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpMedicalItem() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMedicalItem

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalItemDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cMedicalItemId = R_Utility.R_GetStreamingContext("cMedicalItemId")
            End With

            loRtnTemp = loCls.getLookUpMedicalItem(loParam)

            loRtn = R_StreamUtility(Of LookUpMedicalItemDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMedicalItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMedicalSubItem() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMedicalSubItem


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalSubItemDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cMedicalItemId = R_Utility.R_GetStreamingContext("cMedicalItemId")
            End With

            loRtnTemp = loCls.getLookUpMedicalSubItem(loParam)

            loRtn = R_StreamUtility(Of LookUpMedicalSubItemDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMedicalSubItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpBankAccount() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpBankAccount

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpBankAccountDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpBankAccount(loParam)

            loRtn = R_StreamUtility(Of LookUpBankAccountDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpBankAccount")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMedicalLimitItem() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMedicalLimitItem

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalItemDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnTemp = loCls.getLookUpMedicalLimitItem(loParam)

            loRtn = R_StreamUtility(Of LookUpMedicalItemDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMedicalLimitItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpHealthPartner() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpHealthPartner

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpHealthPartnerDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpHealthPartner(loParam)

            loRtn = R_StreamUtility(Of LookUpHealthPartnerDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpHealthPartner")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMedicalRule() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMedicalRule
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalRuleDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpMedicalRule(loParam)

            loRtn = R_StreamUtility(Of LookUpMedicalRuleDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMedicalRule")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedicalItem() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getMedicalItem
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getMedicalItem(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getMedicalItem")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedicalPartner() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getMedicalPartner
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
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

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getMedicalPartner")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeFamily() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployeeFamily

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalEmployeeFamilyDTO)
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

            loRtn = R_StreamUtility(Of LookUpMedicalEmployeeFamilyDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpEmployeeFamily")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpPartner() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpPartner


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalPartnerDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cProgramCode = R_Utility.R_GetStreamingContext("cProgramCode")
            End With

            loRtnTemp = loCls.getLookUpPartner(loParam)

            loRtn = R_StreamUtility(Of LookUpMedicalPartnerDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpPartner")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function getLookUpPartnerContractTransaction() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpPartnerContractTransaction


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalPartnerContractTransactionDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cKeyId = R_Utility.R_GetStreamingContext("cKeyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnTemp = loCls.getLookUpPartnerContractTransaction(loParam)

            loRtn = R_StreamUtility(Of LookUpMedicalPartnerContractTransactionDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpPartnerContractTransaction")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMedicalIllness() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getMedicalIllness
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getMedicalIllness(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getMedicalIllness")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMedicalEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMedicalEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalEmployeeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getLookUpMedicalEmployee(loParam)

            loRtn = R_StreamUtility(Of LookUpMedicalEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMedicalEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpMedicalClaim() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMedicalClaim


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpMedicalClaimDTO)
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

            loRtn = R_StreamUtility(Of LookUpMedicalClaimDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMedicalClaim")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function getLookUpTransferBank() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpTransferBank



        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTransferBankDTO)
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

            loRtn = R_StreamUtility(Of LookUpTransferBankDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpTransferBank")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn



    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getEmployee
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Employee_Medical_ClaimDTO)
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

            loRtn = R_StreamUtility(Of RSP_Employee_Medical_ClaimDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "LOAN LOOKUP SECTION"

    Public Function getLookUpLoanExpenseList() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpLoanExpenseList
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpLoanExpenseListDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpLoanExpenseList(loParam)

            loRtn = R_StreamUtility(Of LookUpLoanExpenseListDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpLoanExpenseList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpLoanCategoryList() As Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpLoanCategoryList
        Dim loEx As New R_Exception
        Dim loRtn As Message = Nothing

        Try
            Dim loParam As New ParameterDTO
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpLoanCategoryList(loParam)

            loRtn = R_StreamUtility(Of LookUpLoanCategoryDTO).WriteToMessage(loRtnTemp.AsEnumerable(), "getLookUpLoanCategoryList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLookUpNewLoanTransactionLNL00300() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpNewLoanTransactionLNL00300
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpNewLoanTransactionLNL00300DTO)
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

            loRtn = R_StreamUtility(Of LookUpNewLoanTransactionLNL00300DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpNewLoanTransactionLNL00300")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeLNL01000() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployeeLNL01000

        Dim loEx As New R_Exception
        Dim loRtn As Message = Nothing

        Try
            Dim loParam As New ParameterDTO
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            loParam.cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpEmployeeLNL01000(loParam)

            loRtn = R_StreamUtility(Of LookUpEmployeeLNL01000DTO).WriteToMessage(loRtnTemp.AsEnumerable(), "getLookUpEmployeeLNL01000")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function getLookUpEmployeeLNL01500() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployeeLNL01500


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

            loRtn = R_StreamUtility(Of LookUpEmployeeLNL01500DTO).WriteToMessage(loRtnTemp.AsEnumerable(), "getLookUpEmployeeLNL01500")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn


    End Function

    Public Function getLookUpEmployeeLNL02000() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployeeLNL02000
        Dim loEx As New R_Exception
        Dim loRtn As Message = Nothing

        Try
            Dim loParam As New ParameterDTO
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpEmployeeLNL02000(loParam)

            loRtn = R_StreamUtility(Of LookUpEmployeeLNL02000DTO).WriteToMessage(loRtnTemp.AsEnumerable(), "getLookUpEmployeeLNL02000")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
#End Region

#Region "PAYROLL LOOKUP SECTION"

    'PNL05100'
    Public Function getLookUpBpjsPerusahaan() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpBpjsPerusahaan
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpBPJSPerusahaanDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getLookUpBpjsPerusahaan(loParam)

            loRtn = R_StreamUtility(Of LookUpBPJSPerusahaanDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpBpjsPerusahaan")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpCurrency() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpCurrency
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCurrencyDTO)
        Dim loRtn As Message

        Try
            'With loParam
            '    .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            '    .lActiveFlag = R_Utility.R_GetStreamingContext("lActiveFlag")
            '    .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            'End With

            loRtnTemp = loCls.getLookUpCurrency()

            loRtn = R_StreamUtility(Of LookUpCurrencyDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpCurrency")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSalaryGroup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryGroupDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cProcessStatus = R_Utility.R_GetStreamingContext("cProcessStatus")
            End With

            loRtnTemp = loCls.getLookUpSalaryGroup(loParam)

            loRtn = R_StreamUtility(Of LookUpSalaryGroupDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSalaryGroup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpTransferSalaryGroup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpTransferSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryGroupDTO)
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

            loRtn = R_StreamUtility(Of LookUpSalaryGroupDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpTransferSalaryGroup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSalaryGroupPeriod() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSalaryGroupPeriod
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryGroupPeriodDTO)
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

            loRtn = R_StreamUtility(Of LookUpSalaryGroupPeriodDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSalaryGroupPeriod")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeList() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeListDTO)
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

            loRtn = R_StreamUtility(Of LookUpEmployeeListDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpEmployeeList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpMembershipEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpMembershipEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpEmployeeListDTO)
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

            loRtn = R_StreamUtility(Of LookUpEmployeeListDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpMembershipEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

#Region "COMPONENT LIST LOOKUP"
    Public Function getLookUpComponentModel1() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpComponentModel1
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpComponentDTO)
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

            loRtn = R_StreamUtility(Of LookUpComponentDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpComponentModel1")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpComponentModel2() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpComponentModel2
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpComponentDTO)
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

            loRtn = R_StreamUtility(Of LookUpComponentDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpComponentModel2")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpComponentModel3() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpComponentModel3
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpComponentDTO)
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

            loRtn = R_StreamUtility(Of LookUpComponentDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpComponentModel3")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpComponentList() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpComponentList
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpComponentDTO)
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

            loRtn = R_StreamUtility(Of LookUpComponentDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpComponentList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

    Public Function getLookUpSalaryPolicyUsage() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSalaryPolicyUsage
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryPolicyUsageDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cComponentCode = R_Utility.R_GetStreamingContext("cComponentCode")
            End With

            loRtnTemp = loCls.getLookUpSalaryPolicyUsage(loParam)

            loRtn = R_StreamUtility(Of LookUpSalaryPolicyUsageDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSalaryPolicyUsage")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#Region "SALARY PROCESS CODE LOOKUP"
    Public Function getLookUpSalaryProcessCodeModel1() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSalaryProcessCodeModel1
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryProcessCodeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLookUpSenderFlag = R_Utility.R_GetStreamingContext("cLookUpSenderFlag")
            End With

            loRtnTemp = loCls.getLookUpSalaryProcessCodeModel1(loParam)

            loRtn = R_StreamUtility(Of LookUpSalaryProcessCodeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSalaryProcessCodeModel1")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSalaryProcessCodeModel2() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSalaryProcessCodeModel2
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryProcessCodeDTO)
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

            loRtn = R_StreamUtility(Of LookUpSalaryProcessCodeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSalaryProcessCodeModel2")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSalaryProcessCodeModel3() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSalaryProcessCodeModel3
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryProcessCodeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpSalaryProcessCodeModel3(loParam)

            loRtn = R_StreamUtility(Of LookUpSalaryProcessCodeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSalaryProcessCodeModel3")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

    Public Function getLookUpJamsostek() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpJamsostek
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpJamsostekDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpJamsostek(loParam)

            loRtn = R_StreamUtility(Of LookUpJamsostekDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpJamsostek")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpTransferCode() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpTransferCode
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTransferCodeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpTransferCode(loParam)

            loRtn = R_StreamUtility(Of LookUpTransferCodeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpTransferCode")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpBank() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpBank
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpBankDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpBank(loParam)

            loRtn = R_StreamUtility(Of LookUpBankDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpBank")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpTaxOffice() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpTaxOffice
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpTaxOfficeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpTaxOffice(loParam)

            loRtn = R_StreamUtility(Of LookUpTaxOfficeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpTaxOffice")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpUserDefineParams() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpUserDefineParams
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpUserDefineParamsDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpUserDefineParams(loParam)

            loRtn = R_StreamUtility(Of LookUpUserDefineParamsDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpUserDefineParams")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpFormula() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpFormula
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpFormulaDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpFormula(loParam)

            loRtn = R_StreamUtility(Of LookUpFormulaDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpFormula")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookupRapelCompList() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookupRapelCompList
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpRapelComponentListDTO)
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

            loRtn = R_StreamUtility(Of LookUpRapelComponentListDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookupRapelCompList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpBPJSBank() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpBPJSBank
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpBPJSBankDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpBPJSBank(loParam)

            loRtn = R_StreamUtility(Of LookUpBPJSBankDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpBPJSBank")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpAllEmployee() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpAllEmployee

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpAllEmployeeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpAllEmployee(loParam)

            loRtn = R_StreamUtility(Of LookUpAllEmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpAllEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpCompanyBankAccount() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpCompanyBankAccount

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCompanyBankAccountDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpCompanyBankAccount(loParam)

            loRtn = R_StreamUtility(Of LookUpCompanyBankAccountDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpCompanyBankAccount")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpEmployeeBankAccount() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployeeBankAccount
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCompanyBankAccountDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtnTemp = loCls.getLookUpEmployeeBankAccount(loParam)

            loRtn = R_StreamUtility(Of LookUpCompanyBankAccountDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpEmployeeBankAccount")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSalaryGroupMulti() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSalaryGroupMulti

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpSalaryGroupMultiDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getLookUpSalaryGroupMulti(loParam)

            loRtn = R_StreamUtility(Of LookUpSalaryGroupMultiDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSalaryGroupMulti")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpPayrollUser() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpPayrollUser
        '

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpPayrollUserDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpPayrollUser(loParam)

            loRtn = R_StreamUtility(Of LookUpPayrollUserDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpPayrollUser")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function getLookUpObjekPajak() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpObjekPajak
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpObjekPajakDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpObjekPajak(loParam)

            loRtn = R_StreamUtility(Of LookUpObjekPajakDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpObjekPajak")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#Region "PYL00800"

    Public Function getCmbCurr() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getCmbCurr
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try

            loRtnTemp = loCls.getCmbCurr()

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getCmbCurr")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbGrade() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getCmbGrade
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbGrade(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getCmbGrade")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbLocation() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getCmbLocation
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbLocation(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getCmbLocation")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbPosition() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getCmbPosition
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbPosition(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getCmbPosition")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbSalaryGroup() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getCmbSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getCmbSalaryGroup(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getCmbSalaryGroup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbTaxOffice() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getCmbTaxOffice
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbTaxOffice(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getCmbTaxOffice")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbKodeObjekPajak() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getCmbKodeObjekPajak
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbKodeObjekPajak(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getCmbKodeObjekPajak")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#End Region

#Region "GENERAL SYSTEM LOOKUP SECTION"
    Public Function getLookUpDepartmentList() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpDepartmentList
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpDepartmentDTO)
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

            loRtn = R_StreamUtility(Of LookUpDepartmentDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpDepartmentList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLookUpCompany() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.GetLookUpCompany
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCompanyDTO)
        Dim loRtn As Message

        Try
            loRtnTemp = loCls.GetLookUpCompany()

            loRtn = R_StreamUtility(Of LookUpCompanyDTO).WriteToMessage(loRtnTemp.AsEnumerable, "GetLookUpCompany")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

#Region "QA LOOKUP SECTION"

    'COMBO BOX

    Public Function getCmbDepartment() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getCmbDepartment
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbDepartment(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getCmbDepartment")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbDocumentType() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getCmbDocumentType
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbDocumentType(loParam)

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getCmbDocumentType")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    '===========================================================================================================

    Public Function getLookUpParentDocument() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpParentDocument

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL00100DTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDocType = R_Utility.R_GetStreamingContext("cDocType")
            End With

            loRtnTemp = loCls.getLookUpParentDocument(loParam)

            loRtn = R_StreamUtility(Of QAL00100DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpParentDocument")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookUpDocument() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpDocument
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL00300DTO)
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

            loRtn = R_StreamUtility(Of QAL00300DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpDocument")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpFillingMethod() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpFillingMethod
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL00400DTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getLookUpFillingMethod(loParam)

            loRtn = R_StreamUtility(Of QAL00400DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpFillingMethod")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSocializationDetail() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSocializationDetail
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL01000DTO)
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

            loRtn = R_StreamUtility(Of QAL01000DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSocializationDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpSocializationHeader() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpSocializationHeader
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL01000DTO)
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

            loRtn = R_StreamUtility(Of QAL01000DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpSocializationHeader")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpEmployeeQA() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpEmployeeQA
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL01100DTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            End With

            loRtnTemp = loCls.getLookUpEmployeeQA(loParam)

            loRtn = R_StreamUtility(Of QAL01100DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpEmployeeQA")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpClause() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpClause
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtnTemp As List(Of QAL00500DTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cIsoType = R_Utility.R_GetStreamingContext("cIsoType")
                .cIsoVersion = R_Utility.R_GetStreamingContext("cIsoVersion")
            End With

            loRtnTemp = loCls.getLookUpClause(loParam)

            loRtn = R_StreamUtility(Of QAL00500DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpClause")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "JOB COMPETENCIES LOOKUP SECTION"

    Public Function getLookUpPositionCompetencies() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getLookUpPositionCompetencies
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtnTemp As List(Of JCL00100DTO)
        Dim loRtn As Message
        Dim loParam As New ParameterDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getLookUpPositionCompetencies(loParam)

            loRtn = R_StreamUtility(Of JCL00100DTO).WriteToMessage(loRtnTemp.AsEnumerable, "getLookUpPositionCompetencies")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#End Region

#Region "STORED PROCEDURE"
    Public Function RSP_Get_Payroll_Dimension() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_Get_Payroll_Dimension
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Get_Payroll_DimensionDTO)
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

            loRtn = R_StreamUtility(Of RSP_Get_Payroll_DimensionDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_Get_Payroll_Dimension")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_GET_USER_RIGHTS() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_GET_USER_RIGHTS
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Get_User_RightsDTO)
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

            loRtn = R_StreamUtility(Of RSP_Get_User_RightsDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_GET_USER_RIGHTS")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function RSP_Check_MTD_Process() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_Check_MTD_Process
    '    Dim loEx As New R_Exception
    '    Dim loCls As New SIAPP_PUB_DTOCls
    '    Dim loRtnTemp As List(Of RSP_Check_MTD_ProcessDTO)
    '    Dim loRtn As Message
    '    Dim loParam As New ParameterSPDTO

    '    Try
    '        With loParam
    '            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
    '            .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
    '            .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
    '            .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
    '        End With

    '        loRtnTemp = loCls.RSP_Check_MTD_Process(loParam)

    '        loRtn = R_StreamUtility(Of RSP_Check_MTD_ProcessDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_Check_MTD_Process")
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function RSP_Get_Class_Info() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_Get_Class_Info
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Class_InfoDTO)
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

            loRtn = R_StreamUtility(Of RFT_Get_Class_InfoDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_Get_Class_Info")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function SP_Get_Transaction_Profile() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.SP_Get_Transaction_Profile
    '    Dim loEx As New R_Exception
    '    Dim loCls As New SIAPP_PUB_DTOCls
    '    Dim loRtnTemp As List(Of SP_Get_Transaction_ProfileDTO)
    '    Dim loRtn As Message
    '    Dim loParam As New ParameterSPDTO

    '    Try
    '        With loParam
    '            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
    '            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
    '        End With

    '        loRtnTemp = loCls.SP_Get_Transaction_Profile(loParam)

    '        loRtn = R_StreamUtility(Of SP_Get_Transaction_ProfileDTO).WriteToMessage(loRtnTemp.AsEnumerable, "SP_Get_Transaction_Profile")
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function RSP_EMPSAL_COMPONENTS() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_EMPSAL_COMPONENTS
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Empsal_ComponentsDTO)
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

            loRtn = R_StreamUtility(Of RSP_Empsal_ComponentsDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_EMPSAL_COMPONENTS")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_PAYROLL_LOOKUP_EMPLOYEE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_PAYROLL_LOOKUP_EMPLOYEE
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Payroll_Lookup_EmployeeDTO)
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

                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .lYearly = R_Utility.R_GetStreamingContext("lYearly")
            End With

            loRtnTemp = loCls.RSP_PAYROLL_LOOKUP_EMPLOYEE(loParam)

            loRtn = R_StreamUtility(Of RSP_Payroll_Lookup_EmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_PAYROLL_LOOKUP_EMPLOYEE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_PERSONEL_LOOKUP_EMPLOYEE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_PERSONEL_LOOKUP_EMPLOYEE
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Personel_Lookup_EmployeeDTO)
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

            loRtn = R_StreamUtility(Of RSP_Personel_Lookup_EmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_PERSONEL_LOOKUP_EMPLOYEE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_Build_Loan_Policy_Matrix() As Boolean Implements ISIAPP_PUB_DTOStreamingService.RSP_Build_Loan_Policy_Matrix
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

    Public Function RSP_Get_Loan_Policy_Dimension() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_Get_Loan_Policy_Dimension
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Get_Loan_Policy_DimensionDTO)
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

            loRtn = R_StreamUtility(Of RSP_Get_Loan_Policy_DimensionDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_Get_Loan_Policy_Dimension")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_Get_Loan_Policy_Matrix() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_Get_Loan_Policy_Matrix
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Get_Loan_Policy_MatrixDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
            End With

            loRtnTemp = loCls.RSP_Get_Loan_Policy_Matrix(loParam)

            loRtn = R_StreamUtility(Of RSP_Get_Loan_Policy_MatrixDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_Get_Loan_Policy_Matrix")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_View_Feasibility() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_View_Feasibility
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_View_FeasibilityDTO)
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

            loRtn = R_StreamUtility(Of RSP_View_FeasibilityDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_View_Feasibility")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_FIND_NON_EMP_TRANSACTION() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_FIND_NON_EMP_TRANSACTION


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Find_Non_Emp_TransactionDTO)
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

            loRtn = R_StreamUtility(Of RSP_Find_Non_Emp_TransactionDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_FIND_NON_EMP_TRANSACTION")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_FIND_NON_EMPLOYEE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_FIND_NON_EMPLOYEE

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Find_Non_EmployeeDTO)
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


            loRtn = R_StreamUtility(Of RSP_Find_Non_EmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_FIND_NON_EMPLOYEE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RSP_MDB00100() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_MDB00100

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_MDB00100DTO)
        Dim loRtn As Message
        Dim loParam As New ParameterSPDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
            End With

            loRtnTemp = loCls.RSP_MDB00100(loParam)

            loRtn = R_StreamUtility(Of RSP_MDB00100DTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_MDB00100")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function RSP_MEDICAL_LIMIT() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_MEDICAL_LIMIT

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Medical_LimitDTO)
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

            loRtn = R_StreamUtility(Of RSP_Medical_LimitDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_MEDICAL_LIMIT")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RSP_GET_SELECTION_EMPLOYEE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_GET_SELECTION_EMPLOYEE


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_GET_SELECTION_EMPLOYEEDTO)
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

            loRtn = R_StreamUtility(Of RSP_GET_SELECTION_EMPLOYEEDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RSP_GET_SELECTION_EMPLOYEE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

#End Region

#Region "FUNCTION"

    Public Function RFT_FIND_SIMILAR_EMPLOYEES() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_FIND_SIMILAR_EMPLOYEES
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Find_Similar_EmployeesDTO)
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

            loRtn = R_StreamUtility(Of RFT_Find_Similar_EmployeesDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_FIND_SIMILAR_EMPLOYEES")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_VALIDATE_IDENTITY() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_VALIDATE_IDENTITY
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Find_Similar_EmployeesDTO)
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

            loRtn = R_StreamUtility(Of RFT_Find_Similar_EmployeesDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_VALIDATE_IDENTITY")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_USER_RIGHTS() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_USER_RIGHTS
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Get_User_RightsDTO)
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

            loRtn = R_StreamUtility(Of RSP_Get_User_RightsDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_USER_RIGHTS")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_PERSONAL_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_PERSONAL_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Personal_InfoDTO)
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

            loRtn = R_StreamUtility(Of RFT_Get_Personal_InfoDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_PERSONAL_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_DEPARTMENT_USER() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_DEPARTMENT_USER
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Department_UserDTO)
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

            loRtn = R_StreamUtility(Of RFT_Get_Department_UserDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_DEPARTMENT_USER")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LEAVE_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_LEAVE_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Leave_InfoDTO)
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

            loRtn = R_StreamUtility(Of RFT_Get_Leave_InfoDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_LEAVE_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_REASONS_PARAMETER() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_REASONS_PARAMETER
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Reasons_ParameterDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReasonCode = R_Utility.R_GetStreamingContext("cReasonCode")
                .lActive = R_Utility.R_GetStreamingContext("lActive")
            End With

            loRtnTemp = loCls.RFT_GET_REASONS_PARAMETER(loParam)

            loRtn = R_StreamUtility(Of RFT_Get_Reasons_ParameterDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_REASONS_PARAMETER")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_SCHEDULE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_SCHEDULE
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_ScheduleDTO)
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

            loRtn = R_StreamUtility(Of RFT_Get_ScheduleDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_SCHEDULE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_SHIFT_GROUP() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_SHIFT_GROUP
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Shift_GroupDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .lActive = R_Utility.R_GetStreamingContext("lActive")
            End With

            loRtnTemp = loCls.RFT_GET_SHIFT_GROUP(loParam)

            loRtn = R_StreamUtility(Of RFT_Get_Shift_GroupDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_SHIFT_GROUP")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_SHIFT_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_SHIFT_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Shift_InfoDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cShiftCode = R_Utility.R_GetStreamingContext("cShiftCode")
                .lActive = R_Utility.R_GetStreamingContext("lActive")
            End With

            loRtnTemp = loCls.RFT_GET_SHIFT_INFO(loParam)

            loRtn = R_StreamUtility(Of RFT_Get_Shift_InfoDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_SHIFT_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_GSB_CODE_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_GSB_CODE_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Class_InfoDTO)
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

            loRtn = R_StreamUtility(Of RFT_Get_Class_InfoDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_GSB_CODE_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_ACTUAL() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_ACTUAL
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_ActualDTO)
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

            loRtn = R_StreamUtility(Of RFT_Get_ActualDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_ACTUAL")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_CLASS_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_CLASS_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
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

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_CLASS_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_CURRENCY_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_CURRENCY_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Currency_InfoDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCurrencyCode = R_Utility.R_GetStreamingContext("cCurrencyCode")
                .cCreateDate = R_Utility.R_GetStreamingContext("cCreateDate")
            End With

            loRtnTemp = loCls.RFT_GET_CURRENCY_INFO(loParam)

            loRtn = R_StreamUtility(Of RFT_Get_Currency_InfoDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_CURRENCY_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_TIME_HISTORY() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_TIME_HISTORY
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Time_HistoryDTO)
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

            loRtn = R_StreamUtility(Of RFT_Get_Time_HistoryDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_TIME_HISTORY")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LOAN_TYPE_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_LOAN_TYPE_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RFT_Get_Loan_TypeDTO)
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cLoanType = R_Utility.R_GetStreamingContext("cLoanType")
            End With

            loRtnTemp = loCls.RFT_GET_LOAN_TYPE_INFO(loParam)

            loRtn = R_StreamUtility(Of RFT_Get_Loan_TypeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_LOAN_TYPE_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LOAN_TRANSACTION_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_LOAN_TRANSACTION_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_Get_Loan_Transaction_InfoDTO)

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

            loRtn = R_StreamUtility(Of RFT_Get_Loan_Transaction_InfoDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_LOAN_TRANSACTION_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LOAN_SYSTEM_PARAM() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_LOAN_SYSTEM_PARAM
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_Get_Loan_System_ParamDTO)

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.RFT_GET_LOAN_SYSTEM_PARAM(loParam)

            loRtn = R_StreamUtility(Of RFT_Get_Loan_System_ParamDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_LOAN_SYSTEM_PARAM")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LOAN_INSTALLMENT_INFO() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_LOAN_INSTALLMENT_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_Get_Loan_Installment_InfoDTO)

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

            loRtn = R_StreamUtility(Of RFT_Get_Loan_Installment_InfoDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_LOAN_INSTALLMENT_INFO")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_LEAVE_BALANCE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_LEAVE_BALANCE
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_Get_Leave_BalanceDTO)

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

            loRtn = R_StreamUtility(Of RFT_Get_Leave_BalanceDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_LEAVE_BALANCE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_SPLITSTRING() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_SPLITSTRING
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_SplitstringDTO)

        Try
            With loParam
                .cString = R_Utility.R_GetStreamingContext("cString")
                .cSeparator = R_Utility.R_GetStreamingContext("cSeparator")
            End With

            loRtnTemp = loCls.RFT_SPLITSTRING(loParam)

            loRtn = R_StreamUtility(Of RFT_SplitstringDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_SPLITSTRING")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'Public Function RFT_GET_LOAN_EXPENSE_INFO() As SIAPP_PUB_DTO.LookUpLoanExpenseListDTO Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_LOAN_EXPENSE_INFO
    '    Dim loEx As New R_Exception
    '    Dim loCls As New SIAPP_PUB_DTOCls
    '    Dim loRtn As LookUpLoanExpenseListDTO
    '    Dim loParam As New ParameterFuncDTO

    '    Try
    '        With loParam
    '            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
    '            .cExpenseCode = R_Utility.R_GetStreamingContext("cExpenseCode")
    '        End With

    '        loRtn = loCls.RFT_GET_LOAN_EXPENSE_INFO(loParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function RFT_GET_ANALYSIS_BALANCE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_ANALYSIS_BALANCE

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_GET_ANALYSIS_BALANCEDTO)

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cAttDescription = R_Utility.R_GetStreamingContext("cAttDescription")
            End With

            loRtnTemp = loCls.RFT_GET_ANALYSIS_BALANCE(loParam)

            loRtn = R_StreamUtility(Of RFT_GET_ANALYSIS_BALANCEDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_ANALYSIS_BALANCE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RFT_GET_ORG_STRUCTURE() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RFT_GET_ORG_STRUCTURE

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Message
        Dim loParam As New ParameterFuncDTO
        Dim loRtnTemp As List(Of RFT_Get_Org_StructureDTO)

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            End With

            loRtnTemp = loCls.RFT_GET_ORG_STRUCTURE(loParam)

            loRtn = R_StreamUtility(Of RFT_Get_Org_StructureDTO).WriteToMessage(loRtnTemp.AsEnumerable, "RFT_GET_ORG_STRUCTURE")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

#End Region

#Region "VALIDATE FUNCTION PAYROLL"
    'Public Function isAuthorizedDepartment() As SIAPP_PUB_DTO.LookUpDepartmentDTO Implements ISIAPP_PUB_DTOStreamingService.isAuthorizedDepartment
    '    Dim loEx As New R_Exception
    '    Dim loCls As New SIAPP_PUB_DTOCls
    '    Dim loRtn As LookUpDepartmentDTO
    '    Dim loParam As New ParameterDTO

    '    Try
    '        With loParam
    '            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
    '            .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
    '            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
    '        End With

    '        loRtn = loCls.isAuthorizedDepartment(loParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function isAuthorizedSalaryGroup() As SIAPP_PUB_DTO.LookUpSalaryGroupDTO Implements ISIAPP_PUB_DTOStreamingService.isAuthorizedSalaryGroup
    '    Dim loEx As New R_Exception
    '    Dim loCls As New SIAPP_PUB_DTOCls
    '    Dim loRtn As LookUpSalaryGroupDTO
    '    Dim loParam As New ParameterDTO

    '    Try
    '        With loParam
    '            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
    '            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
    '            .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
    '            .cProcessStatus = R_Utility.R_GetStreamingContext("cProcessStatus")
    '        End With

    '        loRtn = loCls.isAuthorizedSalaryGroup(loParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'Public Function isValidPeriod() As SIAPP_PUB_DTO.LookUpSalaryGroupPeriodDTO Implements ISIAPP_PUB_DTOStreamingService.isValidPeriod
    '    Dim loEx As New R_Exception
    '    Dim loCls As New SIAPP_PUB_DTOCls
    '    Dim loRtn As LookUpSalaryGroupPeriodDTO
    '    Dim loParam As New ParameterDTO

    '    Try
    '        With loParam
    '            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
    '            .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
    '            .cUserId = R_Utility.R_GetStreamingContext("cUserId")
    '            .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
    '            .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
    '        End With

    '        loRtn = loCls.isValidPeriod(loParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function
#End Region

#Region "ATP00100"
    Public Function getDataATP00100() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.getDataATP00100
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of RSP_Personel_Lookup_EmployeeDTO)
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

            loRtn = R_StreamUtility(Of RSP_Personel_Lookup_EmployeeDTO).WriteToMessage(loRtnTemp.AsEnumerable, "getDataATP00100")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

#Region "DUMMY"

    Public Sub DummyAttendance1(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpHolidaysParameterDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpHolidayEmployeeDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpCardMasterDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyAttendance1

    End Sub

    Public Sub DummyAttendance2(poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpOvertimeRoundedDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpOvertimeCalculationIndexDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpShiftDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyAttendance2

    End Sub

    Public Sub DummyAttendance6(poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpIncidentalLeaveDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpAdditionalLeaveDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyAttendance6

    End Sub

    Public Sub DummyFunction1(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_ScheduleDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Shift_GroupDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Shift_InfoDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Class_InfoDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyFunction1

    End Sub

    Public Sub DummySP(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_Get_Payroll_DimensionDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_Get_User_RightsDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.SP_Get_Reference_NumberDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_Check_MTD_ProcessDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummySP

    End Sub

    Public Sub DummySP2(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_Empsal_ComponentsDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_Payroll_Lookup_EmployeeDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_Get_Loan_Policy_MatrixDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_Get_Loan_Policy_DimensionDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummySP2

    End Sub

    Public Sub DummyFunction(poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Department_UserDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Leave_InfoDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Reasons_ParameterDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyFunction

    End Sub


    Public Sub DummyFunction2(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_ActualDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Time_HistoryDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Currency_InfoDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyFunction2

    End Sub

    Public Sub DummyAttendance5(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpDailyTimeHistoryDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyAttendance5

    End Sub

    Public Sub DummySP1(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.SP_Get_PeriodDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummySP1

    End Sub

    Public Sub DummyFunction3(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Loan_System_ParamDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Loan_Installment_InfoDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Leave_BalanceDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_SplitstringDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyFunction3

    End Sub

    Public Sub DummyFunction4(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_GET_ANALYSIS_BALANCEDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Get_Org_StructureDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyFunction4

    End Sub

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.SIAPP_PUB_DTOs), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.ATP00100GridDTO)) Implements ISIAPP_PUB_DTOStreamingService.Dummy

    End Sub


    Public Sub DummyAttendance7(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpAnalysisTableDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyAttendance7

    End Sub

    Public Sub DummyPayroll1(poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpEmployeeListDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_GET_SELECTION_EMPLOYEEDTO), poPar4 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.PNP00100GridDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyPayroll1

    End Sub

    Public Function ClassAndTranslate() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.ClassAndTranslate


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtnTemp As List(Of LookUpCmbDTO)
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

            loRtn = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtnTemp.AsEnumerable, "ClassAndTranslate")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Sub DummyPayroll4(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpSalaryGroupMultiDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpTrainingDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyPayroll4

    End Sub

    Public Sub DummyPersonal(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpReferenceDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpEmployeePNL11000DTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyPersonal

    End Sub

    Public Sub DummySP4(poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_MDB00100DTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_Medical_LimitDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummySP4

    End Sub

    Public Sub DummyPayroll3(poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpUserDefineParamsDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpRapelComponentListDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyPayroll3

    End Sub

    Public Sub DummyFunction5(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RFT_Find_Similar_EmployeesDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyFunction5

    End Sub

    Public Sub DummyPayroll2(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpSalaryPolicyUsageDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyPayroll2

    End Sub

    Public Sub DummyAttendance(poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpMachineTableDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpReasonsParameterDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyAttendance

    End Sub

    Public Sub DummyAttendance3(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpShiftPatternDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpShiftGroupDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpShiftGroupEmployeeDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyAttendance3

    End Sub

    Public Sub DummyAttendance4(poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpAnualLeaveEmployeeDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpRequestOvertimeDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyAttendance4

    End Sub

    Public Sub DummyLoan(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpLoanCategoryDTO), poPar1 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpEmployeeLNL01000DTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyLoan

    End Sub

    Public Sub DummyJobCompetencies(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.JCL00100DTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyJobCompetencies

    End Sub

    Public Sub DummySP3(poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.RSP_View_FeasibilityDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummySP3

    End Sub

    Public Function RSP_Installment_Schedule() As System.ServiceModel.Channels.Message Implements ISIAPP_PUB_DTOStreamingService.RSP_Installment_Schedule

    End Function

    Public Sub DummyMedical(poPar As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpFamilyMemberDTO), poPar2 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpMedicalSubItemDTO), poPar3 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpBankAccountDTO), poPar4 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpHealthPartnerDTO), poPar5 As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpMedicalRuleDTO)) Implements ISIAPP_PUB_DTOStreamingService.DummyMedical

    End Sub

#End Region
    
End Class

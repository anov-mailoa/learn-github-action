Imports R_Common
Imports SIAPP_PUB_DTO
Imports System.ServiceModel
Imports SIAPP_SERVICE_MENU

' NOTE: You can use the "Rename" command on the context menu to change the class name "SIAPP_PUB_DTOService" in code, svc and config file together.
Public Class SIAPP_PUB_DTOService
    Implements ISIAPP_PUB_DTOService

    Public Function GetPDP(compID As String) As String Implements ISIAPP_PUB_DTOService.GetPDP
        Dim loEx As New R_Exception
        Dim loCls As New Common
        Dim loRtn As String

        Try
            loRtn = loCls.GetPDP(compID)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function ClassAndTranslate(poParam As SIAPP_PUB_DTO.ParameterDTO) As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpCmbDTO) Implements ISIAPP_PUB_DTOService.ClassAndTranslate
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As List(Of LookUpCmbDTO)

        Try
            loRtn = loCls.ClassAndTranslate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function SetKey(pcKey As String) As String Implements ISIAPP_PUB_DTOService.SetKey
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loRtn = loCls.SetKey(pcKey)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#Region "LOOKUP SECTION"

#Region "PAYROLL"
    Public Function getCmbLookUpComponent() As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpCmbDTO) Implements ISIAPP_PUB_DTOService.getCmbLookUpComponent
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As List(Of LookUpCmbDTO)

        Try
            loRtn = loCls.getCmbLookUpComponent()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

#Region "PERSONAL"
    'Public Function GetLookUpRftDeptUser(poParam As SIAPP_PUB_DTO.ParameterDTO) As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpDepartmentDTO) Implements ISIAPP_PUB_DTOService.GetLookUpRftDeptUser
    '    Dim loEx As New R_Exception
    '    Dim loCls As New SIAPP_PUB_DTOCls
    '    Dim loRtn As List(Of LookUpDepartmentDTO)

    '    Try
    '        loRtn = loCls.GetLookUpRftDeptUser(poParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function
#End Region

#End Region

#Region "GET DESCRIPTION LOOKUP"

#Region "PERSONEL"

    'PNL00100'
    Public Function PNL00100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpPositionDTO Implements ISIAPP_PUB_DTOService.PNL00100DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpPositionDTO
        Dim loRtnTemp As List(Of LookUpPositionDTO)

        Try
            loRtnTemp = loCls.getLookUpPosition(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cPositionCode.Trim = poParam.cPositionCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00200'
    Public Function PNL00200DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpLocationDTO Implements ISIAPP_PUB_DTOService.PNL00200DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpLocationDTO
        Dim loRtnTemp As List(Of LookUpLocationDTO)

        Try
            loRtnTemp = loCls.getLookUpLocation(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cLocationCode.Trim = poParam.cLocationCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00300'
    Public Function PNL00300DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpGradeDTO Implements ISIAPP_PUB_DTOService.PNL00300DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpGradeDTO
        Dim loRtnTemp As List(Of LookUpGradeDTO)

        Try
            loRtnTemp = loCls.getLookUpGrade(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cGradeCode.Trim = poParam.cGradeCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00400'
    Public Function PNL00400DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpCodeDTO Implements ISIAPP_PUB_DTOService.PNL00400DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpCodeDTO
        Dim loRtnTemp As List(Of LookUpCodeDTO)

        Try
            loRtnTemp = loCls.getLookUpCode(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cCode.Trim = poParam.cClassRecId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00500'
    Public Function PNL00500DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpEmployeeDTO Implements ISIAPP_PUB_DTOService.PNL00500DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpEmployeeDTO
        Dim loRtnTemp As List(Of LookUpEmployeeDTO)

        Try
            loRtnTemp = loCls.getLookUpEmployee(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00501'
    Public Function PNL00501DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpActiveEmployeeDTO Implements ISIAPP_PUB_DTOService.PNL00501DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpActiveEmployeeDTO
        Dim loRtnTemp As List(Of LookUpActiveEmployeeDTO)

        Try
            loRtnTemp = loCls.getLookUpActiveEmployee(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00502'
    Public Function PNL00502DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpEmployeeWithFacilityDTO Implements ISIAPP_PUB_DTOService.PNL00502DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpEmployeeWithFacilityDTO
        Dim loRtnTemp As List(Of LookUpEmployeeWithFacilityDTO)

        Try
            loRtnTemp = loCls.getLookUpEmployeeWithFacility(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00503'
    Public Function PNL00503DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpProbationEmployeeDTO Implements ISIAPP_PUB_DTOService.PNL00503DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpProbationEmployeeDTO
        Dim loRtnTemp As List(Of LookUpProbationEmployeeDTO)

        Try
            loRtnTemp = loCls.getLookUpProbationEmployee(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00504'
    Public Function PNL00504DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpResignedContractEmployeeDTO Implements ISIAPP_PUB_DTOService.PNL00504DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpResignedContractEmployeeDTO
        Dim loRtnTemp As List(Of LookUpResignedContractEmployeeDTO)

        Try
            loRtnTemp = loCls.getLookUpResignedContractEmployee(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00505'
    Public Function PNL00505DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpActiveContractEmployeeDTO Implements ISIAPP_PUB_DTOService.PNL00505DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpActiveContractEmployeeDTO
        Dim loRtnTemp As List(Of LookUpActiveContractEmployeeDTO)

        Try
            loRtnTemp = loCls.getLookUpActiveContractEmployee(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00506'
    Public Function PNL00506DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpReactivationEmployeeDTO Implements ISIAPP_PUB_DTOService.PNL00506DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpReactivationEmployeeDTO
        Dim loRtnTemp As List(Of LookUpReactivationEmployeeDTO)

        Try
            loRtnTemp = loCls.getLookUpReactivationEmployee(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00600'
    Public Function PNL00600DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpFacilityDeviceDTO Implements ISIAPP_PUB_DTOService.PNL00600DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpFacilityDeviceDTO
        Dim loRtnTemp As List(Of LookUpFacilityDeviceDTO)

        Try
            loRtnTemp = loCls.getFacilityDeviceLookup(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cAssetCode.Trim = poParam.cAssetCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00700'
    Public Function PNL00700DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpEmployeeDTO Implements ISIAPP_PUB_DTOService.PNL00700DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpEmployeeDTO
        Dim loRtnTemp As List(Of LookUpEmployeeDTO)

        Try
            loRtnTemp = loCls.getEmployeeResignLookup(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL00900'
    Public Function PNL00900DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpCriteriaDTO Implements ISIAPP_PUB_DTOService.PNL00900DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpCriteriaDTO
        Dim loRtnTemp As List(Of LookUpCriteriaDTO)

        Try
            loRtnTemp = loCls.getLookUpCriteria()

            Dim loQuery = From A In loRtnTemp
                          Where A.cCriteriaId.Trim = poParam.cCriteriaId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL01000'
    Public Function PNL01000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpCountryDTO Implements ISIAPP_PUB_DTOService.PNL01000DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpCountryDTO
        Dim loRtnTemp As List(Of LookUpCountryDTO)

        Try
            loRtnTemp = loCls.getLookUpCountry(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cCountryCode.Trim = poParam.cCountryCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL01100'
    Public Function PNL01100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpProvinceDTO Implements ISIAPP_PUB_DTOService.PNL01100DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpProvinceDTO
        Dim loRtnTemp As List(Of LookUpProvinceDTO)

        Try
            loRtnTemp = loCls.getLookUpProvince(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cProvinceCode.Trim = poParam.cProvinceCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL01110'
    Public Function PNL01110DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpCityDTO Implements ISIAPP_PUB_DTOService.PNL01110DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpCityDTO
        Dim loRtnTemp As List(Of LookUpCityDTO)

        Try
            loRtnTemp = loCls.getLookUpCity(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cCityCode.Trim = poParam.cCityCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL1000'
    Public Function PNL1000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpCodeDTO Implements ISIAPP_PUB_DTOService.PNL1000DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpCodeDTO
        Dim loRtnTemp As List(Of LookUpCodeDTO)

        Try
            loRtnTemp = loCls.getLookUpCategory()

            Dim loQuery = From A In loRtnTemp
                          Where A.cCode.Trim = poParam.cClassRecId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL02000'
    Public Function PNL02000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpGeographyDTO Implements ISIAPP_PUB_DTOService.PNL02000DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpGeographyDTO
        Dim loRtnTemp As List(Of LookUpGeographyDTO)

        Try
            loRtnTemp = loCls.getLookUpGeography(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cKodeWilayah.Trim = poParam.cKodeWilayah.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL02010
    Public Function PNL02010DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpEmployeeTransactionAndReportDTO Implements ISIAPP_PUB_DTOService.PNL02010DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpEmployeeTransactionAndReportDTO
        Dim loRtnTemp As List(Of LookUpEmployeeTransactionAndReportDTO)

        Try
            loRtnTemp = loCls.getLookUpEmployeeTransactionAndReport(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.CEMPLOYEE_ID.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL02050
    Public Function PNL02050DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpBPJSEmployeeAssignmentDTO Implements ISIAPP_PUB_DTOService.PNL02050DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpBPJSEmployeeAssignmentDTO
        Dim loRtnTemp As List(Of LookUpBPJSEmployeeAssignmentDTO)

        Try
            loRtnTemp = loCls.getLookUpBPJSEmployeeAssignment(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A


            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL02100'
    Public Function PNL02100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpFasilitasKesehatanDTO Implements ISIAPP_PUB_DTOService.PNL02100DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpFasilitasKesehatanDTO
        Dim loRtnTemp As List(Of LookUpFasilitasKesehatanDTO)

        Try
            loRtnTemp = loCls.getLookUpFasilitasKesehatan(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cKodeFaskes.Trim = poParam.cKodeFaskes.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL09000'
    Public Function PNL09000ApreciationDESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpMaintenanceDTO Implements ISIAPP_PUB_DTOService.PNL09000ApreciationDESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpMaintenanceDTO
        Dim loRtnTemp As List(Of LookUpMaintenanceDTO)

        Try
            loRtnTemp = loCls.getLookUpMaintenance(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cAppreciationCode.Trim = poParam.cApreciationCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL09000'
    Public Function PNL09000OffenseDESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpMaintenanceDTO Implements ISIAPP_PUB_DTOService.PNL09000OffenseDESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpMaintenanceDTO
        Dim loRtnTemp As List(Of LookUpMaintenanceDTO)

        Try
            loRtnTemp = loCls.getLookUpMaintenance(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cOffenseCode.Trim = poParam.cOffenseCode.Trim
                          Select A

            If loQuery.Any Then
                loRtn = loQuery.FirstOrDefault
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL15000'
    Public Function PNL15000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpAnggotaKeluargaPNL15000DTO Implements ISIAPP_PUB_DTOService.PNL15000DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpAnggotaKeluargaPNL15000DTO
        Dim loRtnTemp As List(Of LookUpAnggotaKeluargaPNL15000DTO)

        Try
            loRtnTemp = loCls.getLookUpAnggotaKeluargaPNL15000(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cNik.Trim = poParam.cNikAnggota.Trim
                          Select A

            If loQuery.Any Then
                loRtn = loQuery.FirstOrDefault
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function PNL00150DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpTemporaryPositionPNL00150DTO Implements ISIAPP_PUB_DTOService.PNL00150DESC


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpTemporaryPositionPNL00150DTO
        Dim loRtnTemp As List(Of LookUpTemporaryPositionPNL00150DTO)

        Try
            loRtnTemp = loCls.getLookUpTemporaryPositionPNL00150(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cPositionCode.Trim = poParam.cPositionCode.Trim
                          Select A

            If loQuery.Any Then
                loRtn = loQuery.FirstOrDefault
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function PNL00520DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpTemporaryAssignmentPNL00520DTO Implements ISIAPP_PUB_DTOService.PNL00520DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpTemporaryAssignmentPNL00520DTO
        Dim loRtnTemp As List(Of LookUpTemporaryAssignmentPNL00520DTO)

        Try
            loRtnTemp = loCls.getLookUpTemporaryAssignmentPNL00520(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            If loQuery.Any Then
                loRtn = loQuery.FirstOrDefault
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function PNL00521DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpTemporaryAssignmentReportPNL00521DTO Implements ISIAPP_PUB_DTOService.PNL00521DESC


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpTemporaryAssignmentReportPNL00521DTO
        Dim loRtnTemp As List(Of LookUpTemporaryAssignmentReportPNL00521DTO)

        Try
            loRtnTemp = loCls.getLookUpTemporaryAssignmentReportPNL00521(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            If loQuery.Any Then
                loRtn = loQuery.FirstOrDefault
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function PNL00530DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpEmployeeProbationHistoryPNL00530DTO Implements ISIAPP_PUB_DTOService.PNL00530DESC


        'Dim loEx As New R_Exception
        'Dim loCls As New SIAPP_PUB_DTOCls
        'Dim loRtn As LookUpTemporaryAssignmentPNL00520DTO
        'Dim loRtnTemp As List(Of LookUpTemporaryAssignmentPNL00520DTO)

        'Try
        '    loRtnTemp = loCls.getLookUpTemporaryAssignmentPNL00520(poParam)

        '    Dim loQuery = From A In loRtnTemp
        '                    Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
        '                    Select A

        '    If loQuery.Any Then
        '        loRtn = loQuery.FirstOrDefault
        '    End If

        'Catch ex As Exception
        '    loEx.Add(ex)
        'End Try

        'loEx.ConvertAndThrowToServiceExceptionIfErrors()

        'Return loRtn


    End Function

    Public Function PNL00540DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpEmployeeContractHistoryPNL00540DTO Implements ISIAPP_PUB_DTOService.PNL00540DESC


        'Dim loEx As New R_Exception
        'Dim loCls As New SIAPP_PUB_DTOCls
        'Dim loRtn As LookUpTemporaryAssignmentPNL00520DTO
        'Dim loRtnTemp As List(Of LookUpTemporaryAssignmentPNL00520DTO)

        'Try
        '    loRtnTemp = loCls.getLookUpTemporaryAssignmentPNL00520(poParam)

        '    Dim loQuery = From A In loRtnTemp
        '                    Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
        '                    Select A

        '    If loQuery.Any Then
        '        loRtn = loQuery.FirstOrDefault
        '    End If

        'Catch ex As Exception
        '    loEx.Add(ex)
        'End Try

        'loEx.ConvertAndThrowToServiceExceptionIfErrors()

        'Return loRtn


    End Function

    Public Function PNL00550DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpEmployeeTransferPNL00550DTO Implements ISIAPP_PUB_DTOService.PNL00550DESC


        'Dim loEx As New R_Exception
        'Dim loCls As New SIAPP_PUB_DTOCls
        'Dim loRtn As LookUpTemporaryAssignmentPNL00520DTO
        'Dim loRtnTemp As List(Of LookUpTemporaryAssignmentPNL00520DTO)

        'Try
        '    loRtnTemp = loCls.getLookUpTemporaryAssignmentPNL00520(poParam)

        '    Dim loQuery = From A In loRtnTemp
        '                    Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
        '                    Select A

        '    If loQuery.Any Then
        '        loRtn = loQuery.FirstOrDefault
        '    End If

        'Catch ex As Exception
        '    loEx.Add(ex)
        'End Try

        'loEx.ConvertAndThrowToServiceExceptionIfErrors()

        'Return loRtn


    End Function

    'PNL01600'
    Public Function PNL01600DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpLetterMasterPNL01600DTO Implements ISIAPP_PUB_DTOService.PNL01600DESC


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpLetterMasterPNL01600DTO
        Dim loRtnTemp As List(Of LookUpLetterMasterPNL01600DTO)

        Try
            loRtnTemp = loCls.getLookUpLetterMasterPNL01600(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cLetterId.Trim = poParam.cLetterId.Trim
                          Select A

            If loQuery.Any Then
                loRtn = loQuery.FirstOrDefault
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    'PNL01700'
    Public Function PNL01700DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpLetterTemplatePNL01700DTO Implements ISIAPP_PUB_DTOService.PNL01700DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpLetterTemplatePNL01700DTO
        Dim loRtnTemp As List(Of LookUpLetterTemplatePNL01700DTO)

        Try
            loRtnTemp = loCls.getLookUpLetterTemplatePNL01700(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cTemplateId.Trim = poParam.cTemplateId.Trim
                          Select A

            If loQuery.Any Then
                loRtn = loQuery.FirstOrDefault
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'PNL02010
    'Public Function PNL02010DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpEmployeeTransactionAndReportDTO Implements ISIAPP_PUB_DTOService.PNL02010DESC
    '    Dim loEx As New R_Exception
    '    Dim loCls As New SIAPP_PUB_DTOCls
    '    Dim loRtn As LookUpEmployeeTransactionAndReportDTO
    '    Dim loRtnTemp As List(Of LookUpEmployeeTransactionAndReportDTO)

    '    Try
    '        loRtnTemp = loCls.getLookUpEmployeeTransactionAndReport(poParam)

    '        Dim loQuery = From A In loRtnTemp
    '                        Where A.cTemplateId.Trim = poParam.cTemplateId.Trim
    '                        Select A

    '        If loQuery.Any Then
    '            loRtn = loQuery.FirstOrDefault
    '        End If

    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    'PNL05100'
    Public Function PNL05100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpBPJSPerusahaanDTO Implements ISIAPP_PUB_DTOService.PNL05100DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpBPJSPerusahaanDTO
        Dim loRtnTemp As List(Of LookUpBPJSPerusahaanDTO)

        Try
            loRtnTemp = loCls.getLookUpBpjsPerusahaan(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cKodeBpjsPerusahaan.Trim = poParam.cKodeBpjsPerusahaan.Trim
                          Select A

            If loQuery.Any Then
                loRtn = loQuery.FirstOrDefault
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "ATTENDANCE"

    Public Function getDataATP00100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.RSP_Personel_Lookup_EmployeeDTO Implements ISIAPP_PUB_DTOService.getDataATP00100DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As RSP_Personel_Lookup_EmployeeDTO
        Dim loRtnTemp As List(Of RSP_Personel_Lookup_EmployeeDTO)

        Try
            loRtnTemp = loCls.getDataATP00100(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.CEMPLOYEE_ID.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ATL00200DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpMachineSettingDTO Implements ISIAPP_PUB_DTOService.ATL00200DESC
        Dim loEx As New R_Exception
        Dim loRtn As LookUpMachineSettingDTO

        Try
            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpMachineSetting(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cMachineType.Trim = poParam.cMachineType.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ATL00800DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpOvertimeIndexCodeDTO Implements ISIAPP_PUB_DTOService.ATL00800DESC
        Dim loEx As New R_Exception
        Dim loRtn As LookUpOvertimeIndexCodeDTO

        Try
            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpOvertimeManagement(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cIndexCode.Trim = poParam.cIndexCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ATL00900DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpOvertimeIndexDetailDTO Implements ISIAPP_PUB_DTOService.ATL00900DESC
        Dim loEx As New R_Exception
        Dim loRtn As LookUpOvertimeIndexDetailDTO

        Try
            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpOvertimeIndexDetail(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cIndexCode.Trim = poParam.cIndexCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ATL01400DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpPatternSequenceDTO Implements ISIAPP_PUB_DTOService.ATL01400DESC
        Dim loEx As New R_Exception
        Dim loRtn As LookUpPatternSequenceDTO

        Try
            Dim loRtnTemp = New SIAPP_PUB_DTOCls().getLookUpPatternSequence(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.iPatternSequence = poParam.iPatternSequence
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function ATL02200DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpScheduleDTO Implements ISIAPP_PUB_DTOService.ATL02200DESC
        Dim loEx As New R_Exception
        Dim loRtn As LookUpScheduleDTO
        Dim loCls As New SIAPP_PUB_DTOCls

        Try
            Dim loRtnTemp = loCls.getLookUpSchedule(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cShiftCode.Trim = poParam.cShiftCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function ATL02500DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpRequestToDepartmentDTO Implements ISIAPP_PUB_DTOService.ATL02500DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpRequestToDepartmentDTO
        Dim loRtnTemp As List(Of LookUpRequestToDepartmentDTO)

        Try
            loRtnTemp = loCls.getLookUpRequestToDepartment(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cDeptCode.Trim = poParam.cDeptCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ATL01700DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpSpecialLeaveDTO Implements ISIAPP_PUB_DTOService.ATL01700DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpSpecialLeaveDTO
        Dim loRtnTemp As List(Of LookUpSpecialLeaveDTO)

        Try
            loRtnTemp = loCls.getLookUpSpecialLeave(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cLeaveCode.Trim = poParam.cLeaveCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ATL01800DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpAnnualLeaveDTO Implements ISIAPP_PUB_DTOService.ATL01800DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpAnnualLeaveDTO
        Dim loRtnTemp As List(Of LookUpAnnualLeaveDTO)

        Try
            loRtnTemp = loCls.getLookUpAnnualLeave(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cLeaveCode.Trim = poParam.cLeaveCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "LOAN"

    Public Function LNL00100DESC(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As SIAPP_PUB_DTO.RFT_Get_Loan_TypeDTO Implements ISIAPP_PUB_DTOService.LNL00100DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As RFT_Get_Loan_TypeDTO
        Dim loRtnTemp As List(Of RFT_Get_Loan_TypeDTO)

        Try
            loRtnTemp = loCls.RFT_GET_LOAN_TYPE_INFO(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cLoanType.Trim = poParam.cLoanType.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function LNL00200DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpLoanExpenseListDTO Implements ISIAPP_PUB_DTOService.LNL00200DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpLoanExpenseListDTO
        Dim loRtnTemp As List(Of LookUpLoanExpenseListDTO)

        Try
            loRtnTemp = loCls.getLookUpLoanExpenseList(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cExpenseCode.Trim = poParam.cExpenseCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function LNL00300DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpNewLoanTransactionLNL00300DTO Implements ISIAPP_PUB_DTOService.LNL00300DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpNewLoanTransactionLNL00300DTO
        Dim loRtnTemp As List(Of LookUpNewLoanTransactionLNL00300DTO)

        Try
            loRtnTemp = loCls.getLookUpNewLoanTransactionLNL00300(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cReferenceNo.Trim = poParam.cReferenceNo.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RFT_GET_LOAN_EXPENSE_INFO(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As SIAPP_PUB_DTO.LookUpLoanExpenseListDTO Implements ISIAPP_PUB_DTOService.RFT_GET_LOAN_EXPENSE_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpLoanExpenseListDTO

        Try
            loRtn = loCls.RFT_GET_LOAN_EXPENSE_INFO(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function LNL01500DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpEmployeeLNL01500DTO Implements ISIAPP_PUB_DTOService.LNL01500DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpEmployeeLNL01500DTO
        Dim loRtnTemp As List(Of LookUpEmployeeLNL01500DTO)

        Try
            loRtnTemp = loCls.getLookUpEmployeeLNL01500(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function LNL02000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpEmployeeLNL02000DTO Implements ISIAPP_PUB_DTOService.LNL02000DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpEmployeeLNL02000DTO
        Dim loRtnTemp As List(Of LookUpEmployeeLNL02000DTO)

        Try
            loRtnTemp = loCls.getLookUpEmployeeLNL02000(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A
            loRtn = loQuery.FirstOrDefault

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

#End Region

#Region "GENERAL SYSTEM"
    Public Function GSL00100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpDepartmentDTO Implements ISIAPP_PUB_DTOService.GSL00100DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpDepartmentDTO
        Dim loRtnTemp As List(Of LookUpDepartmentDTO)

        Try
            loRtnTemp = loCls.getLookUpDepartmentList(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cDeptCode.Trim = poParam.cDeptCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GSL00200DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpCompanyDTO Implements ISIAPP_PUB_DTOService.GSL00200DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpCompanyDTO
        Dim loRtnTemp As List(Of LookUpCompanyDTO)

        Try
            loRtnTemp = loCls.GetLookUpCompany()

            Dim loQuery = From A In loRtnTemp
                          Where A.cCompanyId.Trim = poParam.cCompanyId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

#Region "PUBLIC FUNCTION"
    Public Function RFT_GET_PERSONAL_INFO_DESC(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As SIAPP_PUB_DTO.RFT_Get_Personal_InfoDTO Implements ISIAPP_PUB_DTOService.RFT_GET_PERSONAL_INFO_DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As RFT_Get_Personal_InfoDTO
        Dim loRtnTemp As List(Of RFT_Get_Personal_InfoDTO)

        Try
            loRtnTemp = loCls.RFT_GET_PERSONAL_INFO(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

#Region "PAYROLL"

#Region "COMPONENT MODEL 1 - 3"

    Public Function PYL00401DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpComponentDTO Implements ISIAPP_PUB_DTOService.PYL00401DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpComponentDTO
        Dim loRtnTemp As List(Of LookUpComponentDTO)

        Try
            loRtnTemp = loCls.getLookUpComponentModel1(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cComponentCode.Trim = poParam.cComponentCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function PYL00402DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpComponentDTO Implements ISIAPP_PUB_DTOService.PYL00402DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpComponentDTO
        Dim loRtnTemp As List(Of LookUpComponentDTO)

        Try
            loRtnTemp = loCls.getLookUpComponentModel2(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cComponentCode.Trim = poParam.cComponentCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function PYL00403DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpComponentDTO Implements ISIAPP_PUB_DTOService.PYL00403DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpComponentDTO
        Dim loRtnTemp As List(Of LookUpComponentDTO)

        Try
            loRtnTemp = loCls.getLookUpComponentModel3(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cComponentCode.Trim = poParam.cComponentCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

    Public Function PYL00100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpSalaryGroupDTO Implements ISIAPP_PUB_DTOService.PYL00100DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpSalaryGroupDTO
        Dim loRtnTemp As List(Of LookUpSalaryGroupDTO)

        Try
            loRtnTemp = loCls.getLookUpSalaryGroup(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cGroupCode.Trim = poParam.cGroupCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function PYL00200DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpSalaryGroupPeriodDTO Implements ISIAPP_PUB_DTOService.PYL00200DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpSalaryGroupPeriodDTO
        Dim loRtnTemp As List(Of LookUpSalaryGroupPeriodDTO)

        Try
            loRtnTemp = loCls.getLookUpSalaryGroupPeriod(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cPeriodIndex.Trim = poParam.cPeriodIndex.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function PYL00610DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpSalaryProcessCodeDTO Implements ISIAPP_PUB_DTOService.PYL00610DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpSalaryProcessCodeDTO
        Dim loRtnTemp As List(Of LookUpSalaryProcessCodeDTO)

        Try
            loRtnTemp = loCls.getLookUpSalaryProcessCodeModel1(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cProcessCode.Trim = poParam.cProcessCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function PYL00620DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpSalaryProcessCodeDTO Implements ISIAPP_PUB_DTOService.PYL00620DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpSalaryProcessCodeDTO
        Dim loRtnTemp As List(Of LookUpSalaryProcessCodeDTO)

        Try
            loRtnTemp = loCls.getLookUpSalaryProcessCodeModel2(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cProcessCode.Trim = poParam.cProcessCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function PYL00700DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpCurrencyDTO Implements ISIAPP_PUB_DTOService.PYL00700DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpCurrencyDTO
        Dim loRtnTemp As List(Of LookUpCurrencyDTO)

        Try
            loRtnTemp = loCls.getLookUpCurrency()

            Dim loQuery = From A In loRtnTemp
                          Where A.cCurrencyCode.Trim = poParam.cCurrencyCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn



    End Function

    Public Function PYL01000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpPayrollUserDTO Implements ISIAPP_PUB_DTOService.PYL01000DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpPayrollUserDTO
        Dim loRtnTemp As List(Of LookUpPayrollUserDTO)

        Try
            loRtnTemp = loCls.getLookUpPayrollUser(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cUserId.Trim = poParam.cUserId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn



    End Function

    Public Function PYL00900DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpBPJSBankDTO Implements ISIAPP_PUB_DTOService.PYL00900DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpBPJSBankDTO
        Dim loRtnTemp As List(Of LookUpBPJSBankDTO)

        Try
            loRtnTemp = loCls.getLookUpBPJSBank(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cBpjsId.Trim = poParam.cBpjsId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function PYL01500DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpJamsostekDTO Implements ISIAPP_PUB_DTOService.PYL01500DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpJamsostekDTO
        Dim loRtnTemp As List(Of LookUpJamsostekDTO)

        Try
            loRtnTemp = loCls.getLookUpJamsostek(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cKodeBpjsTk.Trim = poParam.cKodeBpjsTk.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function PYL01800DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpCompanyBankAccountDTO Implements ISIAPP_PUB_DTOService.PYL01800DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpCompanyBankAccountDTO
        Dim loRtnTemp As List(Of LookUpCompanyBankAccountDTO)

        Try
            loRtnTemp = loCls.getLookUpCompanyBankAccount(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cAccountNo.Trim = poParam.cAccountNo.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function PYL02000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpFormulaDTO Implements ISIAPP_PUB_DTOService.PYL02000DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpFormulaDTO
        Dim loRtnTemp As List(Of LookUpFormulaDTO)

        Try
            loRtnTemp = loCls.getLookUpFormula(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cFormulaCode.Trim = poParam.cFormulaCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function PYL01600DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpTaxOfficeDTO Implements ISIAPP_PUB_DTOService.PYL01600DESC
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpTaxOfficeDTO
        Dim loRtnTemp As List(Of LookUpTaxOfficeDTO)
        Dim loEx As New R_Exception()

        Try
            loRtnTemp = loCls.getLookUpTaxOffice(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cNpwp.Trim = poParam.cNpwp.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function PYL01300DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpTransferCodeDTO Implements ISIAPP_PUB_DTOService.PYL01300DESC
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpTransferCodeDTO
        Dim loRtnTemp As List(Of LookUpTransferCodeDTO)
        Dim loEx As New R_Exception()

        Try
            loRtnTemp = loCls.getLookUpTransferCode(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cTransferCode.Trim = poParam.cTransferCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function PYL01400DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpBankDTO Implements ISIAPP_PUB_DTOService.PYL01400DESC
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpBankDTO
        Dim loRtnTemp As List(Of LookUpBankDTO)
        Dim loEx As New R_Exception()

        Try
            loRtnTemp = loCls.getLookUpBank(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cCbCode.Trim = poParam.cBankCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function PYL01150DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpAllEmployeeDTO Implements ISIAPP_PUB_DTOService.PYL01150DESC
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpAllEmployeeDTO
        Dim loRtnTemp As List(Of LookUpAllEmployeeDTO)
        Dim loEx As New R_Exception()

        Try
            loRtnTemp = loCls.getLookUpAllEmployee(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cNpwp.Trim = poParam.cNpwp.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function PYL02100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpSalaryGroupDTO Implements ISIAPP_PUB_DTOService.PYL02100DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpSalaryGroupDTO
        Dim loRtnTemp As List(Of LookUpSalaryGroupDTO)

        Try
            loRtnTemp = loCls.getLookUpTransferSalaryGroup(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cGroupCode.Trim = poParam.cCurrentGroupCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function NEL00100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpObjekPajakDTO Implements ISIAPP_PUB_DTOService.NEL00100DESC
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpObjekPajakDTO
        Dim loRtnTemp As List(Of LookUpObjekPajakDTO)
        Dim loEx As New R_Exception()

        Try
            loRtnTemp = loCls.getLookUpObjekPajak(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cKodeObjekPajak.Trim = poParam.cKodeObjekPajak.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "MEDICAL"

    Public Function MDL00500DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpMedicalItemDTO Implements ISIAPP_PUB_DTOService.MDL00500DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpMedicalItemDTO
        Dim loRtnTemp As List(Of LookUpMedicalItemDTO)

        Try
            loRtnTemp = loCls.getLookUpMedicalItem(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cMedicalItemId.Trim = poParam.cMedicalItemId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function MCL00100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpMedicalEmployeeDTO Implements ISIAPP_PUB_DTOService.MCL00100DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpMedicalEmployeeDTO
        Dim loRtnTemp As List(Of LookUpMedicalEmployeeDTO)

        Try
            loRtnTemp = loCls.getLookUpMedicalEmployee(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function MCL00200DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpMedicalPartnerDTO Implements ISIAPP_PUB_DTOService.MCL00200DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpMedicalPartnerDTO
        Dim loRtnTemp As List(Of LookUpMedicalPartnerDTO)

        Try
            loRtnTemp = loCls.getLookUpPartner(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cPartnerId.Trim = poParam.cPartnerId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function MCL00300DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpMedicalEmployeeFamilyDTO Implements ISIAPP_PUB_DTOService.MCL00300DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpMedicalEmployeeFamilyDTO
        Dim loRtnTemp As List(Of LookUpMedicalEmployeeFamilyDTO)

        Try
            loRtnTemp = loCls.getLookUpEmployeeFamily(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cFamilyName.Trim = poParam.cFamilyName.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function MCL00400DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpMedicalPartnerContractTransactionDTO Implements ISIAPP_PUB_DTOService.MCL00400DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpMedicalPartnerContractTransactionDTO
        Dim loRtnTemp As List(Of LookUpMedicalPartnerContractTransactionDTO)

        Try
            loRtnTemp = loCls.getLookUpPartnerContractTransaction(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cPartnerId.Trim = poParam.cPartnerId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function MCL00500DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpMedicalClaimDTO Implements ISIAPP_PUB_DTOService.MCL00500DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpMedicalClaimDTO
        Dim loRtnTemp As List(Of LookUpMedicalClaimDTO)

        Try
            loRtnTemp = loCls.getLookUpMedicalClaim(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function MCL00600DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpTransferBankDTO Implements ISIAPP_PUB_DTOService.MCL00600DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpTransferBankDTO
        Dim loRtnTemp As List(Of LookUpTransferBankDTO)

        Try
            loRtnTemp = loCls.getLookUpTransferBank(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cBankCode.Trim = poParam.cBankCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function MCL01000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.RSP_Employee_Medical_ClaimDTO Implements ISIAPP_PUB_DTOService.MCL01000DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As RSP_Employee_Medical_ClaimDTO
        Dim loRtnTemp As List(Of RSP_Employee_Medical_ClaimDTO)

        Try
            loRtnTemp = loCls.getEmployee(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.CEMPLOYEE_ID.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "QA"

    Public Function QAL00100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.QAL00100DTO Implements ISIAPP_PUB_DTOService.QAL00100DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtn As QAL00100DTO
        Dim loRtnTemp As List(Of QAL00100DTO)

        Try
            loRtnTemp = loCls.getLookUpParentDocument(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cDocNo.Trim = poParam.cDocNo.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function QAL00300DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.QAL00300DTO Implements ISIAPP_PUB_DTOService.QAL00300DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtn As QAL00300DTO
        Dim loRtnTemp As List(Of QAL00300DTO)

        Try
            loRtnTemp = loCls.getLookUpDocument(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cDocNo.Trim = poParam.cDocNo.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function QAL00400DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.QAL00400DTO Implements ISIAPP_PUB_DTOService.QAL00400DESC


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtn As QAL00400DTO
        Dim loRtnTemp As List(Of QAL00400DTO)

        Try
            loRtnTemp = loCls.getLookUpFillingMethod(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cMethodCode.Trim = poParam.cMethodCode.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn



    End Function

    Public Function QAL00500DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.QAL00500DTO Implements ISIAPP_PUB_DTOService.QAL00500DESC


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtn As QAL00500DTO
        Dim loRtnTemp As List(Of QAL00500DTO)

        Try
            loRtnTemp = loCls.getLookUpClause(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cClauseNo.Trim = poParam.cClauseNo.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn


    End Function

    Public Function QAL01000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.QAL01000DTO Implements ISIAPP_PUB_DTOService.QAL01000DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtn As QAL01000DTO
        Dim loRtnTemp As List(Of QAL01000DTO)

        Try
            loRtnTemp = loCls.getLookUpSocializationHeader(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cReferenceNo.Trim = poParam.cReferenceNo.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn



    End Function

    Public Function QAL01100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.QAL01100DTO Implements ISIAPP_PUB_DTOService.QAL01100DESC

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOQACls
        Dim loRtn As QAL01100DTO
        Dim loRtnTemp As List(Of QAL01100DTO)

        Try
            loRtnTemp = loCls.getLookUpEmployeeQA(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.cEmployeeId.Trim = poParam.cEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

#End Region

#Region "JC"

    Public Function JCL00100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As String Implements ISIAPP_PUB_DTOService.JCL00100DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtn As String
        Dim loRtnTemp As List(Of JCL00100DTO)

        Try
            loRtnTemp = loCls.getLookUpPositionCompetencies(poParam)

            Dim loQuery = (From A In loRtnTemp
                           Where A.cPositionCode.Trim = poParam.cPositionCode.Trim
                           Select A).ToList

            If loQuery.Count = 0 Then
                loRtn = ""
            Else
                loRtn = loQuery.FirstOrDefault.cPositionDescription
            End If

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function JCL01000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.JCL01000DTO Implements ISIAPP_PUB_DTOService.JCL01000DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtn As New JCL01000DTO
        Dim loRtnTemp As List(Of JCL01000DTO)

        Try
            loRtnTemp = loCls.getLookUpAppraiserEmployee(poParam)

            loRtn = (From A In loRtnTemp
                     Where A.CEMPLOYEE_ID.Trim = poParam.cAppraiserEmpId.Trim
                     Select A).ToList.FirstOrDefault


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function JCL02000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.JCL02000DTO Implements ISIAPP_PUB_DTOService.JCL02000DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtn As New JCL02000DTO

        Try
            loRtn = loCls.getLookUpJcEmployeePositionDESC(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function JCL03000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.JCL03000DTO Implements ISIAPP_PUB_DTOService.JCL03000DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtn As New JCL03000DTO

        Try
            loRtn = loCls.getLookUpEvaluationEmployeeDESC(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function JCL04000DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.JCL04000DTO Implements ISIAPP_PUB_DTOService.JCL04000DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtn As New JCL04000DTO

        Try
            loRtn = loCls.getLookUpCategoryCompetencyDESC(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function JCL04100DESC(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.JCL04000DTO Implements ISIAPP_PUB_DTOService.JCL04100DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOJCCls
        Dim loRtn As New JCL04000DTO

        Try
            loRtn = loCls.getLookUpCompetencyDESC(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#End Region

#Region "VALIDATE FUNCTION PAYROLL"
    Public Function isAuthorizedDepartment(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpDepartmentDTO Implements ISIAPP_PUB_DTOService.isAuthorizedDepartment
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpDepartmentDTO

        Try
            loRtn = loCls.isAuthorizedDepartment(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function isAuthorizedSalaryGroup(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpSalaryGroupDTO Implements ISIAPP_PUB_DTOService.isAuthorizedSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpSalaryGroupDTO

        Try
            loRtn = loCls.isAuthorizedSalaryGroup(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function isValidPeriod(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.LookUpSalaryGroupPeriodDTO Implements ISIAPP_PUB_DTOService.isValidPeriod
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As LookUpSalaryGroupPeriodDTO

        Try
            loRtn = loCls.isValidPeriod(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

#Region "FUNCTION SECTION"

    Public Function RSP_FIND_NON_EMP_TRANSACTION_DESC(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As SIAPP_PUB_DTO.RSP_Find_Non_Emp_TransactionDTO Implements ISIAPP_PUB_DTOService.RSP_FIND_NON_EMP_TRANSACTION_DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As RSP_Find_Non_Emp_TransactionDTO
        Dim loRtnTemp As List(Of RSP_Find_Non_Emp_TransactionDTO)

        Try
            loRtnTemp = loCls.RSP_FIND_NON_EMP_TRANSACTION(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.CNON_EMPLOYEE_ID.Trim = poParam.cNonEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_FIND_NON_EMPLOYEE_DESC(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As SIAPP_PUB_DTO.RSP_Find_Non_EmployeeDTO Implements ISIAPP_PUB_DTOService.RSP_FIND_NON_EMPLOYEE_DESC
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As RSP_Find_Non_EmployeeDTO
        Dim loRtnTemp As List(Of RSP_Find_Non_EmployeeDTO)

        Try
            loRtnTemp = loCls.RSP_FIND_NON_EMPLOYEE(poParam)

            Dim loQuery = From A In loRtnTemp
                          Where A.CNON_EMPLOYEE_ID.Trim = poParam.cNonEmployeeId.Trim
                          Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFN_GET_ACTIVE_INDEX(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As SIAPP_PUB_DTO.ParameterFuncDTO Implements ISIAPP_PUB_DTOService.RFN_GET_ACTIVE_INDEX
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As New ParameterFuncDTO

        Try
            loRtn = loCls.RFN_GET_ACTIVE_INDEX(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFN_CHECK_RESTRICT_SALARY(pcCompId As String) As Integer Implements ISIAPP_PUB_DTOService.RFN_CHECK_RESTRICT_SALARY
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim liRtn As Integer

        Try
            liRtn = loCls.RFN_CHECK_RESTRICT_SALARY(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return liRtn
    End Function

    Public Function RFN_Get_Transaction_No_Used(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As Integer Implements ISIAPP_PUB_DTOService.RFN_Get_Transaction_No_Used
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Integer

        Try
            loRtn = loCls.RFN_Get_Transaction_No_Used(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFN_Numeric_Decryption(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As Decimal Implements ISIAPP_PUB_DTOService.RFN_Numeric_Decryption
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Decimal

        Try
            loRtn = loCls.RFN_Numeric_Decryption(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFN_Numeric_Encryption(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As Byte() Implements ISIAPP_PUB_DTOService.RFN_Numeric_Encryption
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Byte()

        Try
            loRtn = loCls.RFN_Numeric_Encryption(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFN_Get_Period(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As String Implements ISIAPP_PUB_DTOService.RFN_Get_Period
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loRtn = loCls.RFN_Get_Period(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFN_Check_MTD_Process(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As Integer Implements ISIAPP_PUB_DTOService.RFN_Check_MTD_Process
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Integer

        Try
            loRtn = loCls.RFN_Check_MTD_Process(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_HOURS_ADD(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As String Implements ISIAPP_PUB_DTOService.RFT_GET_HOURS_ADD
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loRtn = loCls.RFT_GET_HOURS_ADD(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_Get_Hours(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As SIAPP_PUB_DTO.RFT_Get_HoursDTO Implements ISIAPP_PUB_DTOService.RFT_Get_Hours

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As RFT_Get_HoursDTO

        Try
            loRtn = loCls.RFT_GET_HOURS(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RFT_GET_PERSONNEL_SYSTEM(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As SIAPP_PUB_DTO.RFT_Get_Personnel_SystemDTO Implements ISIAPP_PUB_DTOService.RFT_GET_PERSONNEL_SYSTEM

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As RFT_Get_Personnel_SystemDTO

        Try
            loRtn = loCls.RFT_GET_PERSONNEL_SYSTEM(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RFN_Get_CutOff_Shift_Date(poParam As SIAPP_PUB_DTO.ParameterFuncDTO) As String Implements ISIAPP_PUB_DTOService.RFN_Get_CutOff_Shift_Date

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loRtn = loCls.RFN_Get_CutOff_Shift_Date(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

#End Region

#Region "STORED PROCEDURE"
    Public Function SP_Get_Reference_Number(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As String Implements ISIAPP_PUB_DTOService.SP_Get_Reference_Number
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loRtn = loCls.SP_Get_Reference_Number(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function SP_Get_Period(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As String Implements ISIAPP_PUB_DTOService.SP_Get_Period
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loRtn = loCls.SP_Get_Period(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function SP_Get_Transaction_Profile(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As SIAPP_PUB_DTO.SP_Get_Transaction_ProfileDTO Implements ISIAPP_PUB_DTOService.SP_Get_Transaction_Profile
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As SP_Get_Transaction_ProfileDTO

        Try
            loRtn = loCls.SP_Get_Transaction_Profile(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_Principal_Validation(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As String Implements ISIAPP_PUB_DTOService.RSP_Principal_Validation
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loRtn = loCls.RSP_Principal_Validation(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_Reset_Festival_Settlement(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As Boolean Implements ISIAPP_PUB_DTOService.RSP_Reset_Festival_Settlement
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.RSP_Reset_Festival_Settlement(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_Set_Festival_Settlement(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As Boolean Implements ISIAPP_PUB_DTOService.RSP_Set_Festival_Settlement
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.RSP_Set_Festival_Settlement(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub RSP_Payroll_Update_Master(poParam As SIAPP_PUB_DTO.ParameterSPDTO) Implements ISIAPP_PUB_DTOService.RSP_Payroll_Update_Master
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls

        Try
            loCls.RSP_Payroll_Update_Master(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub RSP_Create_Rapel_Result(poParam As SIAPP_PUB_DTO.ParameterSPDTO) Implements ISIAPP_PUB_DTOService.RSP_Create_Rapel_Result
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls

        Try
            loCls.RSP_Create_Rapel_Result(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function RSP_ATTENDANCE_PROCESS(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As Boolean Implements ISIAPP_PUB_DTOService.RSP_ATTENDANCE_PROCESS
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.RSP_ATTENDANCE_PROCESS(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
#End Region

    Public Function GeneratePeriod(poParam As SIAPP_PUB_DTO.GeneratePeriodDTO) As System.Collections.Generic.List(Of SIAPP_PUB_DTO.GeneratePeriodDTO) Implements ISIAPP_PUB_DTOService.GeneratePeriod
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As List(Of GeneratePeriodDTO)

        Try
            loRtn = loCls.GeneratePeriod(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getDescLabelGroup(poParam As SIAPP_PUB_DTO.ParameterDTO) As String Implements ISIAPP_PUB_DTOService.getDescLabelGroup

    End Function

    Public Function getDescLabelProcess(poParam As SIAPP_PUB_DTO.ParameterDTO) As String Implements ISIAPP_PUB_DTOService.getDescLabelProcess

    End Function

    Public Function RSP_Loan_Check_Syntax(pcComp As String, pcFormula As String) As SIAPP_PUB_DTO.RSP_Loan_Check_SyntaxDTO Implements ISIAPP_PUB_DTOService.RSP_Loan_Check_Syntax

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As RSP_Loan_Check_SyntaxDTO

        Try
            loRtn = loCls.RSP_Loan_Check_Syntax(pcComp, pcFormula)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub RSP_UPLOAD_PERSONNEL(poParam As SIAPP_PUB_DTO.ParameterSPDTO) Implements ISIAPP_PUB_DTOService.RSP_UPLOAD_PERSONNEL


        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls

        Try
            loCls.RSP_UPLOAD_PERSONNEL(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Sub RSP_PNM_ORG_STRUCTURE_ADD(poParam As SIAPP_PUB_DTO.ParameterSPDTO) Implements ISIAPP_PUB_DTOService.RSP_PNM_ORG_STRUCTURE_ADD

    End Sub

    Public Sub RSP_PNM_ORG_STRUCTURE_DELETE(poParam As SIAPP_PUB_DTO.ParameterSPDTO) Implements ISIAPP_PUB_DTOService.RSP_PNM_ORG_STRUCTURE_DELETE

    End Sub

    Public Sub RSP_PNM_ORG_STRUCTURE_EDIT(poParam As SIAPP_PUB_DTO.ParameterSPDTO) Implements ISIAPP_PUB_DTOService.RSP_PNM_ORG_STRUCTURE_EDIT

    End Sub

    Public Sub RSP_PNM_ORG_STRUCTURE_FIRST_TIME(poParam As SIAPP_PUB_DTO.ParameterSPDTO) Implements ISIAPP_PUB_DTOService.RSP_PNM_ORG_STRUCTURE_FIRST_TIME

    End Sub

    Public Function RSP_MCM_CHECK_SYNTAX(pcCompanyId As String, pcFormula As String) As SIAPP_PUB_DTO.RSP_Medical_Check_SyntaxDTO Implements ISIAPP_PUB_DTOService.RSP_MCM_CHECK_SYNTAX

        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As RSP_Medical_Check_SyntaxDTO

        Try
            loRtn = loCls.RSP_MCM_CHECK_SYNTAX(pcCompanyId, pcFormula)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RSP_GET_EMPLOYEE_ID(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As String Implements ISIAPP_PUB_DTOService.RSP_GET_EMPLOYEE_ID
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loRtn = loCls.RSP_GET_EMPLOYEE_ID(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function RSP_CHECK_MTD_PROCESS(poParam As SIAPP_PUB_DTO.ParameterSPDTO) As String Implements ISIAPP_PUB_DTOService.RSP_CHECK_MTD_PROCESS
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loRtn = loCls.RSP_Check_MTD_Process(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub RSP_TRANSACTION_VALIDATION(poParam As SIAPP_PUB_DTO.ParameterSPDTO) Implements ISIAPP_PUB_DTOService.RSP_TRANSACTION_VALIDATION
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loCls.RSP_TRANSACTION_VALIDATION(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub RSP_CHECK_LETTER_SYNTAX(poParam As SIAPP_PUB_DTO.ParameterSPDTO) Implements ISIAPP_PUB_DTOService.RSP_CHECK_LETTER_SYNTAX
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls

        Try
            loCls.RSP_CHECK_LETTER_SYNTAX(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub RSP_VALIDATE_PN_CANCEL_TRANSACTION(poParam As SIAPP_PUB_DTO.ParameterDTO) Implements ISIAPP_PUB_DTOService.RSP_VALIDATE_PN_CANCEL_TRANSACTION
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As String

        Try
            loCls.RSP_VALIDATE_PN_CANCEL_TRANSACTION(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getLookUpAttendanceSettingParameter(pcCompId As String) As SIAPP_PUB_DTO.LookUpAttendanceSettingParameterDTO Implements ISIAPP_PUB_DTOService.getLookUpAttendanceSettingParameter
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As New LookUpAttendanceSettingParameterDTO

        Try
            loRtn = loCls.getLookUpAttendanceSettingParameter(pcCompId)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RFT_GET_PERIOD_INDEX_INFO(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.RFT_GET_PERIOD_INDEX_INFO_DTO Implements ISIAPP_PUB_DTOService.RFT_GET_PERIOD_INDEX_INFO
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As New RFT_GET_PERIOD_INDEX_INFO_DTO

        Try
            loRtn = loCls.RFT_GET_PERIOD_INDEX_INFO(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GET_LAST_ATT_PYR_DATE(poParam As SIAPP_PUB_DTO.ParameterDTO) As String Implements ISIAPP_PUB_DTOService.GET_LAST_ATT_PYR_DATE
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim lcRtn As String

        Try
            lcRtn = loCls.GET_LAST_ATT_PYR_DATE(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcRtn
    End Function

    Public Sub RSP_LN_CANCEL_TRANSACTION(poParam As SIAPP_PUB_DTO.ParameterDTO) Implements ISIAPP_PUB_DTOService.RSP_LN_CANCEL_TRANSACTION
        Dim loEx As New R_Exception
        Dim loCls As New SIAPP_PUB_DTOCls

        Try
            loCls.RSP_LN_CANCEL_TRANSACTION(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GET_PY_SYSTEM_PARAM(poParam As SIAPP_PUB_DTO.ParameterDTO) As SIAPP_PUB_DTO.PYSystemParamDTO Implements ISIAPP_PUB_DTOService.GET_PY_SYSTEM_PARAM
        Dim loCls As New SIAPP_PUB_DTOCls
        Dim loRtn As New PYSystemParamDTO
        Dim loEx As New R_Exception()

        Try
            loRtn = loCls.GET_PY_SYSTEM_PARAM(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function RSP_GET_TRX_ATTACHMENT_HEADER(poParam As ParameterDTO) As SIAPP_PUB_DTOs Implements ISIAPP_PUB_DTOService.RSP_GET_TRX_ATTACHMENT_HEADER
        Dim loEx As New R_Exception
        Dim loRtn As New SIAPP_PUB_DTOs
        Dim loCls As New SIAPP_PUB_DTOCls

        Try
            loRtn = loCls.RSP_GET_TRX_ATTACHMENT_HEADER(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

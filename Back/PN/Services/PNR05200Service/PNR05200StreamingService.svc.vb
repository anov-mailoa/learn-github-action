Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNR05200Back
Imports PNR05200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNR05200StreamingService" in code, svc and config file together.
Public Class PNR05200StreamingService
    Implements IPNR05200StreamingService

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNR05200StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PNR05200CLS
        Dim poParam As New PNR05200DTO
        Dim loRtnList As New List(Of PNR05200ReportDTO)
        Dim loRtnTemp As List(Of PNR05200ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim lcEmployees As String
        Dim loEmployees As New List(Of PNR05200EmployeeDTO)
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

                'CURRENT INFO
                .lPosition = R_Utility.R_GetStreamingContext("lPosition")
                .lJobTitle = R_Utility.R_GetStreamingContext("lJobTitle")
                .lJobFunction = R_Utility.R_GetStreamingContext("lJobFunction")
                .lDept = R_Utility.R_GetStreamingContext("lDept")
                .lGrade = R_Utility.R_GetStreamingContext("lGrade")
                .lSubGrade = R_Utility.R_GetStreamingContext("lSubGrade")
                .lClass = R_Utility.R_GetStreamingContext("lClass")
                .lRank = R_Utility.R_GetStreamingContext("lRank")
                .lLocation = R_Utility.R_GetStreamingContext("lLocation")
                .lEmployeeType = R_Utility.R_GetStreamingContext("lEmployeeType")
                .lTraining = R_Utility.R_GetStreamingContext("lTraining")
                .lFacilities = R_Utility.R_GetStreamingContext("lFacilities")
                .lBond = R_Utility.R_GetStreamingContext("lBond")
                .lAppreciation = R_Utility.R_GetStreamingContext("lAppreciation")
                .lPunishment = R_Utility.R_GetStreamingContext("lPunishment")
                .lMedical = R_Utility.R_GetStreamingContext("lMedical")

                'PERSONAL INFO
                .lPersonal = R_Utility.R_GetStreamingContext("lPersonal")
                .lFamily = R_Utility.R_GetStreamingContext("lFamily")
                .lEmergencyData = R_Utility.R_GetStreamingContext("lEmergencyData")
                .lFormal = R_Utility.R_GetStreamingContext("lFormal")
                .lLanguage = R_Utility.R_GetStreamingContext("lLanguage")
                .lWorkExp = R_Utility.R_GetStreamingContext("lWorkExp")
                .lLicence = R_Utility.R_GetStreamingContext("lLicence")
                .lAdditional = R_Utility.R_GetStreamingContext("lAdditional")
                .lSignature = R_Utility.R_GetStreamingContext("lSignature")
            End With

            lcEmployees = R_Utility.R_GetStreamingContext("oEmployees")
            loEmployees = R_Utility.XMLToObject(Of List(Of PNR05200EmployeeDTO))(lcEmployees)

            loRtnTemp = loCls.getReportData(poParam, loEmployees)

            loList = R_Utility.R_GetChunkData(Of PNR05200ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployeeName(pcCompId As String, pcEmpId As String) As PNR05200Back.PNR05200DTO Implements IPNR05200StreamingService.getEmployeeName
        Dim loEx As New R_Exception
        Dim loCls As New PNR05200CLS
        Dim loRtn As New PNR05200DTO

        Try
            loRtn = loCls.getEmployeeName(pcCompId, pcEmpId)

        Catch ex As Exception
            loEx.Add(ex)

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of PNR05200Back.PNR05200DTO), poPar2 As System.Collections.Generic.List(Of PNR05200Back.PNR05200GridDTO)) Implements IPNR05200StreamingService.Dummy

    End Sub

End Class

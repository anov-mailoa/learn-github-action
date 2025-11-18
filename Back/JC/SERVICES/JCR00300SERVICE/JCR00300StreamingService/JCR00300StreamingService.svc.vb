Imports R_Common
Imports R_BackEnd
Imports JCR00300Back
Imports System.ServiceModel.Channels
Imports JCR00300Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "JCR00300StreamingService" in code, svc and config file together.
Public Class JCR00300StreamingService
    Implements IJCR00300StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IJCR00300StreamingService.getData
        Dim loEx As New R_Exception
        Dim loCls As New JCR00300CLS
        Dim loRtnTemp As List(Of JCR00300StreamingDTO)
        Dim loRtn As Message
        Dim poParam As New JCR00300DTO
        Dim loList As List(Of Byte())
        Try
            With poParam
                poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                poParam.cEmployeeFilterOption = R_Utility.R_GetStreamingContext("cEmployeeFilterOption")
                poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                poParam.lIncludeAllLevel = R_Utility.R_GetStreamingContext("lIncludeAllLevel")
                poParam.cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                poParam.cCompetencyFilterOption = R_Utility.R_GetStreamingContext("cCompetencyFilterOption")
                poParam.cCompetencyCode = R_Utility.R_GetStreamingContext("cCompetencyCode")
                poParam.cCategoryCode = R_Utility.R_GetStreamingContext("cCategoryCode")
                poParam.lIncludeApplicable = R_Utility.R_GetStreamingContext("lIncludeApplicable")
                poParam.cEvaluationFilterOption = R_Utility.R_GetStreamingContext("cEvaluationFilter")
                poParam.lIsallDate = R_Utility.R_GetStreamingContext("lIsallDate")
                poParam.cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                poParam.cToDate = R_Utility.R_GetStreamingContext("cToDate")
                poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getData(poParam)
            loList = R_Utility.R_GetChunkData(Of JCR00300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of JCR00300Back.JCR00300DTO)) Implements IJCR00300StreamingService.Dummy

    End Sub

    Public Function GetDataCompetency() As System.ServiceModel.Channels.Message Implements IJCR00300StreamingService.GetDataCompetency
        Dim loRtn As New List(Of JCR00300StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New JCR00300CLS
        Dim loEx As New R_Exception
        Dim poParam As New JCR00300DTO
        Dim loList As List(Of Byte())

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cCatCompetencyCode = R_Utility.R_GetStreamingContext("cCatCompetencyCode")
            poParam.lisAllCompetency = R_Utility.R_GetStreamingContext("lisAllCompetency")

            loRtn = loCls.GetDataCompetency(poParam)
            loList = R_Utility.R_GetChunkData(Of JCR00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDataCompetency")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function GetDataGrid() As System.ServiceModel.Channels.Message Implements IJCR00300StreamingService.GetDataGrid
        Dim loRtn As New List(Of JCR00300StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New JCR00300CLS
        Dim loEx As New R_Exception
        Dim poParam As New JCR00300DTO
        Dim loList As List(Of Byte())

        Try
            With poParam
                poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                poParam.cEvaluationType = R_Utility.R_GetStreamingContext("cEvaluationType")
                poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                poParam.lIncludeAllLevel = R_Utility.R_GetStreamingContext("lIncludeAllLevel")
            End With

            loRtn = loCls.GetDataGrid(poParam)
            loList = R_Utility.R_GetChunkData(Of JCR00300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDataGrid")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function
End Class

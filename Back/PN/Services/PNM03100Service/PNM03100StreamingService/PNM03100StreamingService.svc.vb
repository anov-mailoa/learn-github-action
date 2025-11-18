' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM03100StreamingService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports PNM03100Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class PNM03100StreamingService
    Implements IPNM03100StreamingService

    Public Function getTreeView() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getTreeView
        Dim loRtnTemp As List(Of PNM03100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try

            poParam.cCreateBy = R_Utility.R_GetStreamingContext("cCreateBy")
            poParam.cUpdateBy = R_Utility.R_GetStreamingContext("cUpdateBy")
            poParam.dCreateDate = R_Utility.R_GetStreamingContext("dCreateDate")
            poParam.dUpdateDate = R_Utility.R_GetStreamingContext("dUpdateDate")
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.getTreeView(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "TreeView")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCopyFrom() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getCopyFrom
        Dim loRtnTemp As List(Of PNM03100CopyFromStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100CopyFromCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100CopyFromDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .cVarParameter = R_Utility.R_GetStreamingContext("cVarParameter")
            End With

            loRtnTemp = loCls.getCopyFrom(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100CopyFromStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "CopyFrom")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCompetencyMultiple() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getCompetencyMultiple
        Dim loRtnTemp As List(Of PNM03100MultipleStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100MultipleCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100MultipleDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")

            loRtnTemp = loCls.getCompetencyMultiple(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100MultipleStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCompetencyMultiple")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTrainingMultiple() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getTrainingMultiple
        Dim loRtnTemp As List(Of PNM03100MultipleStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100MultipleCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100MultipleDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")

            loRtnTemp = loCls.getTrainingMultiple(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100MultipleStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTrainingMultiple")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbDepartment() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getCmbDepartment
        Dim loRtnTemp As New List(Of PNM03100ComboDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getCmbDepartment(poParam)

            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbDepartment")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getCmbGrade() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getCmbGrade
        Dim loRtnTemp As New List(Of PNM03100ComboDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO


        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtnTemp = loCls.getCmbGrade(poParam)

            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbGrade")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getCmbLocation() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getCmbLocation
        Dim loRtnTemp As New List(Of PNM03100ComboDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getCmbLocation(poParam)

            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbLocation")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getCmbParentPositon() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getCmbParentPositon
        Dim loRtnTemp As New List(Of PNM03100ComboDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getCmbParentPositon(poParam)

            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbParentPositon")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getCmbReportTo() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getCmbReportTo
        Dim loRtnTemp As New List(Of PNM03100ComboDTO)

        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtnTemp = loCls.getCmbReportTo(poParam)

            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbReportTo")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getTrainingCompetencies() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getTrainingCompetencies
        Dim loRtnTemp As List(Of PNM03100MultipleStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100MultipleCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100MultipleDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            poParam.cCompetencyCode = R_Utility.R_GetStreamingContext("cCompetencyCode")

            loRtnTemp = loCls.getTrainingCompetencies(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100MultipleStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTrainingCompetencies")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParPNM03100Streaming As System.Collections.Generic.List(Of PNM03100Back.PNM03100TreeDTO), poParPNM03100Multiple As System.Collections.Generic.List(Of PNM03100Back.PNM03100MultipleDTO)) Implements IPNM03100StreamingService.Dummy

    End Sub

    Public Function getSearchPosition() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.getSearchPosition
        Dim loRtnTemp As List(Of PNM03100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cSearchType = R_Utility.R_GetStreamingContext("cSearchType")
                .cSearchValue = R_Utility.R_GetStreamingContext("cSearchValue")
            End With

            loRtnTemp = loCls.getSearchPosition(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSearchPosition")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function showEmployee() As System.ServiceModel.Channels.Message Implements IPNM03100StreamingService.showEmployee
        Dim loRtnTemp As List(Of PNM03100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            End With

            loRtnTemp = loCls.showEmployee(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "showEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

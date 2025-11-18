Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYM20000COMMON
Imports PYM20000BACK

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM20000StreamingService" in code, svc and config file together.
Public Class PYM20000StreamingService
    Implements IPYM20000StreamingService

    Public Function AllEmailProcess() As System.ServiceModel.Channels.Message Implements IPYM20000StreamingService.AllEmailProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYM20000Cls
        Dim loParam As New PYM20000DTO
        Dim loRtnTemp As List(Of PYM20000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSED_EMAIL = R_Utility.R_GetStreamingContext("CUSED_EMAIL")
            End With

            loRtnTemp = loCls.AllEmailProcess(loParam)

            loList = R_Utility.R_GetChunkData(Of PYM20000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "AllEmailProcess")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEmployeeList() As System.ServiceModel.Channels.Message Implements IPYM20000StreamingService.GetEmployeeList
        Dim loEx As New R_Exception
        Dim loCls As New PYM20000Cls
        Dim loParam As New PYM20000DTO
        Dim loRtnTemp As List(Of PYM20000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.GetEmployeeList(loParam)

            loList = R_Utility.R_GetChunkData(Of PYM20000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEmployeeSearchList() As System.ServiceModel.Channels.Message Implements IPYM20000StreamingService.GetEmployeeSearchList
        Dim loEx As New R_Exception
        Dim loCls As New PYM20000Cls
        Dim loParam As New PYM20000DTO
        Dim loRtnTemp As List(Of PYM20000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTYPE_PARAM = R_Utility.R_GetStreamingContext("CTYPE_PARAM")
                .CFROM = R_Utility.R_GetStreamingContext("CFROM")
                .CTO = R_Utility.R_GetStreamingContext("CTO")
            End With

            loRtnTemp = loCls.GetEmployeeSearchList(loParam)

            loList = R_Utility.R_GetChunkData(Of PYM20000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetEmployeeSearchList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLookUpClassified() As System.ServiceModel.Channels.Message Implements IPYM20000StreamingService.GetLookUpClassified
        Dim loEx As New R_Exception
        Dim loCls As New PYM20000Cls
        Dim loParam As New PYM20000DTO
        Dim loRtnTemp As List(Of PYM20000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.GetLookUpClassified(loParam)

            loList = R_Utility.R_GetChunkData(Of PYM20000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLookUpClassified")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLookUpEmployee() As System.ServiceModel.Channels.Message Implements IPYM20000StreamingService.GetLookUpEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYM20000Cls
        Dim loParam As New PYM20000DTO
        Dim loRtnTemp As List(Of PYM20000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.GetLookUpEmployee(loParam)

            loList = R_Utility.R_GetChunkData(Of PYM20000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLookUpEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbClassified() As System.ServiceModel.Channels.Message Implements IPYM20000StreamingService.GetCmbClassified
        Dim loEx As New R_Exception
        Dim loCls As New PYM20000Cls
        Dim loParam As New PYM20000DTO
        Dim loRtnTemp As List(Of PYM20000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.GetCmbClassified(loParam)

            loList = R_Utility.R_GetChunkData(Of PYM20000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbClassified")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

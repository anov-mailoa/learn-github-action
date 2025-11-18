Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports GSM00500Common
Imports GSM00500Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM00500StreamingService" in code, svc and config file together.
Public Class GSM00500StreamingService
    Implements IGSM00500StreamingService

    Public Function getListOfDepartments() As System.ServiceModel.Channels.Message Implements IGSM00500StreamingService.getListOfDepartments
        Dim loException As New R_Exception
        Dim loCls As New GSM00500Cls
        Dim loRtnTemp As List(Of GSM00500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00500DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lActiveFlag = R_Utility.R_GetStreamingContext("lActive")
            End With

            loRtnTemp = loCls.getListOfDepartments(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListOfDepartments")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbCenterCode() As System.ServiceModel.Channels.Message Implements IGSM00500StreamingService.getCmbCenterCode
        Dim loException As New R_Exception
        Dim loCls As New GSM00500Cls
        Dim loRtnTemp As List(Of GSM00500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00500DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getCmbCenterCode(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCenterCode")

            loList = R_Utility.R_GetChunkData(Of GSM00500StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCenterCode")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListOfUser() As System.ServiceModel.Channels.Message Implements IGSM00500StreamingService.getListOfUser
        Dim loException As New R_Exception
        Dim loCls As New GSM00510Cls
        Dim loRtnTemp As List(Of GSM00510StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00510DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            End With

            loRtnTemp = loCls.getListOfUser(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00510StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListOfUser")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListOfUserDepartment() As System.ServiceModel.Channels.Message Implements IGSM00500StreamingService.getListOfUserDepartment
        Dim loException As New R_Exception
        Dim loCls As New GSM00510Cls
        Dim loRtnTemp As List(Of GSM00510StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00510DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getListOfUserDepartment(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00510StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListOfUserDepartment")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbUserId() As System.ServiceModel.Channels.Message Implements IGSM00500StreamingService.getCmbUserId
        Dim loException As New R_Exception
        Dim loCls As New GSM00510Cls
        Dim loRtnTemp As List(Of GSM00510StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim lcCompId As String
        Dim loList As List(Of Byte())

        Try

            lcCompId = R_Utility.R_GetStreamingContext("cCompanyId")


            loRtnTemp = loCls.getCmbUserId(lcCompId)
            loList = R_Utility.R_GetChunkData(Of GSM00510StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbUserId")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListUserCopyDepartment() As System.ServiceModel.Channels.Message Implements IGSM00500StreamingService.getListUserCopyDepartment
        Dim loException As New R_Exception
        Dim loCls As New GSM00510Cls
        Dim loRtnTemp As List(Of GSM00511StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00511DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cFromDeptCode = R_Utility.R_GetStreamingContext("cFromDeptCode")
            End With

            loRtnTemp = loCls.getListUserCopyDepartment(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00511StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListUserCopyDepartment")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbFromDept() As System.ServiceModel.Channels.Message Implements IGSM00500StreamingService.getCmbFromDept
        Dim loException As New R_Exception
        Dim loCls As New GSM00510Cls
        Dim loRtnTemp As List(Of GSM00511StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00511DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            End With

            loRtnTemp = loCls.getCmbFromDept(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00511StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbFromDept")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListOfUserMultiple() As System.ServiceModel.Channels.Message Implements IGSM00500StreamingService.getListOfUserMultiple
        Dim loException As New R_Exception
        Dim loCls As New GSM00510Cls
        Dim loRtnTemp As List(Of GSM00511StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM00511DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            End With

            loRtnTemp = loCls.getListOfUserMultiple(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00511StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListOfUserMultiple")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDeptDB() As System.ServiceModel.Channels.Message Implements IGSM00500StreamingService.getDeptDB
        Dim loException As New R_Exception
        Dim loCls As New GSM00500Cls
        Dim loRtnTemp As List(Of GSM00500ExcelDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As List(Of GSM00500ExcelDTO)
        Dim loParamObj As String
        Dim loList As List(Of Byte())

        Try
            loParamObj = R_Utility.R_GetStreamingContext("oList")

            loParam = R_Utility.XMLToObject(Of List(Of GSM00500ExcelDTO))(loParamObj)


            loRtnTemp = loCls.getDeptDB(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM00500ExcelDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDeptDB")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of GSM00500Back.GSM00500TreeDTO), poPar2 As System.Collections.Generic.List(Of GSM00500Back.GSM00511DTO)) Implements IGSM00500StreamingService.Dummy

    End Sub
End Class

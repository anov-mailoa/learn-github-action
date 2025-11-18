Imports R_Common
Imports R_BackEnd
Imports GSM21000Back
Imports GSM21000Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM21000StreamingService" in code, svc and config file together.
Public Class GSM21000StreamingService
    Implements IGSM21000StreamingService

    Public Function GetClassificationDetail() As System.ServiceModel.Channels.Message Implements IGSM21000StreamingService.GetClassificationDetail
        Dim loException As New R_Exception
        Dim loCls As New GSM21000Cls
        Dim loRtnTemp As List(Of GSM21000DTOnon)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            Dim loParam As ParamDTO = New ParamDTO With {.CCLASS_APPLICATION = R_Utility.R_GetStreamingContext("CCLASS_APPLICATION"),
                                                         .CCLASS_ID = R_Utility.R_GetStreamingContext("CCLASS_ID")}

            loRtnTemp = loCls.GetClassificationDetail(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM21000DTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetClassificationDetail")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetClassificationHeader() As System.ServiceModel.Channels.Message Implements IGSM21000StreamingService.GetClassificationHeader
        Dim loException As New R_Exception
        Dim loCls As New GSM21000Cls
        Dim loRtnTemp As List(Of GSM21000DTOnon)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            loRtnTemp = loCls.GetClassificationHeader()
            loList = R_Utility.R_GetChunkData(Of GSM21000DTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetClassificationHeader")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetClassificationHDChild() As System.ServiceModel.Channels.Message Implements IGSM21000StreamingService.GetClassificationHDChild
        Dim loException As New R_Exception
        Dim loCls As New GSM21000Cls
        Dim loRtnTemp As List(Of GSM21000DTOnon)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            Dim loParam As ParamDTO = New ParamDTO With {.HD_CCLASS_APPLICATION = R_Utility.R_GetStreamingContext("CCLASS_APPLICATION"),
                                                         .HD_CCLASS_ID = R_Utility.R_GetStreamingContext("CCLASS_ID")}

            loRtnTemp = loCls.GetClassificationHDChild(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM21000DTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetClassificationHDChild")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTranslate() As System.ServiceModel.Channels.Message Implements IGSM21000StreamingService.GetTranslate
        Dim loException As New R_Exception
        Dim loCls As New GSM21000Cls
        Dim loRtnTemp As List(Of GSM21000DTOnon)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            Dim loParam As ParamDTO = New ParamDTO With {.CCLASS_APPLICATION = R_Utility.R_GetStreamingContext("CCLASS_APPLICATION"),
                                                         .CCLASS_ID = R_Utility.R_GetStreamingContext("CCLASS_ID"),
                                                         .CLANGUAGE = R_Utility.R_GetStreamingContext("CLANGUAGE")}

            loRtnTemp = loCls.GetTranslate(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM21000DTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTranslate")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCompanyAssignment() As System.ServiceModel.Channels.Message Implements IGSM21000StreamingService.GetCompanyAssignment
        Dim loException As New R_Exception
        Dim loCls As New GSM21000Cls
        Dim loRtnTemp As List(Of GSM21010DTOnon)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            Dim loParam As ParamDTO = New ParamDTO With {.CCLASS_APPLICATION = R_Utility.R_GetStreamingContext("CCLASS_APPLICATION"),
                                                         .CCLASS_ID = R_Utility.R_GetStreamingContext("CCLASS_ID"),
                                                         .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")}

            loRtnTemp = loCls.GetCompanyAssignment(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM21010DTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCompanyAssignment")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCmbCompany() As System.ServiceModel.Channels.Message Implements IGSM21000StreamingService.GetCmbCompany
        Dim loException As New R_Exception
        Dim loCls As New GSM21000Cls
        Dim loRtnTemp As List(Of CmbDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try
            loRtnTemp = loCls.GetCmbCompany()
            loList = R_Utility.R_GetChunkData(Of CmbDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCmbCompany")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

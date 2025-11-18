Imports R_Common
Imports ESM01200Back
Imports ESM01200Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "esm01200PRStreamingService" in code, svc and config file together.
Public Class ESM01200PermisionStreamingService
    Implements IESM01200PermisionStreamingService

    Public Function GetList() As System.ServiceModel.Channels.Message Implements IESM01200PermisionStreamingService.GetList
        Dim loException As New R_Exception
        Dim loCls As New ESM01200PRCLS
        Dim loRtnTemp As List(Of ESM01200PermisionStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200PRParamDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .LHISTORY = R_Utility.R_GetStreamingContext("LHISTORY")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
                .ITRANSACTION_TYPE = R_Utility.R_GetStreamingContext("ITRANSACTION_TYPE")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CTRANSACTION_STATUS = R_Utility.R_GetStreamingContext("CTRANSACTION_STATUS")
            End With

            loRtnTemp = loCls.GetList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01200PermisionStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetList2() As System.ServiceModel.Channels.Message Implements IESM01200PermisionStreamingService.GetList2
        Dim loException As New R_Exception
        Dim loCls As New ESM01200ODCLS
        Dim loRtnTemp As List(Of ESM01200PermisionStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200ODParamDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .LHISTORY = R_Utility.R_GetStreamingContext("LHISTORY")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
                .ITRANSACTION_TYPE = R_Utility.R_GetStreamingContext("ITRANSACTION_TYPE")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .CTRANSACTION_STATUS = R_Utility.R_GetStreamingContext("CTRANSACTION_STATUS")
            End With

            loRtnTemp = loCls.GetList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01200PermisionStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetList2")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getcmbReason() As System.ServiceModel.Channels.Message Implements IESM01200PermisionStreamingService.getcmbReason
        Dim loException As New R_Exception
        Dim loCls As New ESM01200PRCLS

        Dim loRtnTemp As List(Of ESM01200PermisionStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200PRParamDTO
        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .ITRANSACTION_TYPE = R_Utility.R_GetStreamingContext("ITRANSACTION_TYPE")

            End With
            loRtnTemp = loCls.getcmbReason(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ESM01200PermisionStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getcmbReason")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ValidateStart() As System.ServiceModel.Channels.Message Implements IESM01200PermisionStreamingService.ValidateStart
        Dim loException As New R_Exception
        Dim loCls As New ESM01200PRCLS
        Dim loList As List(Of Byte())
        Dim loRtnTemp As List(Of ESM01200PermisionStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESM01200PRParamDTO
        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CSTR_DATE = R_Utility.R_GetStreamingContext("CSTR_DATE")
                .CEND_DATE = R_Utility.R_GetStreamingContext("CEND_DATE")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")

            End With
            loRtnTemp = loCls.ValidateStart(loParam)

            loList = R_Utility.R_GetChunkData(Of ESM01200PermisionStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "ValidateStart")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

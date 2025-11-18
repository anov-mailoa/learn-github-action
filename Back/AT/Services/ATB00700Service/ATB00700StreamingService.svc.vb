' NOTE: You can use the "Rename" command on the context menu to change the class name "ATB00700StreamingService" in code, svc and config file together.
Imports System.ServiceModel.Channels
Imports ATB00700Back
Imports R_BackEnd
Imports R_Common
Imports ATB00700Common
Public Class ATB00700StreamingService
    Implements IATB00700StreamingService

    Public Function getEmployeeValidation() As System.ServiceModel.Channels.Message Implements IATB00700StreamingService.getEmployeeValidation
        Dim loException As New R_Exception
        Dim loCls As New ATB00700Cls
        Dim loRtn As New List(Of ATB00700CommonDTO)
        Dim loRtnMessage As Message
        Dim loParam As New ATB00700DTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
            loParam.CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
            loParam.CLIST_EMPLOYEE = R_Utility.R_GetStreamingContext("CLIST_EMPLOYEE")
            loParam.LALL_EMPLOYEE = R_Utility.R_GetStreamingContext("LALL_EMPLOYEE")

            loRtn = loCls.getEmployeeValidation(loParam)
            loList = R_Utility.R_GetChunkData(Of ATB00700CommonDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployeeValidation")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class

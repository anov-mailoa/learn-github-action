Imports System.ServiceModel.Channels
Imports R_Common
Imports JCR00500Back
Imports JCR00500Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "JCR00500StreamingService" in code, svc and config file together.
Public Class JCR00500StreamingService
    Implements IJCR00500StreamingService

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of JCR00500Back.JCR00500DTO)) Implements IJCR00500StreamingService.Dummy

    End Sub

    Public Function getData() As System.ServiceModel.Channels.Message Implements IJCR00500StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New JCR00500CLS
        Dim poParam As New JCR00500DTO
        Dim loRtnList As New List(Of JCR00500CommonDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam

                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cOptions = R_Utility.R_GetStreamingContext("cOptions")
                .cOptionCode = R_Utility.R_GetStreamingContext("cOptionCode")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            End With

            loRtnList = loCls.getData(poParam)

            loList = R_Utility.R_GetChunkData(Of JCR00500CommonDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDepartmentList() As System.ServiceModel.Channels.Message Implements IJCR00500StreamingService.getDepartmentList
        Dim loException As New R_Exception
        Dim loCls As New JCR00500CLS
        Dim poParam As New JCR00500DTO
        Dim loRtnList As New List(Of ComboboxDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam

                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")

            End With

            loRtnList = loCls.getDepartmentList(poParam)

            loList = R_Utility.R_GetChunkData(Of ComboboxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDepartmentList")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getPositionList() As System.ServiceModel.Channels.Message Implements IJCR00500StreamingService.getPositionList
        Dim loException As New R_Exception
        Dim loCls As New JCR00500CLS
        Dim poParam As New JCR00500DTO
        Dim loRtnList As New List(Of ComboboxDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            With poParam
                
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            End With

            loRtnList = loCls.getPositionList(poParam)

            loList = R_Utility.R_GetChunkData(Of ComboboxDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPositionList")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

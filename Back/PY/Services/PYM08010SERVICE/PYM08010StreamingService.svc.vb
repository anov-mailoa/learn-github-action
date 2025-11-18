Imports R_Common
Imports System.ServiceModel.Channels
Imports PYM08010Back
Imports PYM08010Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM08010StreamingService" in code, svc and config file together.
Public Class PYM08010StreamingService
    Implements IPYM08010StreamingService

    Public Function generateMapping() As System.ServiceModel.Channels.Message Implements IPYM08010StreamingService.generateMapping
        Dim loCls As New PYM08010CLS
        Dim loParam As New PYM08010DTO
        Dim loRtnList As New List(Of PYM08010StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try

            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CGL_ACCOUNT_CODE = R_Utility.R_GetStreamingContext("CGL_ACCOUNT_CODE")
                .IGL_SEQ = R_Utility.R_GetStreamingContext("IGL_SEQ")
                .CGROUP_CODE = R_Utility.R_GetStreamingContext("CGROUP_CODE")
            End With

            loRtnList = loCls.generateMapping(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM08010StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "generateMapping")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbCenter() As System.ServiceModel.Channels.Message Implements IPYM08010StreamingService.getCmbCenter
        Dim loCls As New PYM08010CLS
        Dim loParam As New PYM08010DTO
        Dim loRtnList As New List(Of PYM08010StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try

            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnList = loCls.getCmbCenter(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM08010StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCenter")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbGrupGaji() As System.ServiceModel.Channels.Message Implements IPYM08010StreamingService.getCmbGrupGaji
        Dim loCls As New PYM08010CLS
        Dim loParam As New PYM08010DTO
        Dim loRtnList As New List(Of PYM08010StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try

            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnList = loCls.getCmbGrupGaji(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM08010StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbGrupGaji")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListMapping() As System.ServiceModel.Channels.Message Implements IPYM08010StreamingService.getListMapping
        Dim loCls As New PYM08010CLS
        Dim loParam As New PYM08010DTO
        Dim loRtnList As New List(Of PYM08010StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try

            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnList = loCls.getListMapping(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM08010StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListMapping")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookUpGLAccount() As System.ServiceModel.Channels.Message Implements IPYM08010StreamingService.getLookUpGLAccount
        Dim loCls As New PYM08010CLS
        Dim loParam As New PYM08010DTO
        Dim loRtnList As New List(Of PYM08010StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try

            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnList = loCls.getLookUpGLAccount(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM08010StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookUpGLAccount")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

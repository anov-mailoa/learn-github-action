Imports R_Common
Imports R_BackEnd
Imports JCI00200Common
Imports JCI00200Back
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the class name "JCI00200StreamingService" in code, svc and config file together.
Public Class JCI00200StreamingService
    Implements IJCI00200StreamingService

    Public Function getComboBox() As System.ServiceModel.Channels.Message Implements IJCI00200StreamingService.getComboBox
        Dim loEx As New R_Exception
        Dim loCls As New JCI00200CLS
        Dim loList As List(Of Byte())
        Dim loParam As New JCI00200DTO
        Dim loRtnList As List(Of JCI00200ComboBox)
        Dim loRtn As Message

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnList = loCls.getComboBox(loParam)
            loList = R_Utility.R_GetChunkData(Of JCI00200ComboBox)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getComboBox")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getListEmployee() As System.ServiceModel.Channels.Message Implements IJCI00200StreamingService.getListEmployee
        Dim loEx As New R_Exception
        Dim loCls As New JCI00200CLS
        Dim loList As List(Of Byte())
        Dim loParam As New JCI00200DTO
        Dim loRtnList As List(Of JCI00200StreamingDTO)
        Dim loRtn As Message

        Try

            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnList = loCls.getListEmployee(loParam)
            loList = R_Utility.R_GetChunkData(Of JCI00200StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLookup() As System.ServiceModel.Channels.Message Implements IJCI00200StreamingService.getLookup
        Dim loEx As New R_Exception
        Dim loCls As New JCI00200CLS
        Dim loList As List(Of Byte())
        Dim loParam As New JCI00200DTO
        Dim loRtnList As List(Of JCI00200LookupDTO)
        Dim loRtn As Message

        Try

            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnList = loCls.getLookup(loParam)
            loList = R_Utility.R_GetChunkData(Of JCI00200LookupDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLookup")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getListTransaction() As System.ServiceModel.Channels.Message Implements IJCI00200StreamingService.getListTransaction
        Dim loEx As New R_Exception
        Dim loCls As New JCI00200CLS
        Dim loList As List(Of Byte())
        Dim loParam As New JCI00200DTO
        Dim loRtnList As List(Of JCI00200StreamingGridDTO)
        Dim loRtn As Message

        Try

            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            End With

            loRtnList = loCls.getListTransaction(loParam)
            loList = R_Utility.R_GetChunkData(Of JCI00200StreamingGridDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListTraction")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLookupDes(poParam As JCI00200Back.JCI00200DTO) As JCI00200Back.JCI00200DTO Implements IJCI00200StreamingService.getLookupDes
        Dim loEx As New R_Exception
        Dim loCls As New JCI00200CLS
        Dim loRtn As JCI00200DTO
        Dim loRtnTemp1 As List(Of JCI00200LookupDTO)
        Dim loRtn1 As JCI00200LookupDTO

        Try


            loRtnTemp1 = loCls.getLookup(poParam)

            Dim loQuery = From A In loRtnTemp1
                            Where A.CEMPLOYEE_ID.Trim = poParam.CEMPLOYEE_ID.Trim
                            Select A

            loRtn1 = loQuery.FirstOrDefault

            loRtn.CDEPT_CODE_HIERARCHY = loRtn1.CDEPT_CODE_HIERARCHY
            loRtn.CDEPT_NAME = loRtn1.CDEPT_NAME
            loRtn.CEMPLOYEE_ID = loRtn1.CEMPLOYEE_ID
            loRtn.CEMPLOYEE_NAME = loRtn1.CEMPLOYEE_NAME
            loRtn.CJOB_TITLE = loRtn1.CJOB_TITLE
            loRtn.CJOB_TITLE_NAME = loRtn1.CJOB_TITLE_NAME
            loRtn.CLOCATION_CODE = loRtn1.CLOCATION_CODE
            loRtn.CLOCATION_DESCRIPTION = loRtn1.CLOCATION_DESCRIPTION
            loRtn.CPOSITION_CODE = loRtn1.CPOSITION_CODE
            loRtn.CPOSITION_DESCRIPTION = loRtn1.CPOSITION_DESCRIPTION

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

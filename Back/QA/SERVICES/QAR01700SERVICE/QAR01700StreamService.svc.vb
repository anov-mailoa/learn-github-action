Imports R_BackEnd
Imports R_Common
Imports QAR01700Back
Imports QAR01700Common
Imports System.Data.Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01700StreamingService" in code, svc and config file together.
Public Class QAR01700StreamService
    Implements IQAR01700StreamService


    Public Function QAR01700GetDat() As System.ServiceModel.Channels.Message Implements IQAR01700StreamService.QAR01700GetDat
        Dim loException As New R_Exception
        Dim loCls As New QAR01700Cls
        Dim loRtnTemp As List(Of QAR01700StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim poParameter As New QAR01700DTO

        Try
            poParameter.CCOMPANY_ID = R_Utility.R_GetStreamingContext("pCompanyId")
            poParameter.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("pLanguageId")
            poParameter.DEPT_NAME = R_Utility.R_GetStreamingContext("pDeptName")
            poParameter.LINCLUDE_OBSOLETEDOCUMENT = R_Utility.R_GetStreamingContext("pIncObDoc")
            loRtnTemp = loCls.QAR01700GetDat(poParameter)
            loList = R_Utility.R_GetChunkData(Of QAR01700StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "QAR01700GetDat")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function QAR01700GetRepDat() As System.ServiceModel.Channels.Message Implements IQAR01700StreamService.QAR01700GetRepDat
        Dim loException As New R_Exception
        Dim loCls As New QAR01700Cls
        Dim loRtnTemp As List(Of QAR01700StreamRepDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Dim poParameter As New QAR01700DTO

        Try
            poParameter.CCOMPANY_ID = R_Utility.R_GetStreamingContext("pCompanyId")
            poParameter.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("pLanguageId")
            poParameter.DEPT_NAME = R_Utility.R_GetStreamingContext("pDeptName")
            poParameter.LINCLUDE_OBSOLETEDOCUMENT = R_Utility.R_GetStreamingContext("pIncObDoc")
            poParameter.LINCLUDE_DOCLEVEL2 = R_Utility.R_GetStreamingContext("pIncDocLev2")
            poParameter.CDOC_NOLIST = R_Utility.R_GetStreamingContext("pDocNoList")
            loRtnTemp = loCls.QAR01700GetRepDat(poParameter)
            loList = R_Utility.R_GetChunkData(Of QAR01700StreamRepDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "QAR01700GetRepDat")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class

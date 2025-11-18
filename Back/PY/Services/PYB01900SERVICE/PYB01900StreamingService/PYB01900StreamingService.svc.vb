Imports R_Common
Imports R_BackEnd
Imports PYB01900Back
Imports PYB01900Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB01900StreamingService" in code, svc and config file together.
Public Class PYB01900StreamingService
    Implements IPYB01900StreamingService

    Public Function GetYear() As System.ServiceModel.Channels.Message Implements IPYB01900StreamingService.GetYear
        Dim loEx As New R_Exception
        Dim loCls As New PYB01900Cls
        Dim loRtnTemp As List(Of PYB01900StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB01900DTO

        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtnTemp = loCls.GetYear(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB01900StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetYear")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RFT_GET_UPLOAD_SPT_A1_EMPLOYEES() As System.ServiceModel.Channels.Message Implements IPYB01900StreamingService.RFT_GET_UPLOAD_SPT_A1_EMPLOYEES
        Dim loEx As New R_Exception
        Dim loCls As New PYB01900Cls
        Dim loRtnTemp As List(Of PYB01900StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB01900DTO

        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            loParam.CYEAR = R_Utility.R_GetStreamingContext("CYEAR")

            loRtnTemp = loCls.RFT_GET_UPLOAD_SPT_A1_EMPLOYEES(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB01900StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_UPLOAD_SPT_A1_EMPLOYEES")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RFT_GET_EMP_SPT_A1_LIST() As System.ServiceModel.Channels.Message Implements IPYB01900StreamingService.RFT_GET_EMP_SPT_A1_LIST
        Dim loEx As New R_Exception
        Dim loCls As New PYB01900Cls
        Dim loRtnTemp As List(Of PYB01900StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB01900DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CYEAR = R_Utility.R_GetStreamingContext("CYEAR")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            End With

            loRtnTemp = loCls.RFT_GET_EMP_SPT_A1_LIST(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB01900StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_GET_EMP_SPT_A1_LIST")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function RSP_PYB01900_VALIDATE_SPT_UPLOAD_FILES() As System.ServiceModel.Channels.Message Implements IPYB01900StreamingService.RSP_PYB01900_VALIDATE_SPT_UPLOAD_FILES
        Dim loEx As New R_Exception
        Dim loCls As New PYB01900Cls
        Dim loRtnTemp As List(Of PYB01900SPTDTO)
        Dim loRtn As Message
        Dim loParam As New List(Of PYB01900SPTDTO)
        Dim year, validated As String

        Try
            loParam = R_Utility.XMLToObject(Of List(Of PYB01900SPTDTO))(R_Utility.R_GetStreamingContext("FILES"))
            year = R_Utility.R_GetStreamingContext("year")
            validated = R_Utility.R_GetStreamingContext("validated")

            loRtnTemp = loCls.RSP_PYB01900_VALIDATE_SPT_UPLOAD_FILES(loParam, year, validated)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB01900SPTDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_PYB01900_VALIDATE_SPT_UPLOAD_FILES")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub RSP_PYB01900_PUBLISH_AND_SEND_SPT() Implements IPYB01900StreamingService.RSP_PYB01900_PUBLISH_AND_SEND_SPT
        Dim loEx As New R_Exception
        Dim loCls As New PYB01900Cls
        Dim loParam As New List(Of PYB01900StreamingDTO)
        Dim FLAG As String

        Try
            loParam = R_Utility.XMLToObject(Of List(Of PYB01900StreamingDTO))(R_Utility.R_GetStreamingContext("EMPL"))
            FLAG = R_Utility.R_GetStreamingContext("FLAG")

            loCls.RSP_PYB01900_PUBLISH_AND_SEND_SPT(loParam, FLAG)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function RFT_UPLOAD_SPT_EMPLOYEE_LOOKUP() As System.ServiceModel.Channels.Message Implements IPYB01900StreamingService.RFT_UPLOAD_SPT_EMPLOYEE_LOOKUP
        Dim loEx As New R_Exception
        Dim loCls As New PYB01900Cls
        Dim loRtnTemp As List(Of PYB01900StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYB01900DTO

        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            loParam.CYEAR = R_Utility.R_GetStreamingContext("CYEAR")

            loRtnTemp = loCls.RFT_UPLOAD_SPT_EMPLOYEE_LOOKUP(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB01900StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RFT_UPLOAD_SPT_EMPLOYEE_LOOKUP")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

End Class

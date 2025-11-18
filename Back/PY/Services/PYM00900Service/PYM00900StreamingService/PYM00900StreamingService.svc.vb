Imports R_Common
Imports PYM00900Back
Imports System.ServiceModel.Channels
Imports PYM00900Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00900StreamingService" in code, svc and config file together.
Public Class PYM00900StreamingService
    Implements IPYM00900StreamingService


    'HEADER
    Public Function getGridPymSalaryGroupHd() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getGridPymSalaryGroupHd
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtnTemp As List(Of PYM00900GridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .lActiveFlag = R_Utility.R_GetStreamingContext("lActiveFlag")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getGridPymSalaryGroupHd(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900GridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGridPymSalaryGroupHd")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'SALARY PROCESS TAB (NORMAL)
    Public Function getComponentSalary() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getComponentSalary
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SalaryProcessCls
        Dim loRtnTemp As List(Of PYM00900SalaryProcessGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900SalaryProcessDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getComponentSalary(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900SalaryProcessGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getComponentSalary")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'SALARY PROCESS TAB(AFTER TAX)
    Public Function getComponentSalaryAfterTax() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getComponentSalaryAfterTax
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SalaryProcessCls
        Dim loRtnTemp As List(Of PYM00900SalaryProcessGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900SalaryProcessDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getComponentSalaryAfterTax(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900SalaryProcessGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getComponentSalaryAfterTax")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'NON SALARY PROCESS (PROCESS CODE)
    Public Function getSalaryGroupDt() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getSalaryGroupDt
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900NonSalaryProcessCls
        Dim loRtnTemp As List(Of PYM00900NonSalaryProcessGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900NonSalaryProcessDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtnTemp = loCls.getSalaryGroupDt(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900NonSalaryProcessGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSalaryGroupDt")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'NON SALARY PROCESS (PROCESS COMPONENT)
    Public Function getComponentProcess() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getComponentProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900NonSalaryProcessCls
        Dim loRtnTemp As List(Of PYM00900SalaryProcessGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900NonSalaryProcessDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
            End With

            loRtnTemp = loCls.getComponentProcess(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900SalaryProcessGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getComponentProcess")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'NON SALARY PROCESS (AFTER TAX COMPONENT)
    Public Function getComponentProcessAfterTax() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getComponentProcessAfterTax
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900NonSalaryProcessCls
        Dim loRtnTemp As List(Of PYM00900SalaryProcessGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900NonSalaryProcessDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
            End With

            loRtnTemp = loCls.getComponentProcessAfterTax(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900SalaryProcessGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getComponentProcessAfterTax")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'NON SALARY PROCESS (YEAR)
    Public Function getYearPeriod() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getYearPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtnTemp As List(Of PYM00900YearGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
            End With

            loRtnTemp = loCls.getYearPeriod(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900YearGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getYearPeriod")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'NON SALARY PROCESS (PROCESS PERIOD)
    Public Function getProcessPeriod() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getProcessPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtnTemp As List(Of PYM00900ProcessPeriodGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cPeriodYear = R_Utility.R_GetStreamingContext("cPeriodYear")
            End With

            loRtnTemp = loCls.getProcessPeriod(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900ProcessPeriodGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProcessPeriod")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'NON SALARY PROCESS (INTERACE PERIOD)
    Public Function getInterfacePeriod() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getInterfacePeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900Cls
        Dim loRtnTemp As List(Of PYM00900InterfacePeriodGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cPeriodYear = R_Utility.R_GetStreamingContext("cPeriodYear")
                .cInterfaceModule = R_Utility.R_GetStreamingContext("cInterfaceModule")
            End With

            loRtnTemp = loCls.getInterfacePeriod(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900InterfacePeriodGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getInterfacePeriod")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'SEVERANCE PREDEFINED
    Public Function getSeveranceGrid() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getSeveranceGrid
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900SeveranceCls
        Dim loRtnTemp As List(Of PYM00900SalaryProcessGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900SalaryProcessDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
            End With

            loRtnTemp = loCls.getSeveranceGrid(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900SalaryProcessGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSeveranceGrid")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    'MEMBER PREDEFINED
    Public Function getListMember() As System.ServiceModel.Channels.Message Implements IPYM00900StreamingService.getListMember
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900MemberCls
        Dim loRtnTemp As List(Of PYM00900MemberGridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYM00900MemberDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnTemp = loCls.getListMember(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00900MemberGridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListMember")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar2 As System.Collections.Generic.List(Of PYM00900Back.PYM00900SalaryProcessGridDTO), poPar4 As System.Collections.Generic.List(Of PYM00900Back.PYM00900NonSalaryProcessGridDTO), poPar6 As System.Collections.Generic.List(Of PYM00900Back.PYM00900YearGridDTO), poPar8 As System.Collections.Generic.List(Of PYM00900Back.PYM00900ProcessPeriodGridDTO), poPar10 As System.Collections.Generic.List(Of PYM00900Back.PYM00900InterfacePeriodGridDTO), poPar12 As System.Collections.Generic.List(Of PYM00900Back.PYM00900MemberGridDTO)) Implements IPYM00900StreamingService.Dummy

    End Sub

End Class

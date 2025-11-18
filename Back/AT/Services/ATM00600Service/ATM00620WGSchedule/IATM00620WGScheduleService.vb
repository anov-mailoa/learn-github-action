Imports System.ServiceModel
Imports ATM00600Back
Imports R_Common
Imports R_BackEnd
Imports ATM00620Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00620WGScheduleService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00620WGScheduleService

    Inherits R_IServicebase(Of ATM00620WGScheduleDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function setStartDate(ByVal poParam As ATM00620WGScheduleDTO) As ATM00620WGScheduleDTO

    '    <OperationContract()>
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Function previewGrid(ByVal poBatchProcessPar As R_Common.R_BatchProcessPar) As List(Of ATM00620GridWGScheduleDTO)

    '    <OperationContract()>
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Function processGrid(ByVal poBatchProcessPar As R_Common.R_BatchProcessPar) As List(Of ATM00620GridWGScheduleDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPatternSeqStart(ByVal poParam As ATM00620WGScheduleDTO) As ATM00620WGScheduleDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPatternDayStart(ByVal poParam As ATM00620WGScheduleDTO) As ATM00620WGScheduleDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLastAttDate(ByRef poParam As ATM00620WGScheduleDTO) As String
     
    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataProcessSingle(ByRef poParam As ATM00620WGScheduleDTO) As ATM00620WGScheduleDTO
     
End Interface

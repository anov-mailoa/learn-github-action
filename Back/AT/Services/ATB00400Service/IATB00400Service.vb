Imports System.ServiceModel
Imports ATB00400Back
Imports R_Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00400Service" in both code and config file together.
<ServiceContract()>
Public Interface IATB00400Service
    Inherits R_IServicebase(Of ATB00400DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function setStartDate(ByVal poParam As ATB00400DTO) As ATB00400DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function previewGrid(ByVal poBatchProcessPar As R_Common.R_BatchProcessPar) As List(Of ATB00400DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function processGrid(ByVal poBatchProcessPar As R_Common.R_BatchProcessPar) As List(Of ATB00400DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPatternSeqStart(ByVal poParam As ATB00400DTO) As ATB00400DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPatternDayStart(ByVal poParam As ATB00400DTO) As ATB00400DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLastAttDate(ByRef poParam As ATB00400DTO) As String
End Interface

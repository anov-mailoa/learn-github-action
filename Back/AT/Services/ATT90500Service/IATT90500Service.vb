Imports System.ServiceModel
Imports R_Common
Imports ATT90500Back
Imports ATT90500Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90500Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT90500Service

    Inherits R_IServicebase(Of ATT90500DTO)


    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As ATT90500DTO) As ATT90500DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As ATT90500DTO) As ATT90500DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListLeaveDetail(poParam As ATT90500DTO) As ATT90500DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListLeaveDetailHistory(poParam As ATT90500DTO) As ATT90500DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub deleteHeader(poParam As ATT90500DTO)


End Interface

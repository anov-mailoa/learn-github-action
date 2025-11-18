Imports System.ServiceModel
Imports R_Common
Imports PYT01000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYT01000Service
    Inherits R_IServicebase(Of PYT01000DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub AssignEmployee(poParam As PYT01000DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RemoveEmployee(poParam As PYT01000DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub recalcDtpProcess(poParam As PYT01000DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub UpdateDTPProcess(poParam As PYT01000DTO)


End Interface

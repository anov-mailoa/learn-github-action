Imports R_BackEnd
Imports PNT06100Back
Imports System.ServiceModel
Imports R_Common


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT06100AssignmentHdServices" in both code and config file together.
<ServiceContract()>
Public Interface IPNT06100AssignmentHdServices

    Inherits R_IServicebase(Of PNT06100AssignmentHdDto)


    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As PNT06100AssignmentHdDto) As PNT06100AssignmentHdDto

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As PNT06100AssignmentHdDto) As PNT06100AssignmentHdDto

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poParam As PNT06100AssignmentHdDto) As PNT06100AssignmentHdDto

End Interface

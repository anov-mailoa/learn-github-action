Imports R_BackEnd
Imports PNT06200Back
Imports System.ServiceModel
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT06200ReturnHdServices" in both code and config file together.
<ServiceContract()>
Public Interface IPNT06200ReturnHdServices

    Inherits R_IServicebase(Of PNT06200ReturnHdDto)


    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As PNT06200ReturnHdDto) As PNT06200ReturnHdDto

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(ByVal poParam As PNT06200ReturnHdDto) As PNT06200ReturnHdDto

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Sub runRejectProcess(ByVal poParam As PNT06200ReturnHdDto)

End Interface

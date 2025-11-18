Imports System.ServiceModel
Imports R_Common
Imports PNM06200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "Ipnm06200Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM06200Service
    Inherits R_IServicebase(Of PNM06200DTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkDB(poParam As PNM06200DTO)

End Interface

Imports System.ServiceModel
Imports R_Common
Imports PNB01200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNB01200Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNB01200Service

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployee(poParam As PNB01200DTO) As PNB01200DTO

End Interface

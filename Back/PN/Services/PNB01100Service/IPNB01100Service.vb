Imports R_BackEnd
Imports R_Common
Imports PNB01100Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNB01100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNB01100Service

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployee(poParam As PNB01100DTO) As PNB01100DTO

End Interface

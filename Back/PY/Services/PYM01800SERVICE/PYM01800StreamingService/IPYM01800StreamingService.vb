Imports System.ServiceModel
Imports R_Common
Imports PYM01800Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01800StreamingService
    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy()

End Interface

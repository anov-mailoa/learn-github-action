Imports System.ServiceModel
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGST0230Service" in both code and config file together.
<ServiceContract()>
Public Interface IGST0230Service

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub sSetPasswordExpired()

End Interface

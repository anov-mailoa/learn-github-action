Imports System.ServiceModel
Imports R_Common
Imports PYB00110Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB00120HeaderService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB00120HeaderService
    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poDetail As List(Of PYB00100HeaderDTO))

End Interface

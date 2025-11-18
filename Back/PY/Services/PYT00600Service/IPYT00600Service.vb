Imports System.ServiceModel
Imports R_Common
Imports PYT00600Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00600Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00600Service

    Inherits R_IServicebase(Of PYT00600CancellationDTO)

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PYT00600CancellationDTO) As PYT00600CancellationDTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function OpenProcess(poParam As PYT00600CancellationDTO) As PYT00600CancellationDTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar1 As List(Of PYT00600DetailDTO))

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy1(ByVal poPar2 As List(Of PYT00600CancellableDTO))

End Interface

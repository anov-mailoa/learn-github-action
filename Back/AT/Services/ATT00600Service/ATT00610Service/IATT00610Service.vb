Imports System.ServiceModel
Imports R_Common
Imports ATT00600Back
Imports ATT00600Common
Imports R_BackEnd


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00610Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT00610Service
     
    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDateMachine(poParam As ATT00600MachineDateDTO) As ATT00600MachineDateDTO

End Interface

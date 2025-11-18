Imports ATT00800Back
Imports R_BackEnd
Imports System.ServiceModel
Imports R_Common
Imports ATT00050Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00800ByPosService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00800ByPosService

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub prosesSaveAsDraft(ByVal poParam As ATT00800ByPosDTO)

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub prosesSave(ByVal poParam As ATT00800ByPosDTO)

End Interface

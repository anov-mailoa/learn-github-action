Imports ATT00800Back
Imports R_BackEnd
Imports System.ServiceModel
Imports R_Common
Imports ATT00050Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00800ListService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00800ListService

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub ProsesDelAttCorrTrans(ByVal poParam As ATT00800DTO)

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub SubmitProses(ByVal poParam As ATT00800DTO)

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub ReDraftProses(ByVal poParam As ATT00800DTO)

End Interface

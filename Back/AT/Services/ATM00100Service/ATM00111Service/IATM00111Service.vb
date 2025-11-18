Imports System.ServiceModel
Imports ATM00100Back
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATM00100Common


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00111Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00111Service

    <OperationContract()>
    Sub DoWork()

    <OperationContract(Action:="getFormData", ReplyAction:="getFormData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFormData(poparam As ATM00111DTO) As ATM00111NavDTO


End Interface

Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATB00100Back
Imports ATB00100Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATB00100StreamingService

   
    <OperationContract(Action:="MachineData", ReplyAction:="MachineData")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMachine() As Message

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParATB00100 As System.Collections.Generic.List(Of ATB00100GridDTO))


End Interface

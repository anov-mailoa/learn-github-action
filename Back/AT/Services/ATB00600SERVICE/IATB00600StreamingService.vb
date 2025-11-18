Imports System.ServiceModel.Channels
Imports ATB00600Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATB00600StreamingService

    <OperationContract(Action:="getEmployeeValidation", ReplyAction:="getEmployeeValidation")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeValidation() As Message
     
End Interface

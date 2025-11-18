Imports System.ServiceModel.Channels
Imports ATB00700Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00700Streaming" in both code and config file together.
<ServiceContract()>
Public Interface IATB00700StreamingService

    <OperationContract(Action:="getEmployeeValidation", ReplyAction:="getEmployeeValidation")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeValidation() As Message

End Interface

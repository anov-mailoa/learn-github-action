Imports System.ServiceModel
Imports R_Common
Imports PYB00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB00300StreamingService

    <OperationContract(Action:="GetGvSalaryGroupList", ReplyAction:="GetGvSalaryGroupList")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetGvSalaryGroupList() As Message

End Interface

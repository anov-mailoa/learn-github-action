Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PNT02000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT02000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT02000StreamingService

    <OperationContract(Action:="getPnmGradeDt", ReplyAction:="getPnmGradeDt")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSubGrade() As Message

End Interface

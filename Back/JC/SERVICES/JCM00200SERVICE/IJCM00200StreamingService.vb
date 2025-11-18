Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports JCM00200BACK
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCM00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCM00200StreamingService

    <OperationContract(Action:="GetComboTemplate", ReplyAction:="GetComboTemplate")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetComboTemplate() As Message

    <OperationContract(Action:="GetComboPosition", ReplyAction:="GetComboPosition")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetComboPosition() As Message

    <OperationContract(Action:="GetListGridHeader", ReplyAction:="GetListGridHeader")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetListGridHeader() As Message

    <OperationContract(Action:="GetComboTransaction", ReplyAction:="GetComboTransaction")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetComboTransaction() As Message
End Interface

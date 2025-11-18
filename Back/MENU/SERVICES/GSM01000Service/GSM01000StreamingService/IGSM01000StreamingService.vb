Imports System.ServiceModel
Imports R_Common
Imports GSM01000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01000StreamingService

    <OperationContract(Action:="getTransProfile", ReplyAction:="getTransProfile")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransProfile() As Message


    <OperationContract(Action:="getListDepartment", ReplyAction:="getListDepartment")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListDepartment() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar1 As List(Of GSM01000TransProfileDTO))

End Interface

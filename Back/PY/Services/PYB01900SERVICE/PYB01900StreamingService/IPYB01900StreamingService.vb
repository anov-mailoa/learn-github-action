Imports System.ServiceModel
Imports R_Common
Imports PYB01900Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB01900StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB01900StreamingService

    <OperationContract(Action:="GetYear", ReplyAction:="GetYear")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetYear() As Message

    <OperationContract(Action:="RFT_GET_UPLOAD_SPT_A1_EMPLOYEES", ReplyAction:="RFT_GET_UPLOAD_SPT_A1_EMPLOYEES")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_UPLOAD_SPT_A1_EMPLOYEES() As Message

    <OperationContract(Action:="RFT_GET_EMP_SPT_A1_LIST", ReplyAction:="RFT_GET_EMP_SPT_A1_LIST")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_EMP_SPT_A1_LIST() As Message

    <OperationContract(Action:="RSP_PYB01900_VALIDATE_SPT_UPLOAD_FILES", ReplyAction:="RSP_PYB01900_VALIDATE_SPT_UPLOAD_FILES")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_PYB01900_VALIDATE_SPT_UPLOAD_FILES() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_PYB01900_PUBLISH_AND_SEND_SPT()

    <OperationContract(Action:="RFT_UPLOAD_SPT_EMPLOYEE_LOOKUP", ReplyAction:="RFT_UPLOAD_SPT_EMPLOYEE_LOOKUP")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_UPLOAD_SPT_EMPLOYEE_LOOKUP() As Message

    '<OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    'Sub Dummy(ByVal poPar As List(Of PYB01900DTO))

End Interface

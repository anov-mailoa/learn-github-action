Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM03100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM03100StreamingService

    <OperationContract(Action:="TreeView", ReplyAction:="TreeView")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTreeView() As Message

    <OperationContract(Action:="getSearchPosition", ReplyAction:="getSearchPosition")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSearchPosition() As Message

    <OperationContract(Action:="getTrainingMultiple", ReplyAction:="getTrainingMultiple")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTrainingMultiple() As Message

    <OperationContract(Action:="getTrainingCompetencies", ReplyAction:="getTrainingCompetencies")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTrainingCompetencies() As Message

    <OperationContract(Action:="getCompetencyMultiple", ReplyAction:="getCompetencyMultiple")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCompetencyMultiple() As Message

    <OperationContract(Action:="CopyFrom", ReplyAction:="CopyFrom")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCopyFrom() As Message

    <OperationContract(Action:="getCmbParentPositon", ReplyAction:="getCmbParentPositon")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbParentPositon() As Message

    <OperationContract(Action:="getCmbLocation", ReplyAction:="getCmbLocation")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbLocation() As Message

    <OperationContract(Action:="getCmbGrade", ReplyAction:="getCmbGrade")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbGrade() As Message

    <OperationContract(Action:="getCmbReportTo", ReplyAction:="getCmbReportTo")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbReportTo() As Message

    <OperationContract(Action:="getCmbDepartment", ReplyAction:="getCmbDepartment")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDepartment() As Message

    <OperationContract(Action:="showEmployee", ReplyAction:="showEmployee")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function showEmployee() As Message

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParPNM03100Streaming As System.Collections.Generic.List(Of PNM03100TreeDTO),
              ByVal poParPNM03100Multiple As System.Collections.Generic.List(Of PNM03100MultipleDTO))
              
End Interface

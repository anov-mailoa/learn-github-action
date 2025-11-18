Imports System.ServiceModel
Imports R_Common
Imports QAI01000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAI01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAI01000StreamingService

    <OperationContract(Action:="getListDepartmentGrid", ReplyAction:="getListDepartmentGrid")> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListDepartmentGrid() As Message

    <OperationContract(Action:="getPrintReport", ReplyAction:="getPrintReport")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPrintReport() As Message

End Interface

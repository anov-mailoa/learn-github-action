Imports System.ServiceModel
Imports R_Common
Imports SIAPP_PUB_DTO
Imports R_BackEnd
Imports LNI00100Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNI00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNI00100StreamingService

    <OperationContract(Action:="RSP_View_Feasibility", ReplyAction:="RSP_View_Feasibility")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_View_Feasibility() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_Get_Remaining_Loan() As Decimal

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParam As LNI00100Dto)

End Interface

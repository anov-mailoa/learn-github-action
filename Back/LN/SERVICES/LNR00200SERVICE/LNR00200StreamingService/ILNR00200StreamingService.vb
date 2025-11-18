Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNR00200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR00200StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract(Action:="getLoanCategory", ReplyAction:="getLoanCategory")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLoanCategory() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParReguler As System.Collections.Generic.List(Of LNR00200Dto_R), poLoanCateg As System.Collections.Generic.List(Of LNR00200LoanCategoryDto), _
               ByVal poReport As System.Collections.Generic.List(Of ReportHeaderDTO))
End Interface

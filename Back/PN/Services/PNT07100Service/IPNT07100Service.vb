Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNT07100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT07100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT07100Service
    Inherits R_IServicebase(Of PNT07100DTO)

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PNT07100DTO) As PNT07100DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT07100DTO) As PNT07100DTO

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkStatus(poParam As PNT07100DTO)

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function OutstandingTransactionCheck(poParam As PNT07100DTO) As Integer

End Interface

Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNT08100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT08100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT08100Service
    Inherits R_IServicebase(Of PNT08100DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PNT08100GridDTO),
              ByVal poParam2 As List(Of PNT08100ReportDTO))

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeBondDetail(poParam As PNT08100DTO) As PNT08100DTO


    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PNT08100DTO) As PNT08100DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT08100DTO) As PNT08100DTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkStatus(poParam As PNT08100DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub reject(poParam As PNT08100DTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function saveDocument(ByVal poParameter As PNT08100DTO) As PNT08100DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function removeDocument(ByVal poParameter As PNT08100DTO) As PNT08100DTO

End Interface

Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNT05200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT05200Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT05200Service
    Inherits R_IServicebase(Of PNT05200DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkInterface(pcCompanyId As String) As PNT05200DTO

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PNT05200DTO) As PNT05200DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT05200DTO) As PNT05200DTO

End Interface

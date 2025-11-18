Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNT07200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT07200Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT07200Service
    Inherits R_IServicebase(Of PNT07200DTO)

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PNT07200DTO) As PNT07200DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT07200DTO) As PNT07200DTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkStatus(poParam As PNT07200DTO)

End Interface

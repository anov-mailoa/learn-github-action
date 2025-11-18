Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNT07300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT07300Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT07300Service
    Inherits R_IServicebase(Of PNT07300DTO)

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkAllowedResources(poParam As PNT07300DTO) As Boolean

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PNT07300DTO) As PNT07300DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT07300DTO) As PNT07300DTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkStatus(poParam As PNT07300DTO)


    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkActiveLoanTrx(poParam As PNT07300DTO) As String
End Interface

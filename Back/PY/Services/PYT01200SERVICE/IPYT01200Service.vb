Imports System.ServiceModel
Imports R_Common
Imports PYT01200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT01200Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYT01200Service

    Inherits R_IServicebase(Of PYT01200DTO)

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftSubmitProcess(poParam As PYT01200DTO) As PYT01200DTO

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSummary(poParam As PYT01200DTO) As PYT01200DTO


End Interface

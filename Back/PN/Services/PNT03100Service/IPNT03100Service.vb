Imports R_BackEnd
Imports R_Common
Imports PNT03100Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03100Service
    Inherits R_IServicebase(Of PNT03100DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT03100DTO) As PNT03100DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As PNT03100DTO) As PNT03100DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poParam As PNT03100DTO) As PNT03100DTO

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkActiveLoanTrx(poParam As PNT03100DTO) As String
End Interface

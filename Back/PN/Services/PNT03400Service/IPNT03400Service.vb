Imports R_BackEnd
Imports R_Common
Imports PNT03400Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03400Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03400Service
    Inherits R_IServicebase(Of PNT03400DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkInterface(pcCompanyId As String) As PNT03400DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT03400DTO) As PNT03400DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As PNT03400DTO) As PNT03400DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poParam As PNT03400DTO) As PNT03400DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatus(poParam As PNT03400DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getRefNo(poParam As PNT03400DTO) As String

End Interface

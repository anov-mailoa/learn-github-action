Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT05100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT05100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT05100Service
    Inherits R_IServicebase(Of PNT05100DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetailEmployee(poParam As PNT05100DTO) As PNT05100DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetailPosition(poParam As PNT05100DTO) As PNT05100DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT05100DTO) As PNT05100DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poParam As PNT05100DTO) As PNT05100DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As PNT05100DTO) As PNT05100DTO

End Interface

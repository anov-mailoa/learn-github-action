Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM00100FullNameService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM00100FullNameService
    Inherits R_IServicebase(Of PNM00100FullNameDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PNM00100gridFullNameDTO))

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveFullNameParam(poParam As List(Of PNM00100FullNameDTO))

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub SaveNameSequence(poParam As List(Of PNM00100FullNameDTO))
End Interface

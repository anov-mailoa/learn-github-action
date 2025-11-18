Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM05100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05100DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05100DetailService
    Inherits R_IServicebase(Of PNM05100DetailDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PNM05100DetailGridDTO))

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function removeAll(poParam As PNM05100DetailDTO)

End Interface

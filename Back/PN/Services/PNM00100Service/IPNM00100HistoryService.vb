Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM00100HistoryService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM00100HistoryService
    Inherits R_IServicebase(Of PNM00100HistoryDTO)

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PNM00100HistoryGridDTO))

    <OperationContract()>
    Sub DoWork()

End Interface

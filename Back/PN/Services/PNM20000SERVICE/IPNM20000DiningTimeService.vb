Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM20000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM20000DiningTimeService
    Inherits R_IServicebase(Of PNM20000DiningTimeDTO)

    '<OperationContract()>
    '<FaultContract(GetType(R_ServiceExceptions))>
    'Function CheckUserAuthority(poParam As PNM20000DTO) As Integer

End Interface

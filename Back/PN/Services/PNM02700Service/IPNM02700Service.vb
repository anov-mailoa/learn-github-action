Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM02700Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02700Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02700Service
    Inherits R_IServicebase(Of PNM02700FormDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Activate(poParam As PNM02700FormDTO) As PNM02700FormDTO


End Interface

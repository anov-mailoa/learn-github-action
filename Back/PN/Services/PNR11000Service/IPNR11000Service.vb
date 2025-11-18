Imports System.ServiceModel
Imports R_Common
Imports PNR11000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR11000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNR11000Service
    Inherits R_IServicebase(Of PNR11000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkDB(poParam As PNR11000DTO)

End Interface

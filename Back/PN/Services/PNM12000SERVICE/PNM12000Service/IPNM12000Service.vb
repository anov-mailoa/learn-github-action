Imports System.ServiceModel
Imports R_Common
Imports PNM12000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM12000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM12000Service
    Inherits R_IServicebase(Of PNM12000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkSyntax(ByVal poParam As PNM12000DTO)

End Interface

Imports R_BackEnd
Imports R_Common
Imports PNM02000Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02000Service
    Inherits R_IServicebase(Of PNM02000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getActive(poParam As PNM02000DTO) As PNM02000DTO

End Interface

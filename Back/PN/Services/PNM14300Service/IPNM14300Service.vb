Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports PNM14300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14300Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14300Service

    Inherits R_IServicebase(Of PNM14300DetailDTO)

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Activate(poParam As PNM14300DetailDTO) As PNM14300DetailDTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function Deactivate(poParam As PNM14300DetailDTO) As PNM14300DetailDTO

End Interface

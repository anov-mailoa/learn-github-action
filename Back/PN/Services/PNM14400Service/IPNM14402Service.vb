Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports PNM14400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14402Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14402Service
    Inherits R_IServicebase(Of PNM14400AnggotaBpjsDetailDTO)

    <OperationContract()>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function ActivateDeactivate(poParam As PNM14400AnggotaBpjsDetailDTO) As PNM14400AnggotaBpjsDetailDTO

End Interface

Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM02300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02300DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02300DetailService
    Inherits R_IServicebase(Of PNM02300DetailDTO)

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PNM02300DetailGridDTO))

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function Activate(poParam As PNM02300DetailDTO) As PNM02300DetailDTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function validasiActivate(poParam As PNM02300DetailDTO) As Boolean

End Interface

Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCM00500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM00500DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IMCM00500DetailService
    Inherits R_IServicebase(Of MCM00500DetailDTO)

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of MCM00500DetailGridDTO))

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub removeAll(poParam As MCM00500DetailDTO)

End Interface

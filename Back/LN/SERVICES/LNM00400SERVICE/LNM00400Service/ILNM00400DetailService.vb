Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports LNM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM00400DetailService" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00400DetailService
    Inherits R_IServicebase(Of LNM00400DetailDTO)

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of LNM00400DetailGridDTO))

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub removeAll(poParam As LNM00400DetailDTO)

End Interface

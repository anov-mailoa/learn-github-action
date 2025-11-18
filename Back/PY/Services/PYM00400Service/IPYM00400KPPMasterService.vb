Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PYM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00400KPPMasterService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00400KPPMasterService
    Inherits R_IServicebase(Of PYM00400KPPMasterDTO)

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PYM00400KPPMasterGridDTO))

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub SaveIDTKU(poParam As List(Of PYM00400KPPMasterDTO), compid As String)
End Interface

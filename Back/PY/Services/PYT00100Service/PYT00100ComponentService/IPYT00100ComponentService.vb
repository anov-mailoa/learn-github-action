Imports System.ServiceModel
Imports R_Common
Imports PYT00100Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00100ComponentService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00100ComponentService

    'Inherits R_IServicebase(Of PYT00100ComponentDTO)

    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Function getLookUpFormula(poParam As PYT00100ComponentDTO) As List(Of PYT00100ComponentDTO)

End Interface

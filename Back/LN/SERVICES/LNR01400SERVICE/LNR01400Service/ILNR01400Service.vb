Imports System.ServiceModel
Imports LNR01400Back
Imports R_BackEnd
Imports R_Common


' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR01400Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNR01400Service
    Inherits R_IServicebase(Of LNR01400DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of LNR01400DTO), _
              ByVal poPar2 As System.Collections.Generic.List(Of LNR01400GridDTO))

End Interface

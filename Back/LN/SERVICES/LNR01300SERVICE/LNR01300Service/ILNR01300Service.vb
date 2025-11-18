Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNR01300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR01300Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNR01300Service

    Inherits R_IServicebase(Of LNR01300DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of LNR01300DTO), _
              ByVal poPar2 As System.Collections.Generic.List(Of LNR01300GridDTO))

End Interface

Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNR01200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR01200Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNR01200Service

    Inherits R_IServicebase(Of LNR01200DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of LNR01200DTO), _
              ByVal poPar2 As System.Collections.Generic.List(Of LNR01200GridDTO))

End Interface

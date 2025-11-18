Imports System.ServiceModel
Imports R_Common
Imports GSM21000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM21000Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM21000Service

    Inherits R_IServicebase(Of GSM21000DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of ParamDTO))
End Interface

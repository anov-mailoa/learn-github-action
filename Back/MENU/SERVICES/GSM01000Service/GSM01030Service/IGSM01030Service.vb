Imports System.ServiceModel
Imports R_Common
Imports GSM01000Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01030Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01030Service

    Inherits R_IServicebase(Of GSM01030ParamDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub dummy1(ByVal poPar As List(Of GSM01030CmbDTO))

End Interface

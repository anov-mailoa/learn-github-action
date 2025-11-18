Imports System.ServiceModel
Imports R_Common
Imports GSM00400Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM00400Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00400Service
    Inherits R_IServicebase(Of GSM00400CenterGridDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbTransCode() As List(Of GSM00400CmbDTO)

End Interface

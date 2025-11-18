Imports System.ServiceModel
Imports R_Common
Imports GSM01300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01300Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01300UserService
    Inherits R_IServicebase(Of GSM01300UserDTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub processMultipleUser(poParam As GSM01300UserDTO)
End Interface

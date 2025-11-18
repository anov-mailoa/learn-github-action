Imports System.ServiceModel
Imports R_Common
Imports GSM00700Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM00700Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00700Service
    Inherits R_IServicebase(Of GSM00700DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ActivateProcess(poParam As GSM00700DTO) As GSM00700DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckFlagUpload() As Boolean

End Interface

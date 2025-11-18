Imports System.ServiceModel
Imports R_Common
Imports GSM01200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01200Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01200Service

    Inherits R_IServicebase(Of GSM01200DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbRate(pcCompId As String) As List(Of GSM01200CmbDTO)
End Interface

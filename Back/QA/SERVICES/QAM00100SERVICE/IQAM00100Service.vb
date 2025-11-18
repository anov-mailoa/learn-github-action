Imports System.ServiceModel
Imports R_Common
Imports QAM00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00100Service
    Inherits R_IServicebase(Of QAM00100DTO)
   
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetValidationOwnerDeptLevel(ByVal poPar As QAM00100DTO) As Boolean
End Interface

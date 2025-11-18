Imports System.ServiceModel
Imports R_Common
Imports QAM00600Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00600Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00600Service

    Inherits R_IServicebase(Of QAM00600DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidationForDelete(ByVal poPar As QAM00600DTO) As Boolean

End Interface

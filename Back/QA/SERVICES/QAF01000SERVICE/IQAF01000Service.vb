Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports QAF01000Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAF01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAF01000Service

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function compareData(poParam As QAF01000DTO) As Boolean

End Interface

Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCR05000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR05000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCR05000Service

    Inherits R_IServicebase(Of MCR05000DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmLimitPolicy(pcCompId As String) As MCR05000DTO

End Interface

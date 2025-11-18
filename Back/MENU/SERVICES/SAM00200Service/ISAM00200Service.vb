Imports System.ServiceModel
Imports R_Common
Imports SAM00200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM00200Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM00200Service

    Inherits R_IServicebase(Of SAM00200DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkLOB(pcLOBCode As String) As Boolean
End Interface

Imports System.ServiceModel
Imports R_Common
Imports SAM00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM0100Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM00100Service

    Inherits R_IServicebase(Of SAM00100DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkCurr(pcCurrCode As String) As Boolean

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkDel(pcCurrCode As String) As Boolean
End Interface

Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports SAM02400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02400Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02400Service

    Inherits R_IServicebase(Of SAM02400DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function CheckSMTPId(pcSMTPId As String) As String
End Interface

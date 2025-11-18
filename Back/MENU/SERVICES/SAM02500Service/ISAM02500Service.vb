Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports SAM02500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02500Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02500Service

    Inherits R_IServicebase(Of SAM02500DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Reprocess(pcCompanyId As String, pcEmailId As String)
End Interface

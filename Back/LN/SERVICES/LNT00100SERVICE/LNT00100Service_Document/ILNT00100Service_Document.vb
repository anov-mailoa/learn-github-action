Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNT00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00100Service_Document" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00100Service_Document
    Inherits R_IServicebase(Of LNT00100DocDTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RemoveDocument(poParam As LNT00100DocDTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub ScanDocument(poParam As LNT00100DocDTO)
End Interface

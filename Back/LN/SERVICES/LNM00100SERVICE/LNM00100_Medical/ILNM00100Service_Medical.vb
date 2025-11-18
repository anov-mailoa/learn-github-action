Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNM00100Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM00100Service_Medical" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00100Service_Medical
    Inherits R_IServicebase(Of LNM00100DtoMedical)

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedical(pcCoid As String) As LNM00100DtoMedical

End Interface

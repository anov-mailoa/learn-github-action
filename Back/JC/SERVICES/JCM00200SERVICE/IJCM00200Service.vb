Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports JCM00200BACK
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCM00200Service" in both code and config file together.
<ServiceContract()>
Public Interface IJCM00200Service
    Inherits R_IServicebase(Of JCM00200DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub UpdateFlag(poParam As JCM00200DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetViewTemplate(poParam As JCM00200DTO) As JCM00200DTO
End Interface

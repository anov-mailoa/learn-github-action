Imports System.ServiceModel
Imports R_Common
Imports ATT91000Back
Imports ATT91000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT91000Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT91000Service

    Inherits R_IServicebase(Of ATT91000DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As ATT91000DTO) As ATT91000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As ATT91000DTO) As ATT91000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSystemParam(poParam As String) As String

End Interface

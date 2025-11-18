Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYI02000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYI02000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYI02000Service

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRecordById(poEntity As PYI02000DTO) As PYI02000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CalculateProcess(poEntity As PYI02000DTO) As PYI02000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeName(poEntity As PYI02000DTO) As PYI02000DTO

End Interface

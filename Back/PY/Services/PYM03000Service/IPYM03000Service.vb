Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PYM03000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM03000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM03000Service
    Inherits R_IServicebase(Of PYM03000DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkRestrict(pcCompId As String) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkUsedSalaryRange(pcCompId As String) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub PYM03000Saving(poNewEntity As PYM03000DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getRecord(poParam As PYM03000DTO) As PYM03000DTO

End Interface

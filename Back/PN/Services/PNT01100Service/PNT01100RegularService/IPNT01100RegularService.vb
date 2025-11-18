Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT01100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT01100RegularService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT01100RegularService
    Inherits R_IServicebase(Of PNT01100DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeOfficialData(poEntity As PNT01100DTO) As PNT01100DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckEmployeeAssignationResignation(poEntity As PNT01100DTO) As Boolean

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ProcessReDraft(poEntity As PNT01100DTO) As PNT01100DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ProcessSubmit(poEntity As PNT01100DTO) As PNT01100DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poCurrent As PNT01100DTO) As PNT01100DTO

End Interface

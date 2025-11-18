Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT01000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT01000RegularService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT01000RegularService
    Inherits R_IServicebase(Of PNT01000DTO)

    '    <OperationContract()>
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Function CekDepartment(poParam As PNT01000DTO) As PNT01000DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CekEmployee(poParam As PNT01000DTO) As PNT01000DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CekPosition(poParam As PNT01000DTO) As PNT01000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poCurrent As PNT01000DTO) As PNT01000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poCurrent As PNT01000DTO) As PNT01000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poCurrent As PNT01000DTO) As PNT01000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRecordById2(poEntity As PNT01000DTO) As PNT01000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRecordById3(poEntity As PNT01000DTO) As PNT01000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRecordById4(poEntity As PNT01000DTO) As PNT01000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckStatus(poEntity As PNT01000DTO) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetProbationNote(poEntity As PNT01000DTO) As String

End Interface

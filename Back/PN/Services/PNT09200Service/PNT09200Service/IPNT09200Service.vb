Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT09200Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT09200Service
    Inherits R_IServicebase(Of PNT09200DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT09200DTO) As PNT09200DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As PNT09200DTO) As PNT09200DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRejectReward(poCurrent As PNT09200DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poParam As PNT09200DTO) As PNT09200DTO

    '    <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Function getReportData(poParam As PNT09200DTO) As PNT09200ReportDTO
End Interface
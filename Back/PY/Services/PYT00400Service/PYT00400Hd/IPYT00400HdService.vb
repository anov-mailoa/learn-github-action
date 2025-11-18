Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYT00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00400HdService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00400HdService
    Inherits R_IServicebase(Of PYT00400HdDTO)

    '    <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Function UpdatePytTransDt(poParam As PYT00400HdDTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionPeriod(poParam As PYT00400HdDTO) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftFunction(poParam As PYT00400HdDTO) As PYT00400HdDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function OpenFunction(poParam As PYT00400HdDTO) As PYT00400HdDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetActivePeriod(poParam As PYT00400HdDTO) As PYT00400HdDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckFinalizeKpp(poParam As PYT00400HdDTO) As Boolean

End Interface

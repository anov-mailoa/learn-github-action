Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYT00300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00300HdService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00300HdService
    Inherits R_IServicebase(Of PYT00300HdDTO)

    '    <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Function GetAdjustment(poParam As PYT00300HdDTO) As PYT00300HdDTO

    '    <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Function CheckTransactionProcess(poParam As PYT00300HdDTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetAdjustmentTrue(poParam As PYT00300HdDTO) As PYT00300PeriodDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetAdjustmentFalse(poParam As PYT00300HdDTO) As PYT00300PeriodDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function UpdatePytTransDt(poParam As PYT00300HdDTO) As Boolean

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PYT00300HdDTO) As PYT00300HdDTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function OpenProcess(poParam As PYT00300HdDTO) As PYT00300HdDTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function CheckActiveRapidTrx(poParam As PYT00300HdDTO) As String

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParamHd2 As System.Collections.Generic.List(Of PYT00300GridHdDTO))

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy1(ByVal poParamDt2 As System.Collections.Generic.List(Of PYT00300GridDtDTO))

End Interface

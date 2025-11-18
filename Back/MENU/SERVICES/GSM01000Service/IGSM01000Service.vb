Imports System.ServiceModel
Imports R_Common
Imports GSM01000Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01000Service

    Inherits R_IServicebase(Of GSM01000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of GSM01000CmbDTO))

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekApproval(poParam As GSM01000DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub generateNumbering(pcCompId As String)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function NumberingHasUsedInTransaction(pcCompId As String) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekNumbering(poParam As GSM01000DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getRestrictFlag(pcCompId As String, pcTransCd As String) As Boolean

End Interface

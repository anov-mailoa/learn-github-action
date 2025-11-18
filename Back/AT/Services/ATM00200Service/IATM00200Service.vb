Imports System.ServiceModel
Imports ATM00200Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00200Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00200Service

    Inherits R_IServicebase(Of ATM00200DTO)

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkATM00200List(ByVal poEntity As ATM00200DTO) As List(Of ATM00200DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkSyntax(ByVal poEntity As ATM00200DTO) As Boolean

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function ProcessSequenceCheck(poParam As ATM00200DTO) As Integer

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetExitPermit(ByVal poEntity As ATM00200DTO) As ATM00200DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub UpdateExitPermit(ByVal poEntity As ATM00200DTO)
End Interface

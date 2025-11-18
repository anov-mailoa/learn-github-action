Imports System.ServiceModel
Imports ATM00150Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00150Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00150Service

    Inherits R_IServicebase(Of ATM00150DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkPath(poParam As ATM00150DTO) As List(Of ATM00150DTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSystemParam(ByVal poEntity As ATM00150DTO) As ATM00150DTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckATM0150(ByVal poEntity As ATM00150DTO) As ATM00150DTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFieldsSetupPosition(poParam As ATM00150DTO) As List(Of ATM00150DTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkSyntax(poParam As ATM00150DTO) As Boolean

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function activation(poEntity As ATM00150DTO) As ATM00150DTO

End Interface

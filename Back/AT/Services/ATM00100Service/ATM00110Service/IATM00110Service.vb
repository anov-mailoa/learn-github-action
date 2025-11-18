Imports System.ServiceModel
Imports ATM00100Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00110Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00110Service

    Inherits R_IServicebase(Of ATM00110DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkPath(poParam As ATM00110DTO) As List(Of ATM00110DTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSystemParam(ByVal poEntity As ATM00110DTO) As ATM00110DTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckATM0110(ByVal poEntity As ATM00110DTO) As ATM00110DTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFieldsSetupPosition(poParam As ATM00110DTO) As List(Of ATM00110DTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkSyntax(poParam As ATM00110DTO) As Boolean

End Interface

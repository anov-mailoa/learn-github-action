Imports System.ServiceModel
Imports ATM00400Back
Imports R_BackEnd
Imports R_Common
Imports ATM00400Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00400Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00400Service
    Inherits R_IServicebase(Of ATM00400DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function activate(poParam As ATM00400DTO) As ATM00400Common.ATM00420StreamingDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function deActivate(poParam As ATM00400DTO) As ATM00400Common.ATM00420StreamingDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLastDate(pcCompId As String) As String


End Interface

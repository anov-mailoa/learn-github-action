Imports System.ServiceModel
Imports R_Common
Imports PYM01400Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01400StreamingService

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar4 As List(Of KPPDTO_R), ByVal poPar5 As List(Of DepartmentDto_R), ByVal poPar6 As List(Of KodePajakDTO_R), _
              ByVal poPar8 As List(Of PYM01400GridDto_R), ByVal poPar9 As List(Of LookUpCmbDTO_R),
              ByVal poPar10 As List(Of DropDownListIdentityTypeDto), _
              ByVal poPar11 As List(Of DropDownTaxStatusDto), ByVal poPar13 As List(Of PYT01400GridDto_R))

    <OperationContract(Action:="Get_Department", ReplyAction:="Get_Department")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function Get_Department() As Message

    <OperationContract(Action:="Get_Kode_Pajak", ReplyAction:="Get_Kode_Pajak")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function Get_Kode_Pajak() As Message

    <OperationContract(Action:="Get_KPP", ReplyAction:="Get_KPP")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function Get_KPP() As Message
End Interface

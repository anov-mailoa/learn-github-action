Imports System.ServiceModel
Imports R_Common
Imports LNM00100Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ITrainingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00100Service

    <OperationContract(Action:="getTenor", ReplyAction:="getTenor")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataGrid() As Message

    <OperationContract(Action:="getUpdateDateList", ReplyAction:="getUpdateDateList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getUpdateDateList() As Message

    <OperationContract(Action:="GetCMBCurrenyTaxRate", ReplyAction:="GetCMBCurrenyTaxRate")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCMBCurrenyTaxRate() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNM00100Dto_R), poParCombo As System.Collections.Generic.List(Of Cmb_Dto))

End Interface

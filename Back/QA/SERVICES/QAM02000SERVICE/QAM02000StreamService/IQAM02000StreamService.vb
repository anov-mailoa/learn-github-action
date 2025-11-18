Imports System.ServiceModel
Imports R_Common
Imports QAM02000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM02000StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IQAM02000StreamService

    <OperationContract(Action:="getComboTemplate", ReplyAction:="getComboTemplate")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComboTemplate() As Message

    <OperationContract(Action:="getComboPosition", ReplyAction:="getComboPosition")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComboPosition() As Message



    <OperationContract(Action:="getListGridHeader", ReplyAction:="getListGridHeader")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGridHeader() As Message

    <OperationContract(Action:="getListGridOther", ReplyAction:="getListGridOther")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGridOther() As Message

    <OperationContract(Action:="getListGridReceptions_CC", ReplyAction:="getListGridReceptions_CC")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGridReceptions_CC() As Message

    <OperationContract(Action:="getListGridReceptions_BCC", ReplyAction:="getListGridReceptions_BCC")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGridReceptions_BCC() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(
              ByVal poGrid2 As QAM02000OthersDTO,
               ByVal poGrid3 As QAM02000BCCDTO,
                ByVal poGrid4 As QAM02000CCDTO)


End Interface

Imports System.ServiceModel
Imports R_Common
Imports LNM00200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM00200Service_Streaming" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00200Service_Streaming

    <OperationContract(Action:="getLoanType", ReplyAction:="getLoanType")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataGrid() As Message

    <OperationContract(Action:="getLoanCategory", ReplyAction:="getLoanCategory")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLoanCategory() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNM00200Dto_R), _
              poParComboBox As System.Collections.Generic.List(Of LNM00200CmbDto), poDimension As System.Collections.Generic.List(Of LNM00200DimensionDto))

End Interface

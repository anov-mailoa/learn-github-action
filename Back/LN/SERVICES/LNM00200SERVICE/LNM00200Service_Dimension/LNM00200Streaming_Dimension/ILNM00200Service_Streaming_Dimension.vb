Imports System.ServiceModel
Imports R_Common
Imports LNM00200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM00200Service_Streaming" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00200Service_Streaming_Dimension

    <OperationContract(Action:="getLoanDimension", ReplyAction:="getLoanDimension")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridDimension() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParamStreaming As System.Collections.Generic.List(Of LNM00200Dto_Dimension_S), ByVal poParamReguler As System.Collections.Generic.List(Of LNM00200Dto_Dimension_R))

    <OperationContract(Action:="RSP_Get_Loan_Policy_Matrix", ReplyAction:="RSP_Get_Loan_Policy_Matrix")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Get_Loan_Policy_Matrix() As Message

End Interface

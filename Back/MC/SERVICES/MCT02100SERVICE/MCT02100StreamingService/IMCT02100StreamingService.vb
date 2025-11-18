Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports MCT02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM02100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCT02100StreamingService

    <OperationContract(Action:="gvListHeader", ReplyAction:="gvListHeader")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function gvListHeader() As Message

    <OperationContract(Action:="gvListDetail", ReplyAction:="gvListDetail")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function gvListDetail() As Message

    <OperationContract(Action:="DownloadPartnerMember", ReplyAction:="DownloadPartnerMember")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DownloadPartnerMember() As Message

    <OperationContract(Action:="getErrorData", ReplyAction:="getErrorData")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getErrorData() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of MCT02100GvDto), _
              poPar4 As System.Collections.Generic.List(Of DownloadPartnerMemberDto))
End Interface

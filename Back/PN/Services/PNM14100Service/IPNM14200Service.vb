Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports PNM14100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14200Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14200Service
    Inherits R_IServicebase(Of PNM14200Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParStreaming As System.Collections.Generic.List(Of DropDownListDto))

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function cekUsedBPJS(poParam As PNM14200Dto) As Boolean

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function setActivateDeactivate(poParam As PNM14200Dto) As PNM14200Dto

End Interface

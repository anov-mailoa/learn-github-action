Imports System.ServiceModel
Imports R_Common
Imports QAT00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00300Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00300Service

    Inherits R_IServicebase(Of QAT00300DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPropertData(poParam As QAT00300DTO) As QAT00300DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckDocument(poParam As QAT00300DTO) As QAT00300DTO

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDocumentInfo(poParam As QAT00300DTO) As QAT00300DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckRelatedDocument(poParam As QAT00300DTO) As QAT00300DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckOpenDocument(poParam As QAT00300DTO) As QAT00300DTO

End Interface

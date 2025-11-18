Imports System.ServiceModel
Imports R_Common
Imports JCI00100Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCI00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IJCI00100Service

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHeaderJcEvaluation(poParam As JCI00100DTO) As JCI00100DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getFooterJcEvaluation(poParam As JCI00100DTO) As JCI00100DTO

End Interface

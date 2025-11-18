Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports QAT00101Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00101RelatedService" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00101RelatedService
    Inherits R_IServicebase(Of QAT00101RelatedPositionGridDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveAllAudit(poParam As QAT00101RelatedPositionGridDTO)



End Interface

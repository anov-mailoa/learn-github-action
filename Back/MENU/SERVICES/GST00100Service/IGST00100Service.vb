Imports System.ServiceModel
Imports R_Common
Imports GST00100Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGST00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IGST00100Service

    Inherits R_IServicebase(Of GST00100DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLblWelcome(poParam As GST00100DTO) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransType(poParam As GST00100DTO) As String



End Interface

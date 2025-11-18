Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCT01100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT01100Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCT01100Service

    Inherits R_IServicebase(Of MCT01100DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As MCT01100DTO) As MCT01100DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As MCT01100DTO) As MCT01100DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getYear(poParam As MCT01100DTO) As String

End Interface

Imports System.ServiceModel
Imports R_Common
Imports QAT00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT003005Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT003005Service

    Inherits R_IServicebase(Of QAT003005DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEditRelatedDoc(poParam As String) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkDocTypeMandatory(poParam As QAT003005DTO) As Boolean

End Interface

Imports System.ServiceModel
Imports R_Common
Imports QAT00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT003006Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT003006Service
    Inherits R_IServicebase(Of QAT003006DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEditRelatedDoc(poParam As String) As Boolean

End Interface

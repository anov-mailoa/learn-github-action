Imports System.ServiceModel
Imports R_Common
Imports PYM00600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00600Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00600Service

    Inherits R_IServicebase(Of PYM00600GridDTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkCodeUsage(poParam As PYM00600GridDTO) As Integer

End Interface

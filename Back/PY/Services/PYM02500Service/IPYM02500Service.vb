Imports System.ServiceModel
Imports R_Common
Imports PYM02500Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM02500Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM02500Service
    Inherits R_IServicebase(Of PYM02500DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLocalCurr(pcCompId As String) As String


End Interface

Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM14100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14500Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14500Service
    Inherits R_IServicebase(Of PNM14500ParameterDTO)
    <OperationContract()>
    Sub DoWork()



    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckSyntax(poParam As PNM14500ParameterDTO) As Boolean
End Interface

Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYM00500Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00500ParameterService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00500ParameterService
    Inherits R_IServicebase(Of PYM00500ParameterDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMaxYear(poParam As PYM00500ParameterDTO) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub getCheckSyntax(poParam As PYM00500ParameterDTO)

End Interface

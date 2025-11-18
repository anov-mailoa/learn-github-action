Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYM01400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01400Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01400Service
    Inherits R_IServicebase(Of PYM01400Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ActivateDeactivate(poParam As PYM01400Dto) As PYM01400Dto

End Interface

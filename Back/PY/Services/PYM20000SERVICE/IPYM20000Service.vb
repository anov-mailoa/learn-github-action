Imports System.ServiceModel
Imports PYM20000BACK
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM20000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM20000Service
    Inherits R_IServicebase(Of PYM20000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub DeleteEmployee(poParam As PYM20000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ProcessAddEmployee(poParam As PYM20000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMinMaxOrgLvl(poParam As PYM20000DTO) As PYM20000DTO

End Interface

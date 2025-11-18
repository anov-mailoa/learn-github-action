Imports System.ServiceModel
Imports R_Common
Imports SAM01400Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM01400Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM01400Service

    Inherits R_BackEnd.R_IServicebase(Of SAM01400Back.SAM01400DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckCompany() As Integer
End Interface

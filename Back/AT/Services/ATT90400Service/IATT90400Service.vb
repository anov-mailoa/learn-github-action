Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ATT90400Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90400Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT90400Service
    Inherits R_IServicebase(Of ATT90400DTO)

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftSubmit(poCurrent As ATT90400DTO) As ATT90400DTO

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getExpired(poCurrent As ATT90400DTO) As ATT90400DTO
End Interface

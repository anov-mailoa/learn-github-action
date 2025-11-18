Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ATT90700Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90700Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT90700Service
    Inherits R_IServicebase(Of ATT90700DTO)

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftSubmit(poCurrent As ATT90700DTO) As ATT90700DTO

End Interface

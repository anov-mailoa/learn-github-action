Imports R_Common
Imports ESM00500Back
Imports ESM00500Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM00500Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM00500Service

    Inherits R_IServicebase(Of esm00500parameterdto)


    <OperationContract(Action:="setActive", ReplyAction:="setActive")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub setActive(poParam As ESM00500ParameterDTO)


End Interface

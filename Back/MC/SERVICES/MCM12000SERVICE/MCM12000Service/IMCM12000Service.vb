Imports System.ServiceModel
Imports R_Common
Imports MCM12000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM12000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCM12000Service
    Inherits R_IServicebase(Of MCM12000DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub checkSyntax(ByVal poParam As MCM12000DTO)

End Interface

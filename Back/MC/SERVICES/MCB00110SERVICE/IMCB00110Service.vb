Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCB00110Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCB00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCB00110Service

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getYearProcess(ByVal poParam As MCB00110DTO) As List(Of MCB00110DTO)

End Interface

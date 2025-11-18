Imports System.ServiceModel
Imports R_Common
Imports SAM02200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02200Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02200Service

    Inherits R_IServicebase(Of SAM02200DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveSplitData(poParam As SplitDTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveData(poParam As SaveFileDTO)

End Interface

Imports R_BackEnd
Imports PNM04100Back
Imports System.ServiceModel
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM04100ServicePositions" in both code and config file together.
<ServiceContract()>
Public Interface IPNM04100ServicePositions
    Inherits R_IServicebase(Of PNM04100PositionsDto)


    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Activate(poParam As PNM04100PositionsDto) As PNM04100PositionsDto


  

End Interface

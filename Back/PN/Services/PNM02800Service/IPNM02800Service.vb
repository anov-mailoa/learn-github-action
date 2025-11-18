Imports System.ServiceModel
Imports R_Common
Imports PNM02800Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02800Service
    Inherits R_IServicebase(Of PNM02800FormDTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function ActivateData(poParam As PNM02800FormDTO) As PNM02800FormDTO

End Interface

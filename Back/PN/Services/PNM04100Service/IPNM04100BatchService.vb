Imports R_BackEnd
Imports PNM04100Back
Imports System.ServiceModel
Imports R_Common
Imports PNM04100Common


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM04100BatchService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM04100BatchService

    'Inherits R_IServicebase(Of PNM04100BatchDto)


    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Activate(poParam As PNM04100BatchDto) As PNM04100BatchDto

End Interface

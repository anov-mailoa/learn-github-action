Imports R_BackEnd
Imports PNM04100Back
Imports System.ServiceModel
Imports R_Common


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM04100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM04100Service

    Inherits R_IServicebase(Of PNM04100PnmFacilitiesDto)


    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Activate(poParam As PNM04100PnmFacilitiesDto) As PNM04100PnmFacilitiesDto

End Interface

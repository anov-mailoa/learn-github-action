Imports R_Common
Imports R_BackEnd
Imports PNM20100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM20000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM20100Service
    Inherits R_IServicebase(Of PNM20100DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function RFN_FIND_MIN_DATE_DINING_SCHEDULE(poParam As PNM20100DTO) As String

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub RSP_PNM20100_COPY_DINING_SCHEDULE(poParam As PNM20100DTO)

End Interface

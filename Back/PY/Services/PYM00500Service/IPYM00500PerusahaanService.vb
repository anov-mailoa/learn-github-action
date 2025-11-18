Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYM00500Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00500PerusahaanService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00500PerusahaanService
    Inherits R_IServicebase(Of PYM00500PerusahaanDTO)


    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkDelete(poParam As PYM00500PerusahaanDTO) As Boolean

End Interface

Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM02400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02400PnmGradeHdService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02400PnmGradeHdService

    Inherits R_IServicebase(Of PNM02400PnmGradeHdDTO)

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkDetail(poParam As PNM02400PnmGradeHdDTO) As Boolean

End Interface

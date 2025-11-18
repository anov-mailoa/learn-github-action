Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PYM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00400PPH21Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00400PPH21Service
    Inherits R_IServicebase(Of PYM00400PPH21DTO)

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PYM00400PPH21GridDTO))

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function cekCustomTax(poParam As PYM00400PPH21DTO) As Boolean

End Interface

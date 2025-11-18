Imports PNT90000Back
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT90000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT90000Service

    <OperationContract()>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransactionType(poParam As PNT90000DTO) As List(Of ComboBoxDTO)

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRejectRule(poParam As PNT90000DTO) As Boolean

End Interface

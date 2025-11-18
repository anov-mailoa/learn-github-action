Imports System.ServiceModel
Imports R_Common
Imports GSM01000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01010Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01010Service

    Inherits R_IServicebase(Of GSM01010DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPeriodNo(poParam As GSM01010DTO) As List(Of GSM01010CmbDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDeptCode(poParam As GSM01010DTO) As List(Of GSM01010CmbDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekPeriodNo(poParam As GSM01010DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekDeptMode(poParam As GSM01010DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekTransCode(poParam As GSM01010DTO) As Boolean

End Interface

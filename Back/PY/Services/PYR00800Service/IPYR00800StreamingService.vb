Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports PYR00800Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR00800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR00800StreamingService

    <OperationContract(Action:="LoadGrid", ReplyAction:="LoadGrid")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function LoadGrid() As Message


    <OperationContract(Action:="getCmbPeriod", ReplyAction:="getCmbPeriod")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPeriod() As Message

    <OperationContract(Action:="RSP_EMP_SALARY_SLIP", ReplyAction:="RSP_EMP_SALARY_SLIP")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_EMP_SALARY_SLIP() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParamDto As System.Collections.Generic.List(Of PYR00800Dto),
              ByVal poParamGv As System.Collections.Generic.List(Of GvSalaryGroupDto))

End Interface

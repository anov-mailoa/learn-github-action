Imports R_BackEnd
Imports R_Common
Imports PYM00200Back
Imports System.ServiceModel

<ServiceContract()>
Public Interface IPYM00200RegularService
    Inherits R_IServicebase(Of PYM00200GridDto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParGrid As List(Of PYM00210GridDto))

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkPaymentConfiguration(poParam As PYM00200GridDto) As Boolean

End Interface

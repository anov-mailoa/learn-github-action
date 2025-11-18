Imports System.ServiceModel
Imports ATM00150Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00150DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00150DetailService

    Inherits R_IServicebase(Of ATM00150DetailDTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckATM0150Detail(ByVal poEntity As ATM00150DetailDTO) As ATM00150DetailDTO

End Interface

Imports System.ServiceModel
Imports ATM00100Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00110DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00110DetailService

    Inherits R_IServicebase(Of ATM00110DetailDTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckATM0110Detail(ByVal poEntity As ATM00110DetailDTO) As ATM00110DetailDTO

End Interface

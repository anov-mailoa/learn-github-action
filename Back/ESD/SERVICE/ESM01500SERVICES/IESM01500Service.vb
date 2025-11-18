Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ESM01500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01500Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM01500Service
    Inherits R_IServicebase(Of ESM01500DTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeName(poParam As ESM01500ParamDTO) As String
End Interface

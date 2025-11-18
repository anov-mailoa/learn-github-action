Imports R_BackEnd
Imports PNT06200Back
Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT06200ReturnDtServices" in both code and config file together.
<ServiceContract()>
Public Interface IPNT06200ReturnDtServices
    Inherits R_IServicebase(Of PNT06200ReturnDtDto)


    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As PNT06200ReturnDtDto)

    ' <OperationContract()>
    '<FaultContract(GetType(R_ServiceExceptions))>
    ' Function getQuantity(poParam As PNT06200ReturnDtDto) As Integer
End Interface

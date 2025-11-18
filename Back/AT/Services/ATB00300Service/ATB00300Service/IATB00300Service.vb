Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATB00300Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00300Service" in both code and config file together.
<ServiceContract()>
Public Interface IATB00300Service


    Inherits R_IServicebase(Of ATB00300DTO)

    <OperationContract(Action:="getDate", ReplyAction:="getDate")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDate(poParam As ATB00300DTO) As String
    
End Interface

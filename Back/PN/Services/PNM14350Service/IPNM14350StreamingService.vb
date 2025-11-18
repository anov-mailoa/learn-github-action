Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNM14350Back
Imports PNM14350Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14350StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14350StreamingService

    <OperationContract(Action:="getAnggotaKK", ReplyAction:="getAnggotaKK")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getAnggotaKK() As Message

End Interface

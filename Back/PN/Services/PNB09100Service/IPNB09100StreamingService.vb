Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNB09100Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNB09100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNB09100StreamingService

    <OperationContract(Action:="getPnmEmpOffice", ReplyAction:="getPnmEmpOffice")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmEmpOffice() As Message

End Interface

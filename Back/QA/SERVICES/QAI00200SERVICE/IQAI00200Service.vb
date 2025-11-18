Imports System.ServiceModel
Imports R_Common
Imports QAI00200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAI00200Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAI00200Service
    Inherits R_IServicebase(Of QAI00200Dto)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDOC(poParam As QAI00200Dto) As QAI00200Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetHISTDOCINFO(poParam As QAI00200Dto) As QAI00200Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetFILING(poParam As QAI00200Dto) As QAI00200Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetHISTFILING(poParam As QAI00200Dto) As QAI00200Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRELDOC(poParam As QAI00200Dto) As QAI00200Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRELDOCFILING(poParam As QAI00200Dto) As QAI00200Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRSP_QAI00200_GETDOCCOVER(poParam As QAI00200Dto) As QAI00200Dto
End Interface

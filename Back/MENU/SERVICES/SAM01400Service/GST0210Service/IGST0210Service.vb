Imports System.ServiceModel
Imports R_Common
Imports SAM01400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGST0210Service" in both code and config file together.
<ServiceContract()>
Public Interface IGST0210Service

    Inherits R_BackEnd.R_IServicebase(Of GST0210DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function svcGetCompanyExceptionList() As List(Of GST0210DTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function svcGetCompanyList() As List(Of GST0210CompanyDTO)

End Interface

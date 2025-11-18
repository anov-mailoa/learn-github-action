'==== 202003132 1st Code by ===='
'    ____    ____  _________   '
'   |_   \  /   _||  _   _  |  '
'     |   \/   |  |_/ | | \_|  '
'     | |\  /| |      | |      '
'    _| |_\/_| |_    _| |_     '
'   |_____||_____|  |_____|    '
'                              '
'============= CR9 ============'




Imports System.ServiceModel
Imports R_Common
Imports PYM00100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM0010002Sercice" in both code and config file together.
<ServiceContract()>
Public Interface IPYM0010002Service
    Inherits R_IServicebase(Of PYM0010002DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckSystemParam(poParam As String) As Boolean
End Interface

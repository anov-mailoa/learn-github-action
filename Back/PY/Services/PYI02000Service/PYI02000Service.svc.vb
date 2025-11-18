Imports R_BackEnd
Imports R_Common
Imports PYI02000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYI02000Service" in code, svc and config file together.
Public Class PYI02000Service
    Implements IPYI02000Service

    Public Function CalculateProcess(poEntity As PYI02000Back.PYI02000DTO) As PYI02000Back.PYI02000DTO Implements IPYI02000Service.CalculateProcess
        Dim loException As New R_Exception
        Dim loCls As New PYI02000Cls
        Dim loRtn As New PYI02000DTO

        Try
            loRtn = loCls.CalculateProcess(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetRecordById(poEntity As PYI02000Back.PYI02000DTO) As PYI02000Back.PYI02000DTO Implements IPYI02000Service.GetRecordById
        Dim loException As New R_Exception
        Dim loCls As New PYI02000Cls
        Dim loRtn As New PYI02000DTO

        Try
            loRtn = loCls.GetRecordById(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetEmployeeName(poEntity As PYI02000Back.PYI02000DTO) As PYI02000Back.PYI02000DTO Implements IPYI02000Service.GetEmployeeName
        Dim loException As New R_Exception
        Dim loCls As New PYI02000Cls
        Dim loRtn As New PYI02000DTO

        Try
            loRtn = loCls.GetEmployeeName(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

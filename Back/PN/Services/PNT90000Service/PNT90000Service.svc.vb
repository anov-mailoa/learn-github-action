Imports PNT90000Back
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT90000Service" in code, svc and config file together.
Public Class PNT90000Service
    Implements IPNT90000Service

    Public Function getTransactionType(poParam As PNT90000Back.PNT90000DTO) As System.Collections.Generic.List(Of PNT90000Back.ComboBoxDTO) Implements IPNT90000Service.getTransactionType
        Dim loRtn As New List(Of ComboBoxDTO)
        Dim loCls As New PNT90000Cls
        Dim loEx As New R_Exception

        Try

            loRtn = loCls.getTransactionType(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRejectRule(poParam As PNT90000Back.PNT90000DTO) As Boolean Implements IPNT90000Service.getRejectRule
        Dim loRtn As New Boolean
        Dim loCls As New PNT90000Cls
        Dim loEx As New R_Exception

        Try

            loRtn = loCls.getRejectRule(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class

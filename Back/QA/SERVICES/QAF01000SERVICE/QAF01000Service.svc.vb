' NOTE: You can use the "Rename" command on the context menu to change the class name "QAF01000Service" in code, svc and config file together.
Imports R_Common
Imports R_BackEnd
Imports QAF01000Back

Public Class QAF01000Service
    Implements IQAF01000Service

    Public Function compareData(poParam As QAF01000Back.QAF01000DTO) As Boolean Implements IQAF01000Service.compareData
        Dim loEx As New R_Exception
        Dim loCls As New QAF01000CLS
        Dim loRtn As Boolean
        Try
            loRtn = loCls.compareData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class

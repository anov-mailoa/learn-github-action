Imports R_BackEnd
Imports R_Common
Imports PYT00300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00300DtService" in code, svc and config file together.
Public Class PYT00300DtService
    Implements IPYT00300DtService

    Public Function GetTemplate(poParam As System.Collections.Generic.List(Of PYT00300Back.PYT00300DtDTO), pcKey As String) As System.Collections.Generic.List(Of PYT00300Back.PYT00300DtDTO) Implements IPYT00300DtService.GetTemplate
        'Dim loException As New R_Exception
        'Dim loCls As New PYT00300DtCls
        'Dim loRtn As List(Of PYT00300DtDTO)

        'Try
        '    loRtn = loCls.GetTemplate(poParam, pcKey)
        'Catch ex As Exception
        '    loException.Add(ex)
        'End Try

        'loException.ConvertAndThrowToServiceExceptionIfErrors()

        'Return loRtn
    End Function

    Public Function CheckIfExistDownload(poParam As PYT00300Back.PYT00300DtDTO) As Boolean Implements IPYT00300DtService.CheckIfExistDownload
        'Dim loException As New R_Exception
        'Dim loCls As New PYT00300DtCls
        'Dim loRtn As Boolean

        'Try
        '    loRtn = loCls.CheckIfExistDownload(poParam)
        'Catch ex As Exception
        '    loException.Add(ex)
        'End Try

        'loException.ConvertAndThrowToServiceExceptionIfErrors()

        'Return loRtn
    End Function

    Public Function CheckIfExistUpload(poParam As PYT00300Back.PYT00300DtDTO) As Boolean Implements IPYT00300DtService.CheckIfExistUpload
        'Dim loException As New R_Exception
        'Dim loCls As New PYT00300DtCls
        'Dim loRtn As Boolean

        'Try
        '    loRtn = loCls.CheckIfExistUpload(poParam)
        'Catch ex As Exception
        '    loException.Add(ex)
        'End Try

        'loException.ConvertAndThrowToServiceExceptionIfErrors()

        'Return loRtn
    End Function

End Class

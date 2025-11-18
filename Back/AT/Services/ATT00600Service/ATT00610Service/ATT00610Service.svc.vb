' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00610Service" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports ATT00600Back
Imports ATT00600Common
Imports R_BackEnd

Public Class ATT00610Service
    Implements IATT00610Service
     
    Public Function getDateMachine(poParam As ATT00600Back.ATT00600MachineDateDTO) As ATT00600Back.ATT00600MachineDateDTO Implements IATT00610Service.getDateMachine

        Dim loEx As New R_Exception
        Dim loCls As New ATT00610CLS
        Dim loRtn As ATT00600MachineDateDTO = Nothing

        Try
            loRtn = loCls.getDateMachine(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class

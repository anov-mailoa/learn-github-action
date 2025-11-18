Imports R_Common
Imports R_BackEnd
Imports ATM00400Back
Imports ATM00400Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00400Service" in code, svc and config file together.
Public Class ATM00400Service
    Implements IATM00400Service


    Public Sub Svc_R_Delete(poEntity As ATM00400Back.ATM00400DTO) Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400DTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00400Back.ATM00400DTO) As ATM00400Back.ATM00400DTO Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim loRtn As ATM00400DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00400Back.ATM00400DTO, poCRUDMode As R_Common.eCRUDMode) As ATM00400Back.ATM00400DTO Implements R_BackEnd.R_IServicebase(Of ATM00400Back.ATM00400DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim loRtn As ATM00400DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function activate(poParam As ATM00400Back.ATM00400DTO) As ATM00400Common.ATM00420StreamingDTO Implements IATM00400Service.activate
        Dim loException As New R_Exception
        Dim loCls As New ATM00420CLS
        Dim loRtn As ATM00420StreamingDTO = Nothing

        Try
            loRtn = loCls.activate(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function deActivate(poParam As ATM00400Back.ATM00400DTO) As ATM00400Common.ATM00420StreamingDTO Implements IATM00400Service.deActivate
        Dim loException As New R_Exception
        Dim loCls As New ATM00420CLS
        Dim loRtn As ATM00420StreamingDTO = Nothing

        Try
            loRtn = loCls.deActivate(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getLastDate(pcCompId As String) As String Implements IATM00400Service.getLastDate
        Dim loException As New R_Exception
        Dim loCls As New ATM00400Cls
        Dim lcRtn As String

        Try
            lcRtn = loCls.getLastDate(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return lcRtn
    End Function
     
End Class

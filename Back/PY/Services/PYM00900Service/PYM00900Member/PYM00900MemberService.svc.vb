Imports R_Common
Imports PYM00900Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00900MemberService" in code, svc and config file together.
Public Class PYM00900MemberService
    Implements IPYM00900MemberService

    Public Sub Svc_R_Delete(poEntity As PYM00900Back.PYM00900MemberDTO) Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900MemberDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900MemberCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00900Back.PYM00900MemberDTO) As PYM00900Back.PYM00900MemberDTO Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900MemberDTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As PYM00900Back.PYM00900MemberDTO, poCRUDMode As R_Common.eCRUDMode) As PYM00900Back.PYM00900MemberDTO Implements R_BackEnd.R_IServicebase(Of PYM00900Back.PYM00900MemberDTO).Svc_R_Save

    End Function

    Public Sub assignMember(poParam As PYM00900Back.PYM00900MemberDTO) Implements IPYM00900MemberService.assignMember
        Dim loEx As New R_Exception
        Dim loCls As New PYM00900MemberCls

        Try
            loCls.assignMember(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class

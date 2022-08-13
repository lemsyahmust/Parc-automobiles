Public Partial Class ImpCrysMatricule
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            Dim crp As New CrysMatricule
            CrystalReportViewer1.ReportSource = crp

        End If


    End Sub

    Protected Sub CrystalReportViewer1_Init(ByVal sender As Object, ByVal e As EventArgs) Handles CrystalReportViewer1.Init



    End Sub

    Protected Sub BtnEnd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnd.Click
        Response.Redirect("CParMatricule.aspx")
    End Sub
End Class
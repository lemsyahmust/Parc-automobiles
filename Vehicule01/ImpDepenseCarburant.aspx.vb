Public Partial Class WebForm41
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            Dim crp As New CrysDepense
            CrystalReportViewer1.ReportSource = crp

        End If
    End Sub

    Protected Sub BtnEnd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnd.Click

        Dim crp As New CrysDepense
        CrystalReportViewer1.ReportSource = crp

    End Sub
End Class
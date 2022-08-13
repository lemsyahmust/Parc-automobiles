Imports System.Data.SqlClient

Partial Public Class WebForm36
    Inherits System.Web.UI.Page


    Sub Msg_Erreur(ByVal x As String)
        Lblerror.ForeColor = Drawing.Color.Red
        Lblerror.Text = ""
        Lblerror.Visible = True
        img_succes.Visible = False
        img_error.Visible = True
        Lblerror.Text = x
    End Sub
    Sub Msg_succes(ByVal x As String)
        Lblerror.ForeColor = Drawing.Color.SeaGreen
        Lblerror.Text = ""
        Lblerror.Visible = True
        img_error.Visible = False
        img_succes.Visible = True
        Lblerror.Text = x
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            '*********Matricule Vehicule

            cbxMatricule.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct mat_vehi From Vehicule ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            Do
                cbxMatricule.Items.Add(dr.Item("mat_vehi"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()

            CrystalReportViewer1.Visible = False


        End If
    End Sub

    Protected Sub BtnEnd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnd.Click

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        If txtbxDateDebut.Text <> Nothing And txtbxDateFin.Text <> Nothing Then

            If Not IsDate(Me.txtbxDateDebut.Text) Or Not IsDate(Me.txtbxDateFin.Text) Then
                Msg_Erreur(" Format date et jj/mm/aa ")

            Else

                'Dim req0 As String

                'req0 = "select mat_vehi,date from ReparationT where date between '" & txtbxDateDebut.Text & "' and '" & txtbxDateFin.Text & "' and mat_vehi='" & cbxMatricule.Text & "'"

                'Dim cmd0 As New SqlCommand(req0, con)
                'con.Close()
                'con.Open()
                'Dim dr0 As SqlDataReader
                'dr0 = cmd0.ExecuteReader
                'Dim trouve As Boolean
                'trouve = False

                'Do While dr0.Read
                '    trouve = True
                'Loop
                'dr0.Close()
                'If trouve = True Then

                CrystalReportViewer1.Visible = True

                Dim da As New SqlDataAdapter("SELECT   distinct  dbo.Vehicule.lib_marqq, dbo.ReparationT.Date, dbo.ReparationT.Ref, dbo.ReparationT.Descp, dbo.Intervention.Lib_Reparation, dbo.ReparationT.Prix, dbo.Reparateur.lib_reparateur, dbo.ReparationT.mat_vehi FROM dbo.Vehicule INNER JOIN dbo.ReparationT ON dbo.Vehicule.mat_vehi = dbo.ReparationT.mat_vehi INNER JOIN dbo.Intervention ON dbo.ReparationT.N_RepT = dbo.Intervention.N_RepT INNER JOIN dbo.Reparateur ON dbo.ReparationT.n_rep = dbo.Reparateur.n_reparateur where dbo.ReparationT.Date between '" & txtbxDateDebut.Text & "' and '" & txtbxDateFin.Text & "' and Vehicule.mat_vehi='" & cbxMatricule.Text & "'", con)
                Dim dt As New DataTable
                da.Fill(dt)

                Dim crp As New CrysParRepa
                crp.SetDataSource(dt)

                'Me.CrystalReportViewer1.SelectionFormula = "in datetime('" & txtbxDateDebut.Text & "') to datetime('" & txtbxDateFin.Text & "')"

                CrystalReportViewer1.ReportSource = crp

                con.Close()
                'Else

                'CrystalReportViewer1.Visible = False
                'Msg_Erreur("Aucune réparation a été effectuée dans cette période")

            End If
            End If

        ' End If

    End Sub

    Protected Sub cbxMatricule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMatricule.SelectedIndexChanged

    End Sub
End Class
Imports System.Data.SqlClient

Partial Public Class WebForm39
    Inherits System.Web.UI.Page

    Dim tm, tct, tc As New DataTable
    Dim dat, dact, dam, dac As New SqlDataAdapter
    Dim ds As New DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            cbxMatricule.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct mat_vehi From ReparationT ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            Do
                cbxMatricule.Items.Add(dr.Item("mat_vehi"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()

        End If

    End Sub

    Protected Sub cbxMatricule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMatricule.SelectedIndexChanged

        Datagrid2.Visible = True

        Try
            '  cmd = New SqlCommand("SELECT distinct dbo.Vehicule.mat_vehi, dbo.Vehicule.lib_marqq, dbo.Vehicule.date_circul, dbo.consommation.km, dbo.Affectation.lib_aff, dbo.etat_vehicule.lib_etat_vehi FROM dbo.Vehicule INNER JOIN dbo.consommation ON dbo.Vehicule.n_vehi = dbo.consommation.n_vehi INNER JOIN dbo.etat_vehicule ON dbo.Vehicule.n_etat_vehi = dbo.etat_vehicule.n_etat_vehi INNER JOIN dbo.Affectation ON dbo.Vehicule.n_aff = dbo.Affectation.n_aff and dbo.Vehicule.mat_vehi= '" & cbxMatricule.Text & "'", con)
            cmd = New SqlCommand("select RT.mat_vehi,R.lib_reparateur ,RT.Ref,RT.Date,C.souche,C.montant,C.N_Fact  from consommation C, ReparationT RT, Reparateur R where RT.N_RepT=C.N_RepT and RT.n_rep=R.n_reparateur and RT.mat_vehi='" & cbxMatricule.Text & "'", con)
            dact = New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            dact.Fill(ds, "ReparationT")
            tct = ds.Tables("ReparationT")
            Datagrid2.DataSource = ds.Tables("ReparationT")
            Datagrid2.DataBind()
            con.Close()

        Catch ex As Exception
            

        End Try
        con.Close()
    End Sub

    
    Protected Sub BtnEnd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnd.Click

        Response.Redirect("ImpDepenseReparation.aspx")

    End Sub
End Class
